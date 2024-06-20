using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.Audio;
using Terraria.GameContent;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.ItemDropRules;
using Terraria.GameContent.Personalities;
using Terraria.GameContent.UI;
using Terraria.ID;
using Terraria.IO;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.Utilities;

namespace TLR.Content.Core.NPCs
{
	// [AutoloadHead] and NPC.townNPC are extremely important and absolutely both necessary for any Town NPC to work at all.
	[AutoloadHead]
	public class Sorcerer : ModNPC
	{
        public override bool IsLoadingEnabled(Mod mod) => false;
        public const string ShopName = "Shop";
		public const string ConjName = "Conjuration";
		public int NumberOfTimesTalkedTo = 0;

		private static int ShimmerHeadIndex;
		private static Profiles.StackedNPCProfile NPCProfile;

		public override void Load() {
			// Adds our Shimmer Head to the NPCHeadLoader.
			ShimmerHeadIndex = Mod.AddNPCHeadTexture(Type, Texture + "_Shimmer_Head");
		}

		public override void SetStaticDefaults() {
			Main.npcFrameCount[Type] = 25; // The total amount of frames the NPC has

			NPCID.Sets.ExtraFramesCount[Type] = 9; // Generally for Town NPCs, but this is how the NPC does extra things such as sitting in a chair and talking to other NPCs. This is the remaining frames after the walking frames.
			NPCID.Sets.AttackFrameCount[Type] = 4; // The amount of frames in the attacking animation.
			NPCID.Sets.DangerDetectRange[Type] = 700; // The amount of pixels away from the center of the NPC that it tries to attack enemies.
			NPCID.Sets.AttackType[Type] = 2; // The type of attack the Town NPC performs. 0 = throwing, 1 = shooting, 2 = magic, 3 = melee
			NPCID.Sets.AttackTime[Type] = 90; // The amount of time it takes for the NPC's attack animation to be over once it starts.
			NPCID.Sets.AttackAverageChance[Type] = 30; // The denominator for the chance for a Town NPC to attack. Lower numbers make the Town NPC appear more aggressive.
			NPCID.Sets.HatOffsetY[Type] = 4; // For when a party is active, the party hat spawns at a Y offset.
			NPCID.Sets.ShimmerTownTransform[NPC.type] = true; // This set says that the Town NPC has a Shimmered form. Otherwise, the Town NPC will become transparent when touching Shimmer like other enemies.

			NPCID.Sets.ShimmerTownTransform[Type] = true; // Allows for this NPC to have a different texture after touching the Shimmer liquid.

			// Influences how the NPC looks in the Bestiary
			NPCID.Sets.NPCBestiaryDrawModifiers drawModifiers = new NPCID.Sets.NPCBestiaryDrawModifiers() {
				Velocity = 1f, // Draws the NPC in the bestiary as if its walking +1 tiles in the x direction
				Direction = 1 // -1 is left and 1 is right. NPCs are drawn facing the left by default but ExamplePerson will be drawn facing the right
				// Rotation = MathHelper.ToRadians(180) // You can also change the rotation of an NPC. Rotation is measured in radians
				// If you want to see an example of manually modifying these when the NPC is drawn, see PreDraw
			};

			NPCID.Sets.NPCBestiaryDrawOffset.Add(Type, drawModifiers);

			// Set Example Person's biome and neighbor preferences with the NPCHappiness hook. You can add happiness text and remarks with localization (See an example in ExampleMod/Localization/en-US.lang).
			// NOTE: The following code uses chaining - a style that works due to the fact that the SetXAffection methods return the same NPCHappiness instance they're called on.
			NPC.Happiness
				.SetBiomeAffection<ForestBiome>(AffectionLevel.Love) // Example Person prefers the forest.
				.SetBiomeAffection<UndergroundBiome>(AffectionLevel.Like) // Example Person dislikes the snow.
				.SetBiomeAffection<HallowBiome>(AffectionLevel.Dislike) // Example Person prefers the forest.
				.SetNPCAffection(NPCID.Wizard, AffectionLevel.Love) // Loves living near the dryad.
				.SetNPCAffection(NPCID.Guide, AffectionLevel.Like)
				.SetNPCAffection(NPCID.Truffle, AffectionLevel.Like)
				.SetNPCAffection(NPCID.Cyborg, AffectionLevel.Dislike)
				.SetNPCAffection(NPCID.WitchDoctor, AffectionLevel.Hate) // Dislikes living near the merchant.
				// .SetNPCAffection(NPCID.Demolitionist, AffectionLevel.Hate) // Hates living near the demolitionist.
			; // < Mind the semicolon!

			// This creates a "profile" for ExamplePerson, which allows for different textures during a party and/or while the NPC is shimmered.
			NPCProfile = new Profiles.StackedNPCProfile(
				new Profiles.DefaultNPCProfile(Texture, NPCHeadLoader.GetHeadSlot(HeadTexture), Texture + "_Party"),
				new Profiles.DefaultNPCProfile(Texture + "_Shimmer", ShimmerHeadIndex, Texture + "_Shimmer_Party")
			);
		}

		public override void SetDefaults() {
			NPC.townNPC = true; // Sets NPC to be a Town NPC
			NPC.friendly = true; // NPC Will not attack player
			NPC.width = 18;
			NPC.height = 40;
			NPC.aiStyle = 7;
			NPC.damage = 80;
			NPC.defense = 15;
			NPC.lifeMax = 400;
			NPC.HitSound = SoundID.NPCHit1;
			NPC.DeathSound = SoundID.NPCDeath1;
			NPC.knockBackResist = 0.5f;

			AnimationType = NPCID.Princess;
		}

		public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry) {
			// We can use AddRange instead of calling Add multiple times in order to add multiple items at once
			bestiaryEntry.Info.AddRange(new IBestiaryInfoElement[] {
				// Sets the preferred biomes of this town NPC listed in the bestiary.
				// With Town NPCs, you usually set this to what biome it likes the most in regards to NPC happiness.
				BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.Surface,

				// Sets your NPC's flavor text in the bestiary.
				new FlavorTextBestiaryInfoElement("From another world with more boxes and more dimensions, she got lost in our world."),

				// You can add multiple elements if you really wanted to
				// You can also use localization keys (see Localization/en-US.lang)
				// new FlavorTextBestiaryInfoElement("Mods.ExampleMod.Bestiary.ExamplePerson")
			});
		}

		// The PreDraw hook is useful for drawing things before our sprite is drawn or running code before the sprite is drawn
		// Returning false will allow you to manually draw your NPC
		public override bool PreDraw(SpriteBatch spriteBatch, Vector2 screenPos, Color drawColor) {
			// This code slowly rotates the NPC in the bestiary
			// (simply checking NPC.IsABestiaryIconDummy and incrementing NPC.Rotation won't work here as it gets overridden by drawModifiers.Rotation each tick)
			if (NPCID.Sets.NPCBestiaryDrawOffset.TryGetValue(Type, out NPCID.Sets.NPCBestiaryDrawModifiers drawModifiers)) {
				drawModifiers.Rotation += 0.001f;

				// Replace the existing NPCBestiaryDrawModifiers with our new one with an adjusted rotation
				NPCID.Sets.NPCBestiaryDrawOffset.Remove(Type);
				NPCID.Sets.NPCBestiaryDrawOffset.Add(Type, drawModifiers);
			}

			return true;
		}

		public override void HitEffect(NPC.HitInfo hit) {
			int num = NPC.life > 0 ? 1 : 5;

			// Create gore when the NPC is killed.
			if (Main.netMode != NetmodeID.Server && NPC.life <= 0) {
				// Retrieve the gore types. This NPC has shimmer and party variants for head, arm, and leg gore. (12 total gores)
				string variant = "";
				if (NPC.IsShimmerVariant) variant += "_Shimmer";
				if (NPC.altTexture == 1) variant += "_Party";
				int hatGore = NPC.GetPartyHatGore();
				int headGore = Mod.Find<ModGore>($"{Name}_Gore{variant}_Head").Type;
				int armGore = Mod.Find<ModGore>($"{Name}_Gore{variant}_Arm").Type;
				int legGore = Mod.Find<ModGore>($"{Name}_Gore{variant}_Leg").Type;

				// Spawn the gores. The positions of the arms and legs are lowered for a more natural look.
				if (hatGore > 0) {
					Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, hatGore);
				}
				Gore.NewGore(NPC.GetSource_Death(), NPC.position, NPC.velocity, headGore, 1f);
				Gore.NewGore(NPC.GetSource_Death(), NPC.position + new Vector2(0, 20), NPC.velocity, armGore);
				Gore.NewGore(NPC.GetSource_Death(), NPC.position + new Vector2(0, 20), NPC.velocity, armGore);
				Gore.NewGore(NPC.GetSource_Death(), NPC.position + new Vector2(0, 34), NPC.velocity, legGore);
				Gore.NewGore(NPC.GetSource_Death(), NPC.position + new Vector2(0, 34), NPC.velocity, legGore);
			}
		}

		public override bool CanTownNPCSpawn(int numTownNPCs) { // Requirements for the town NPC to spawn.
			if (NPC.downedQueenSlime) {
				return true;
			}
			return false;
		}

		// Example Person needs a house built out of ExampleMod tiles. You can delete this whole method in your townNPC for the regular house conditions.

		public override ITownNPCProfile TownNPCProfile() {
			return NPCProfile;
		}

		public override List<string> SetNPCNameList() {
			return new List<string>() {
				"Alaine",
				"Socras",
				"Alex",
				"Magaline"
			};
		}

		public override void FindFrame(int frameHeight) {
			/*npc.frame.Width = 40;
			if (((int)Main.time / 10) % 2 == 0)
			{
				npc.frame.X = 40;
			}
			else
			{
				npc.frame.X = 0;
			}*/
		}

		public override string GetChat() {
			WeightedRandom<string> chat = new WeightedRandom<string>();

			int wizard = NPC.FindFirstNPC(NPCID.Wizard);
			if (wizard >= 0 && Main.rand.NextBool(4)) {
				chat.Add("Has " + Main.npc[wizard].GivenName + " talked about me lately?");
			}
			// These are things that the NPC has a chance of telling you when you talk to it.
			chat.Add("Where the hell am I...");
			chat.Add("This place has one less dimension than the last place...");
			chat.Add("Can you not see them? Beyond the wall of glass? What do you mean you can't!?");
			chat.Add("Hmh. Even with the lack of the third dimension... this place does have alot more stuff...")
;
			string chosenChat = chat; // chat is implicitly cast to a string. This is where the random choice is made.

			// Here is some additional logic based on the chosen chat line. In this case, we want to display an item in the corner for StandardDialogue4.
			/*
            if (chosenChat == Language.GetTextValue("Mods.ExampleMod.Dialogue.ExamplePerson.StandardDialogue4")) {
				// Main.npcChatCornerItem shows a single item in the corner, like the Angler Quest chat.
				Main.npcChatCornerItem = ItemID.HiveBackpack;
			}
            */

			return chosenChat;
		}

		public override void SetChatButtons(ref string button, ref string button2) { // What the chat buttons are when you open up the chat UI
			button = "Shop";
			button2 = "Conjuration";
		}

		public override void OnChatButtonClicked(bool firstButton, ref string shop) {
			if (firstButton) {
				// We want 3 different functionalities for chat buttons, so we use HasItem to change button 1 between a shop and upgrade action.
				shop = ShopName; // Name of the shop tab we want to open.
			}
			else {
				shop = ConjName;
			}
		}

		// Not completely finished, but below is what the NPC will sell
		public override void AddShops() {
			var npcShop = new NPCShop(Type, ShopName)
				.Add<Items.Consumable.SorcererPearl>();
				//.Add<EquipMaterial>()
				//.Add<BossItem>()
                /*
				.Add(new Item(ModContent.ItemType<Items.Placeable.Furniture.ExampleWorkbench>()) { shopCustomPrice = Item.buyPrice(copper: 15) }) // This example sets a custom price, ExampleNPCShop.cs has more info on custom prices and currency. 
				.Add<Items.Placeable.Furniture.ExampleChair>()
				.Add<Items.Consumables.ExampleHealingPotion>(new Condition("Mods.ExampleMod.Conditions.PlayerHasLifeforceBuff", () => Main.LocalPlayer.HasBuff(BuffID.Lifeforce)))
				.Add<Items.Weapons.ExampleSword>(Condition.MoonPhasesQuarter0)
				.Add<Items.Weapons.ExampleStaff>(ExampleConditions.DownedMinionBoss)
				.Add<Items.Weapons.ExampleYoyo>(Condition.IsNpcShimmered); // Let's sell an yoyo if this NPC is shimmered!

			if (ModContent.GetInstance<ExampleModConfig>().ExampleWingsToggle) {
				npcShop.Add<ExampleWings>(ExampleConditions.InExampleBiome);
			}

			if (ModContent.TryFind("SummonersAssociation/BloodTalisman", out ModItem bloodTalisman)) {
				npcShop.Add(bloodTalisman.Type);
			}
            */
			npcShop.Register(); // Name of this shop tab
			var npcShop2 = new NPCShop(Type, ConjName)
				// Forest Loot
				.Add(new Item(ItemID.SlimeStaff) { shopCustomPrice = 500, shopSpecialCurrency = TLR.ForestEssenceId })
				.Add(new Item(ItemID.ZombieArm) { shopCustomPrice = 50, shopSpecialCurrency = TLR.ForestEssenceId })
				.Add(new Item(ItemID.Gel) { shopCustomPrice = 1, shopSpecialCurrency = TLR.ForestEssenceId })
				.Add(new Item(ItemID.TatteredCloth) { shopCustomPrice = 20, shopSpecialCurrency = TLR.ForestEssenceId })
				.Add(new Item(ItemID.Lens) { shopCustomPrice = 5, shopSpecialCurrency = TLR.ForestEssenceId })
				.Add(new Item(ItemID.BlackLens) { shopCustomPrice = 25, shopSpecialCurrency = TLR.ForestEssenceId })
				.Add(new Item(ItemID.SpiffoPlush) { shopCustomPrice = 500, shopSpecialCurrency = TLR.ForestEssenceId })
				.Add(new Item(ItemID.Shackle) { shopCustomPrice = 75, shopSpecialCurrency = TLR.ForestEssenceId })
				.Add(new Item(ItemID.LivingWoodWand) { shopCustomPrice = 100, shopSpecialCurrency = TLR.ForestEssenceId })
				.Add(new Item(ItemID.LeafWand) { shopCustomPrice = 100, shopSpecialCurrency = TLR.ForestEssenceId })
				.Add(new Item(ItemID.EucaluptusSap) { shopCustomPrice = 2500, shopSpecialCurrency = TLR.ForestEssenceId })
				// Hardmode Forest Loot
				.Add(new Item(ItemID.MoonCharm) { shopCustomPrice = 200, shopSpecialCurrency = TLR.ForestEssenceId }, Condition.Hardmode)
				.Add(new Item(ItemID.AdhesiveBandage) { shopCustomPrice = 200, shopSpecialCurrency = TLR.ForestEssenceId }, Condition.Hardmode)
				.Add(new Item(ItemID.FastClock) { shopCustomPrice = 200, shopSpecialCurrency = TLR.ForestEssenceId }, Condition.Hardmode)
				// Desert Loot
				.Add(new Item(ItemID.DungeonDesertKey) { shopCustomPrice = 2500, shopSpecialCurrency = TLR.DesertEssenceId }, Condition.Hardmode)
				.Add(new Item(ItemID.FastClock) { shopCustomPrice = 200, shopSpecialCurrency = TLR.DesertEssenceId })
				.Add(new Item(ItemID.AntlionMandible) { shopCustomPrice = 5, shopSpecialCurrency = TLR.DesertEssenceId })
				.Add(new Item(ItemID.DungeonDesertKey) { shopCustomPrice = 2500, shopSpecialCurrency = TLR.DesertEssenceId })
				.Add(new Item(ItemID.BananaSplit) { shopCustomPrice = 200, shopSpecialCurrency = TLR.DesertEssenceId })
				.Add(new Item(ItemID.FossilOre) { shopCustomPrice = 5, shopSpecialCurrency = TLR.DesertEssenceId })
				.Add(new Item(ItemID.FriedEgg) { shopCustomPrice = 5, shopSpecialCurrency = TLR.DesertEssenceId })
				.Add(new Item(ItemID.AncientCloth) { shopCustomPrice = 10, shopSpecialCurrency = TLR.DesertEssenceId }, Condition.Hardmode)
				.Add(new Item(ItemID.DjinnLamp) { shopCustomPrice = 200, shopSpecialCurrency = TLR.DesertEssenceId }, Condition.Hardmode)
				.Add(new Item(ItemID.DjinnsCurse) { shopCustomPrice = 200, shopSpecialCurrency = TLR.DesertEssenceId }, Condition.Hardmode)
				.Add(new Item(ItemID.DjinnLamp) { shopCustomPrice = 200, shopSpecialCurrency = TLR.DesertEssenceId }, Condition.Hardmode)
				.Add(new Item(ItemID.LamiaHat) { shopCustomPrice = 250, shopSpecialCurrency = TLR.DesertEssenceId }, Condition.Hardmode)
				.Add(new Item(ItemID.LamiaShirt) { shopCustomPrice = 250, shopSpecialCurrency = TLR.DesertEssenceId }, Condition.Hardmode)
				.Add(new Item(ItemID.LamiaPants) { shopCustomPrice = 250, shopSpecialCurrency = TLR.DesertEssenceId }, Condition.Hardmode)
				.Add(new Item(ItemID.SunMask) { shopCustomPrice = 250, shopSpecialCurrency = TLR.DesertEssenceId }, Condition.Hardmode)
				.Add(new Item(ItemID.MoonMask) { shopCustomPrice = 250, shopSpecialCurrency = TLR.DesertEssenceId }, Condition.Hardmode)
				.Add(new Item(ItemID.AncientHorn) { shopCustomPrice = 300, shopSpecialCurrency = TLR.DesertEssenceId }, Condition.Hardmode)
				.Add(new Item(ItemID.AncientChisel) { shopCustomPrice = 150, shopSpecialCurrency = TLR.DesertEssenceId })
				.Add(new Item(ItemID.SandBoots) { shopCustomPrice = 150, shopSpecialCurrency = TLR.DesertEssenceId })
				.Add(new Item(ItemID.ThunderSpear) { shopCustomPrice = 150, shopSpecialCurrency = TLR.DesertEssenceId })
				.Add(new Item(ItemID.ThunderStaff) { shopCustomPrice = 150, shopSpecialCurrency = TLR.DesertEssenceId })
				.Add(new Item(ItemID.MagicConch) { shopCustomPrice = 150, shopSpecialCurrency = TLR.DesertEssenceId })
				.Add(new Item(ItemID.EncumberingStone) { shopCustomPrice = 150, shopSpecialCurrency = TLR.DesertEssenceId })
				.Add(new Item(ItemID.CatBast) { shopCustomPrice = 150, shopSpecialCurrency = TLR.DesertEssenceId })
				.Add(new Item(ItemID.MysticCoilSnake) { shopCustomPrice = 150, shopSpecialCurrency = TLR.DesertEssenceId })
				// Snow Loot
				.Add(new Item(ItemID.FrozenKey) { shopCustomPrice = 2500, shopSpecialCurrency = TLR.SnowEssenceId }, Condition.Hardmode)
				.Add(new Item(ItemID.EskimoHood) { shopCustomPrice = 250, shopSpecialCurrency = TLR.SnowEssenceId })
				.Add(new Item(ItemID.EskimoCoat) { shopCustomPrice = 250, shopSpecialCurrency = TLR.SnowEssenceId })
				.Add(new Item(ItemID.EskimoPants) { shopCustomPrice = 250, shopSpecialCurrency = TLR.SnowEssenceId })
				.Add(new Item(ItemID.PedguinHat) { shopCustomPrice = 250, shopSpecialCurrency = TLR.SnowEssenceId })
				.Add(new Item(ItemID.PedguinShirt) { shopCustomPrice = 250, shopSpecialCurrency = TLR.SnowEssenceId })
				.Add(new Item(ItemID.PedguinPants) { shopCustomPrice = 250, shopSpecialCurrency = TLR.SnowEssenceId })
				.Add(new Item(ItemID.SnowHat) { shopCustomPrice = 250, shopSpecialCurrency = TLR.SnowEssenceId })
				.Add(new Item(ItemID.IceCream) { shopCustomPrice = 200, shopSpecialCurrency = TLR.SnowEssenceId })
				.Add(new Item(ItemID.WolfMountItem) { shopCustomPrice = 100, shopSpecialCurrency = TLR.SnowEssenceId }, Condition.Hardmode)
				.Add(new Item(ItemID.FrostStaff) { shopCustomPrice = 100, shopSpecialCurrency = TLR.SnowEssenceId }, Condition.Hardmode)
				.Add(new Item(ItemID.IceSickle) { shopCustomPrice = 150, shopSpecialCurrency = TLR.SnowEssenceId }, Condition.Hardmode)
				.Add(new Item(ItemID.Amarok) { shopCustomPrice = 300, shopSpecialCurrency = TLR.SnowEssenceId }, Condition.Hardmode)
				.Add(new Item(ItemID.HamBat) { shopCustomPrice = 250, shopSpecialCurrency = TLR.SnowEssenceId }, Condition.Hardmode)
				.Add(new Item(ItemID.Bacon) { shopCustomPrice = 250, shopSpecialCurrency = TLR.SnowEssenceId }, Condition.Hardmode)
				.Add(new Item(ItemID.PigronMinecart) { shopCustomPrice = 250, shopSpecialCurrency = TLR.SnowEssenceId }, Condition.Hardmode)
				.Add(new Item(ItemID.KitePigron) { shopCustomPrice = 250, shopSpecialCurrency = TLR.SnowEssenceId }, Condition.Hardmode)
				.Add(new Item(ItemID.FrozenTurtleShell) { shopCustomPrice = 100, shopSpecialCurrency = TLR.SnowEssenceId }, Condition.Hardmode)
				.Add(new Item(ItemID.Frostbrand) { shopCustomPrice = 350, shopSpecialCurrency = TLR.SnowEssenceId }, Condition.Hardmode)
				// Underground Loot

				/*
				.Add(new Item(ItemID.ZombieArm) { shopCustomPrice = 50, shopSpecialCurrency = TLR.ForestEssenceId })
				.Add(new Item(ModContent.ItemType<Items.Placeable.Furniture.ExampleWorkbench>()) { shopCustomPrice = Item.buyPrice(copper: 15) }) // This example sets a custom price, ExampleNPCShop.cs has more info on custom prices and currency. 
				.Add<Items.Placeable.Furniture.ExampleChair>()
				.Add<Items.Consumables.ExampleHealingPotion>(new Condition("Mods.ExampleMod.Conditions.PlayerHasLifeforceBuff", () => Main.LocalPlayer.HasBuff(BuffID.Lifeforce)))
				.Add<Items.Weapons.ExampleSword>(Condition.MoonPhasesQuarter0)
				.Add<Items.Weapons.ExampleStaff>(ExampleConditions.DownedMinionBoss)
				.Add<Items.Weapons.ExampleYoyo>(Condition.IsNpcShimmered); // Let's sell an yoyo if this NPC is shimmered!

			if (ModContent.GetInstance<ExampleModConfig>().ExampleWingsToggle) {
				npcShop.Add<ExampleWings>(ExampleConditions.InExampleBiome);
			}

			if (ModContent.TryFind("SummonersAssociation/BloodTalisman", out ModItem bloodTalisman)) {
				npcShop.Add(bloodTalisman.Type);
			}
            */
			npcShop2.Register(); // Name of this shop tab
		}

		public override void ModifyActiveShop(string shopName, Item[] items) {
			foreach (Item item in items) {
				// Skip 'air' items and null items.
				if (item == null || item.type == ItemID.None) {
					continue;
				}
			}
		}

		public override void ModifyNPCLoot(NPCLoot npcLoot) {
		}

		// Make this Town NPC teleport to the King and/or Queen statue when triggered. Return toKingStatue for only King Statues. Return !toKingStatue for only Queen Statues. Return true for both.
		public override bool CanGoToStatue(bool toKingStatue) => false;

		// Create a square of pixels around the NPC on teleport.

		public override void TownNPCAttackStrength(ref int damage, ref float knockback) {
			damage = 80;
			knockback = 4f;
		}

		public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown) {
			cooldown = 30;
			randExtraCooldown = 30;
		}

		public override void TownNPCAttackProj(ref int projType, ref int attackDelay) {
			projType = ProjectileID.RainbowRodBullet;
			attackDelay = 1;
		}

		public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset) {
			multiplier = 12f;
			randomOffset = 2f;
			// SparklingBall is not affected by gravity, so gravityCorrection is left alone.
		}

		// Let the NPC "talk about" minion boss
        /*
		public override int? PickEmote(Player closestPlayer, List<int> emoteList, WorldUIAnchor otherAnchor) {
			// By default this NPC will have a chance to use the Minion Boss Emote even if Minion Boss is not downed yet
			int type = ModContent.EmoteBubbleType<MinionBossEmote>();
			// If the NPC is talking to the Demolitionist, it will be more likely to react with angry emote
			if (otherAnchor.entity is NPC { type: NPCID.Demolitionist }) {
				type = EmoteID.EmotionAnger;
			}

			// Make the selection more likely by adding it to the list multiple times
			for (int i = 0; i < 4; i++) {
				emoteList.Add(type);
			}

			// Use this or return null if you don't want to override the emote selection totally
			return base.PickEmote(closestPlayer, emoteList, otherAnchor);
		}
        */
	}
}