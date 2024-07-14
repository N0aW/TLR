using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using TLR.Content.Core.Items.Accessories.Combat.Defensive;
using TLR.Content.Core.Tiles;
using tModPorter.Rewriters;

namespace TLR.Content.Core
{
	// This class contains thoughtful examples of item recipe creation.
	// Recipes are explained in detail on the https://github.com/tModLoader/tModLoader/wiki/Basic-Recipes and https://github.com/tModLoader/tModLoader/wiki/Intermediate-Recipes wiki pages. Please visit the wiki to learn more about recipes if anything is unclear.
	public class TLRRecipes : ModSystem
	{
		// A place to store the recipe group so we can easily use it later
		public static RecipeGroup group;

		public override void Unload() {
			group = null;
		}

		public override void AddRecipeGroups() {
			group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Tier 2 DD2 Accessory", new int[]
			{
				ItemID.SquireShield, ItemID.HuntressBuckler, ItemID.ApprenticeScarf, ItemID.MonkBelt
			});
			RecipeGroup.RegisterGroup("TLR:T2DD2Accessory", group);
		}
		/*
		public override void PostAddRecipes()
        {
            for (int i = 0; i < Recipe.numRecipes; i++)
            {
                Recipe recipe = Main.recipe[i];

                if (recipe.HasResult(ItemID.ObsidianShield))
                {
                    recipe.AddIngredient(ModContent.ItemType<Items.Accessories.Combat.Defensive.PalladiumShield>());
                }
			}
		}
		*/
        public override void AddRecipes() {
			// EXCLUDES: Unsafe Wall Recipes, DD2 Sentry Staff Conversion, Ancient Armor, Downgrading. They may be added later? Make a PR if you want them sooner.
			Recipe shimmer0 = Recipe.Create(ModContent.ItemType<ShimmerBallItem>()); shimmer0.AddIngredient(ItemID.CrystalBall); shimmer0.AddTile<ShimmerBallTile>(); shimmer0.Register();
			Recipe shimmer1 = Recipe.Create(ItemID.AegisCrystal); shimmer1.AddIngredient(ItemID.LifeCrystal); shimmer1.AddTile<ShimmerBallTile>(); shimmer1.Register();
			Recipe shimmer2 = Recipe.Create(ItemID.ArcaneCrystal); shimmer2.AddIngredient(ItemID.ManaCrystal); shimmer2.AddTile<ShimmerBallTile>(); shimmer2.Register();
			Recipe shimmer3 = Recipe.Create(ItemID.AegisFruit); shimmer3.AddIngredient(ItemID.LifeFruit); shimmer3.AddTile<ShimmerBallTile>(); shimmer3.Register();
			Recipe shimmer4 = Recipe.Create(ItemID.Ambrosia); shimmer4.AddRecipeGroup(RecipeGroupID.Fruit); shimmer4.AddTile<ShimmerBallTile>(); shimmer4.Register();
			Recipe shimmer5 = Recipe.Create(ItemID.GummyWorm); shimmer5.AddIngredient(ItemID.GoldWorm); shimmer5.AddTile<ShimmerBallTile>(); shimmer5.Register();
			Recipe shimmer6 = Recipe.Create(ItemID.GalaxyPearl); shimmer6.AddIngredient(ItemID.PinkPearl); shimmer6.AddTile<ShimmerBallTile>(); shimmer6.Register();
			Recipe shimmer7 = Recipe.Create(ItemID.CombatBookVolumeTwo); shimmer7.AddIngredient(ItemID.SpellTome); shimmer7.AddTile<ShimmerBallTile>(); shimmer7.Register();
			Recipe shimmer8 = Recipe.Create(ItemID.PeddlersSatchel); shimmer8.AddIngredient(ItemID.PeddlersHat); shimmer8.AddTile<ShimmerBallTile>(); shimmer8.Register();
			Recipe shimmer9 = Recipe.Create(ItemID.RodOfHarmony); shimmer9.AddIngredient(ItemID.RodofDiscord); shimmer9.AddTile<ShimmerBallTile>(); shimmer9.AddCondition(Condition.DownedMoonLord); shimmer9.Register();
			Recipe shimmer10 = Recipe.Create(ItemID.Clentaminator2); shimmer10.AddIngredient(ItemID.Clentaminator); shimmer10.AddTile<ShimmerBallTile>(); shimmer10.AddCondition(Condition.DownedMoonLord); shimmer10.Register();
			Recipe shimmer11 = Recipe.Create(ItemID.BottomlessBucket); shimmer11.AddIngredient(ItemID.BottomlessShimmerBucket); shimmer11.AddTile<ShimmerBallTile>(); shimmer11.AddCondition(Condition.DownedMoonLord); shimmer11.Register();
			Recipe shimmer12 = Recipe.Create(ItemID.BottomlessShimmerBucket); shimmer12.AddIngredient(ItemID.BottomlessBucket); shimmer12.AddTile<ShimmerBallTile>(); shimmer12.AddCondition(Condition.DownedMoonLord); shimmer12.Register();
			Recipe shimmer13 = Recipe.Create(ItemID.GasTrap); shimmer13.AddIngredient(ItemID.WhoopieCushion); shimmer13.AddTile<ShimmerBallTile>(); shimmer13.Register();
			Recipe shimmer14 = Recipe.Create(ItemID.GasTrap); shimmer14.AddIngredient(ItemID.UsedGasTrap); shimmer14.AddTile<ShimmerBallTile>(); shimmer14.Register();
			Recipe shimmer15 = Recipe.Create(ItemID.ShimmerArrow); shimmer15.AddIngredient(ItemID.WoodenArrow); shimmer15.AddTile<ShimmerBallTile>(); shimmer15.Register();
			Recipe shimmer16 = Recipe.Create(ItemID.ShimmerArrow); shimmer16.AddIngredient(ItemID.HellfireArrow); shimmer16.AddTile<ShimmerBallTile>(); shimmer16.Register();
			Recipe shimmer17 = Recipe.Create(ItemID.ShimmerFlare); shimmer17.AddIngredient(ItemID.Flare); shimmer17.AddTile<ShimmerBallTile>(); shimmer17.Register();
			Recipe shimmer18 = Recipe.Create(ItemID.ShimmerFlare); shimmer18.AddIngredient(ItemID.BlueFlare); shimmer18.AddTile<ShimmerBallTile>(); shimmer18.Register();
			Recipe shimmer19 = Recipe.Create(ItemID.ShimmerTorch); shimmer19.AddIngredient(ItemID.Torch); shimmer19.AddTile<ShimmerBallTile>(); shimmer19.Register();
			Recipe shimmer20 = Recipe.Create(ItemID.ShimmerCampfire); shimmer20.AddIngredient(ItemID.Campfire); shimmer20.AddTile<ShimmerBallTile>(); shimmer20.Register();
			Recipe shimmer21 = Recipe.Create(ItemID.ShimmerMonolith); shimmer21.AddIngredient(ItemID.AngelStatue); shimmer21.AddTile<ShimmerBallTile>(); shimmer21.Register();
			Recipe shimmer22 = Recipe.Create(ItemID.Moondial); shimmer22.AddIngredient(ItemID.Sundial); shimmer22.AddTile<ShimmerBallTile>(); shimmer22.Register();
			Recipe shimmer23 = Recipe.Create(ItemID.ShimmerCloak); shimmer23.AddIngredient(ItemID.StarCloak); shimmer23.AddTile<ShimmerBallTile>(); shimmer23.Register();
			Recipe shimmer24 = Recipe.Create(ItemID.LavaBucket); shimmer24.AddIngredient(ItemID.WaterBucket); shimmer24.AddTile<ShimmerBallTile>(); shimmer24.Register();
			Recipe shimmer25 = Recipe.Create(ItemID.HoneyBucket); shimmer25.AddIngredient(ItemID.LavaBucket); shimmer25.AddTile<ShimmerBallTile>(); shimmer25.Register();
			Recipe shimmer26 = Recipe.Create(ItemID.WaterBucket); shimmer26.AddIngredient(ItemID.HoneyBucket); shimmer26.AddTile<ShimmerBallTile>(); shimmer26.Register();
			Recipe shimmer27 = Recipe.Create(ItemID.BabyBirdStaff); shimmer27.AddIngredient(ItemID.LivingWoodWand); shimmer27.AddTile<ShimmerBallTile>(); shimmer27.Register();
			Recipe shimmer28 = Recipe.Create(ItemID.MiningShirt); shimmer28.AddIngredient(ItemID.MiningPants); shimmer28.AddTile<ShimmerBallTile>(); shimmer28.Register();
			Recipe shimmer29 = Recipe.Create(ItemID.MiningPants); shimmer29.AddIngredient(ItemID.MiningShirt); shimmer29.AddTile<ShimmerBallTile>(); shimmer29.Register();
			Recipe shimmer30 = Recipe.Create(ItemID.AlchemyTable); shimmer30.AddIngredient(ItemID.BewitchingTable); shimmer30.AddTile<ShimmerBallTile>(); shimmer30.Register();
			Recipe shimmer31 = Recipe.Create(ItemID.BewitchingTable); shimmer31.AddIngredient(ItemID.AlchemyTable); shimmer31.AddTile<ShimmerBallTile>(); shimmer31.Register();
			Recipe shimmer32 = Recipe.Create(ItemID.CorruptionChest); shimmer32.AddIngredient(ItemID.CorruptionKey); shimmer32.AddTile<ShimmerBallTile>(); shimmer32.Register();
			Recipe shimmer33 = Recipe.Create(ItemID.CrimsonChest); shimmer33.AddIngredient(ItemID.CrimsonKey); shimmer33.AddTile<ShimmerBallTile>(); shimmer33.Register();
			Recipe shimmer34 = Recipe.Create(ItemID.HallowedChest); shimmer34.AddIngredient(ItemID.HallowedKey); shimmer34.AddTile<ShimmerBallTile>(); shimmer34.Register();
			Recipe shimmer35 = Recipe.Create(ItemID.FrozenChest); shimmer35.AddIngredient(ItemID.FrozenKey); shimmer35.AddTile<ShimmerBallTile>(); shimmer35.Register();
			Recipe shimmer36 = Recipe.Create(ItemID.JungleChest); shimmer36.AddIngredient(ItemID.JungleKey); shimmer36.AddTile<ShimmerBallTile>(); shimmer36.Register();
			Recipe shimmer37 = Recipe.Create(ItemID.DesertChest); shimmer37.AddIngredient(ItemID.DungeonDesertKey); shimmer37.AddTile<ShimmerBallTile>(); shimmer37.Register();
			Recipe shimmer38 = Recipe.Create(ItemID.WoodenCrate); shimmer38.AddIngredient(ItemID.WoodenCrateHard); shimmer38.AddTile<ShimmerBallTile>(); shimmer38.Register();
			Recipe shimmer39 = Recipe.Create(ItemID.IronCrate); shimmer39.AddIngredient(ItemID.IronCrateHard); shimmer39.AddTile<ShimmerBallTile>(); shimmer39.Register();
			Recipe shimmer40 = Recipe.Create(ItemID.GoldenCrate); shimmer40.AddIngredient(ItemID.GoldenCrateHard); shimmer40.AddTile<ShimmerBallTile>(); shimmer40.Register();
			Recipe shimmer41 = Recipe.Create(ItemID.JungleFishingCrate); shimmer41.AddIngredient(ItemID.JungleFishingCrateHard); shimmer41.AddTile<ShimmerBallTile>(); shimmer41.Register();
			Recipe shimmer42 = Recipe.Create(ItemID.FloatingIslandFishingCrate); shimmer42.AddIngredient(ItemID.FloatingIslandFishingCrateHard); shimmer42.AddTile<ShimmerBallTile>(); shimmer42.Register();
			Recipe shimmer43 = Recipe.Create(ItemID.CorruptFishingCrate); shimmer43.AddIngredient(ItemID.CorruptFishingCrateHard); shimmer43.AddTile<ShimmerBallTile>(); shimmer43.Register();
			Recipe shimmer44 = Recipe.Create(ItemID.CrimsonFishingCrate); shimmer44.AddIngredient(ItemID.CrimsonFishingCrateHard); shimmer44.AddTile<ShimmerBallTile>(); shimmer44.Register();
			Recipe shimmer45 = Recipe.Create(ItemID.HallowedFishingCrate); shimmer45.AddIngredient(ItemID.HallowedFishingCrateHard); shimmer45.AddTile<ShimmerBallTile>(); shimmer45.Register();
			Recipe shimmer46 = Recipe.Create(ItemID.DungeonFishingCrate); shimmer46.AddIngredient(ItemID.DungeonFishingCrateHard); shimmer46.AddTile<ShimmerBallTile>(); shimmer46.Register();
			Recipe shimmer47 = Recipe.Create(ItemID.FrozenCrate); shimmer47.AddIngredient(ItemID.FrozenCrateHard); shimmer47.AddTile<ShimmerBallTile>(); shimmer47.Register();
			Recipe shimmer48 = Recipe.Create(ItemID.OasisCrate); shimmer48.AddIngredient(ItemID.OasisCrateHard); shimmer48.AddTile<ShimmerBallTile>(); shimmer48.Register();
			Recipe shimmer49 = Recipe.Create(ItemID.LavaCrate); shimmer49.AddIngredient(ItemID.LavaCrateHard); shimmer49.AddTile<ShimmerBallTile>(); shimmer49.Register();
			Recipe shimmer50 = Recipe.Create(ItemID.OceanCrate); shimmer50.AddIngredient(ItemID.OceanCrateHard); shimmer50.AddTile<ShimmerBallTile>(); shimmer50.Register();
			Recipe shimmer51 = Recipe.Create(ItemID.HerbBag); shimmer51.AddIngredient(ItemID.CanOfWorms); shimmer51.AddTile<ShimmerBallTile>(); shimmer51.Register();
			Recipe shimmer52 = Recipe.Create(ItemID.CanOfWorms); shimmer52.AddIngredient(ItemID.HerbBag); shimmer52.AddTile<ShimmerBallTile>(); shimmer52.Register();
			Recipe shimmer53 = Recipe.Create(ItemID.ShinyRedBalloon); shimmer53.AddIngredient(ItemID.BalloonPufferfish); shimmer53.AddTile<ShimmerBallTile>(); shimmer53.Register();
			Recipe shimmer54 = Recipe.Create(ItemID.SandstorminaBottle); shimmer54.AddIngredient(ItemID.PharaohsMask); shimmer54.AddTile<ShimmerBallTile>(); shimmer54.Register();
			Recipe shimmer55 = Recipe.Create(ItemID.FlyingCarpet); shimmer55.AddIngredient(ItemID.PharaohsRobe); shimmer55.AddTile<ShimmerBallTile>(); shimmer55.Register();
			Recipe shimmer56 = Recipe.Create(ItemID.DirtBlock); shimmer56.AddRecipeGroup(RecipeGroupID.Wood); shimmer56.AddTile<ShimmerBallTile>(); shimmer56.Register();
			Recipe shimmer57 = Recipe.Create(ItemID.PharaohsMask); shimmer57.AddIngredient(ItemID.SandstorminaBottle); shimmer57.AddTile<ShimmerBallTile>(); shimmer57.Register();
			Recipe shimmer58 = Recipe.Create(ItemID.PharaohsRobe); shimmer58.AddIngredient(ItemID.FlyingCarpet); shimmer58.AddTile<ShimmerBallTile>(); shimmer58.Register();
			Recipe shimmer59 = Recipe.Create(ItemID.MagmaStone); shimmer59.AddIngredient(ItemID.LavaCharm); shimmer59.AddTile<ShimmerBallTile>(); shimmer59.Register();
			Recipe shimmer60 = Recipe.Create(ItemID.LavaCharm); shimmer60.AddIngredient(ItemID.MagmaStone); shimmer60.AddTile<ShimmerBallTile>(); shimmer60.Register();
			Recipe shimmer61 = Recipe.Create(ItemID.WeatherRadio); shimmer61.AddIngredient(ItemID.Sextant); shimmer61.AddTile<ShimmerBallTile>(); shimmer61.Register();
			Recipe shimmer62 = Recipe.Create(ItemID.FishermansGuide); shimmer62.AddIngredient(ItemID.WeatherRadio); shimmer62.AddTile<ShimmerBallTile>(); shimmer62.Register();
			Recipe shimmer63 = Recipe.Create(ItemID.Sextant); shimmer63.AddIngredient(ItemID.FishermansGuide); shimmer63.AddTile<ShimmerBallTile>(); shimmer63.Register();
			Recipe shimmer64 = Recipe.Create(ItemID.AdhesiveBandage); shimmer64.AddIngredient(ItemID.Bezoar); shimmer64.AddTile<ShimmerBallTile>(); shimmer64.Register();
			Recipe shimmer65 = Recipe.Create(ItemID.Bezoar); shimmer65.AddIngredient(ItemID.AdhesiveBandage); shimmer65.AddTile<ShimmerBallTile>(); shimmer65.Register();
			Recipe shimmer66 = Recipe.Create(ItemID.ArmorPolish); shimmer66.AddIngredient(ItemID.Vitamins); shimmer66.AddTile<ShimmerBallTile>(); shimmer66.Register();
			Recipe shimmer67 = Recipe.Create(ItemID.Vitamins); shimmer67.AddIngredient(ItemID.ArmorPolish); shimmer67.AddTile<ShimmerBallTile>(); shimmer67.Register();
			Recipe shimmer68 = Recipe.Create(ItemID.PocketMirror); shimmer68.AddIngredient(ItemID.Blindfold); shimmer68.AddTile<ShimmerBallTile>(); shimmer68.Register();
			Recipe shimmer69 = Recipe.Create(ItemID.Blindfold); shimmer69.AddIngredient(ItemID.PocketMirror); shimmer69.AddTile<ShimmerBallTile>(); shimmer69.Register();
			Recipe shimmer70 = Recipe.Create(ItemID.FastClock); shimmer70.AddIngredient(ItemID.TrifoldMap); shimmer70.AddTile<ShimmerBallTile>(); shimmer70.Register();
			Recipe shimmer71 = Recipe.Create(ItemID.TrifoldMap); shimmer71.AddIngredient(ItemID.FastClock); shimmer71.AddTile<ShimmerBallTile>(); shimmer71.Register();
			Recipe shimmer72 = Recipe.Create(ItemID.Megaphone); shimmer72.AddIngredient(ItemID.Nazar); shimmer72.AddTile<ShimmerBallTile>(); shimmer72.Register();
			Recipe shimmer73 = Recipe.Create(ItemID.Nazar); shimmer73.AddIngredient(ItemID.Megaphone); shimmer73.AddTile<ShimmerBallTile>(); shimmer73.Register();
			Recipe shimmer74 = Recipe.Create(ItemID.WarriorEmblem); shimmer74.AddIngredient(ItemID.SummonerEmblem); shimmer74.AddTile<ShimmerBallTile>(); shimmer74.Register();
			Recipe shimmer75 = Recipe.Create(ItemID.RangerEmblem); shimmer75.AddIngredient(ItemID.WarriorEmblem); shimmer75.AddTile<ShimmerBallTile>(); shimmer75.Register();
			Recipe shimmer76 = Recipe.Create(ItemID.SorcererEmblem); shimmer76.AddIngredient(ItemID.SummonerEmblem); shimmer76.AddTile<ShimmerBallTile>(); shimmer76.Register();
			Recipe shimmer77 = Recipe.Create(ItemID.SummonerEmblem); shimmer77.AddIngredient(ItemID.SorcererEmblem); shimmer77.AddTile<ShimmerBallTile>(); shimmer77.Register();
			Recipe shimmer78 = Recipe.Create(ItemID.AnglerEarring); shimmer78.AddIngredient(ItemID.HighTestFishingLine); shimmer78.AddTile<ShimmerBallTile>(); shimmer78.Register();
			Recipe shimmer79 = Recipe.Create(ItemID.TackleBox); shimmer79.AddIngredient(ItemID.AnglerEarring); shimmer79.AddTile<ShimmerBallTile>(); shimmer79.Register();
			Recipe shimmer80 = Recipe.Create(ItemID.HighTestFishingLine); shimmer80.AddIngredient(ItemID.TackleBox); shimmer80.AddTile<ShimmerBallTile>(); shimmer80.Register();
			Recipe shimmer81 = Recipe.Create(ItemID.GoldRing); shimmer81.AddIngredient(ItemID.LuckyCoin); shimmer81.AddTile<ShimmerBallTile>(); shimmer81.Register();
			Recipe shimmer82 = Recipe.Create(ItemID.DiscountCard); shimmer82.AddIngredient(ItemID.GoldRing); shimmer82.AddTile<ShimmerBallTile>(); shimmer82.Register();
			Recipe shimmer83 = Recipe.Create(ItemID.LuckyCoin); shimmer83.AddIngredient(ItemID.DiscountCard); shimmer83.AddTile<ShimmerBallTile>(); shimmer83.Register();
			Recipe shimmer84 = Recipe.Create(ItemID.Cactus); shimmer84.AddIngredient(ItemID.Pumpkin); shimmer84.AddTile<ShimmerBallTile>(); shimmer84.Register();
			Recipe shimmer85 = Recipe.Create(ItemID.Pumpkin); shimmer85.AddIngredient(ItemID.Cactus); shimmer85.AddTile<ShimmerBallTile>(); shimmer85.Register();
			Recipe shimmer86 = Recipe.Create(ItemID.CobaltShield); shimmer86.AddIngredient(ModContent.ItemType<PalladiumShield>()); shimmer86.AddTile<ShimmerBallTile>(); shimmer86.Register();
			Recipe shimmer87 = Recipe.Create(ModContent.ItemType<PalladiumShield>()); shimmer87.AddIngredient(ItemID.CobaltShield); shimmer87.AddTile<ShimmerBallTile>(); shimmer87.Register();
			if (ModLoader.TryGetMod("BInfoAcc", out Mod BINFO) && BINFO.TryFind<ModItem>("FortuneMirror", out ModItem FortuneMirror)
				&& BINFO.TryFind<ModItem>("SmartHeart", out ModItem SmartHeart) && BINFO.TryFind<ModItem>("BiomeCrystal", out ModItem BiomeCrystal)) {
				Recipe mshimmer0 = Recipe.Create(FortuneMirror.Type); mshimmer0.AddIngredient(ItemID.MagicMirror); mshimmer0.AddTile<ShimmerBallTile>(); mshimmer0.Register();
				Recipe mshimmer1 = Recipe.Create(ItemID.MagicMirror); mshimmer1.AddIngredient(FortuneMirror.Type); mshimmer1.AddTile<ShimmerBallTile>(); mshimmer1.Register();
				Recipe mshimmer2 = Recipe.Create(SmartHeart.Type); mshimmer2.AddIngredient(ItemID.BandofRegeneration); mshimmer2.AddTile<ShimmerBallTile>(); mshimmer2.Register();
				Recipe mshimmer3 = Recipe.Create(ItemID.BandofRegeneration); mshimmer3.AddIngredient(SmartHeart.Type); mshimmer3.AddTile<ShimmerBallTile>(); mshimmer3.Register();
				Recipe mshimmer4 = Recipe.Create(BiomeCrystal.Type); mshimmer4.AddIngredient(ItemID.TeleportationPylonPurity); mshimmer4.AddTile<ShimmerBallTile>(); mshimmer4.Register();
				Recipe mshimmer5 = Recipe.Create(ItemID.TeleportationPylonPurity); mshimmer5.AddIngredient(BiomeCrystal.Type); mshimmer5.AddTile<ShimmerBallTile>(); mshimmer5.Register();
			}
			Recipe recipe = Recipe.Create(ItemID.BoneWelder);
			recipe.AddIngredient(ItemID.Bone, 100);
			recipe.AddTile(TileID.DemonAltar);
			recipe.Register();
			Recipe recipe2 = Recipe.Create(ItemID.IceMachine);
			recipe2.AddIngredient(ItemID.IceBlock, 100);
			recipe2.AddIngredient(ItemID.SnowBlock, 100);
			recipe2.AddTile(TileID.TinkerersWorkbench);
			recipe2.Register();
			Recipe recipe3 = Recipe.Create(ItemID.MeatGrinder);
			recipe3.AddIngredient(ItemID.RottenChunk, 20);
			recipe3.AddIngredient(ItemID.SoulofNight, 15);
			recipe3.AddIngredient(ItemID.DarkShard, 2);
			recipe3.AddTile(TileID.MythrilAnvil);
			recipe3.Register();
			Recipe recipe3b = Recipe.Create(ItemID.MeatGrinder);
			recipe3b.AddIngredient(ItemID.Vertebrae, 20);
			recipe3b.AddIngredient(ItemID.SoulofNight, 15);
			recipe3b.AddIngredient(ItemID.DarkShard, 2);
			recipe3b.AddTile(TileID.MythrilAnvil);
			recipe3b.Register();
			Recipe recipe4 = Recipe.Create(ItemID.HoneyDispenser);
			recipe4.AddIngredient(ItemID.HoneyBlock, 50);
			recipe4.AddIngredient(ItemID.HoneyBucket, 5);
			recipe4.AddIngredient(ItemID.BeeWax, 4);
			recipe4.AddTile(TileID.WorkBenches);
			recipe4.AddCondition(Condition.NearHoney);
			recipe4.Register();
			Recipe recipe5 = Recipe.Create(ItemID.SkyMill);
			recipe5.AddIngredient(ItemID.SunplateBlock, 30);
			recipe5.AddIngredient(ItemID.Cloud, 20);
			recipe5.AddTile(TileID.Anvils);
			recipe5.Register();
			Recipe recipe6 = Recipe.Create(ItemID.LivingLoom);
			recipe6.AddIngredient(ItemID.Wood, 50);
			recipe6.AddIngredient(ItemID.Vine, 3);
			recipe6.AddIngredient(ItemID.JungleSpores, 8);
			recipe6.AddTile(TileID.WorkBenches);
			recipe6.AddCondition(Condition.InJungle);
			recipe6.Register();
			Recipe recipe7 = Recipe.Create(ItemID.BrickLayer);
			recipe7.AddIngredient(ItemID.AncientChisel);
			recipe7.AddIngredient(ItemID.ClayBlock, 30);
			recipe7.AddIngredient(ItemID.RedBrick, 10);
			recipe7.AddTile(TileID.Anvils);
			recipe7.Register();
			Recipe recipe8 = Recipe.Create(ItemID.PortableCementMixer);
			recipe8.AddIngredient(ItemID.EmptyBucket, 2);
			recipe8.AddIngredient(ItemID.Chain, 5);
			recipe8.AddIngredient(ItemID.ClayBlock, 15);
			recipe8.AddTile(TileID.Anvils);
			recipe8.Register();
			Recipe recipe9 = Recipe.Create(ItemID.PaintSprayer);
			recipe9.AddIngredient(ItemID.Minishark);
			recipe9.AddIngredient(ItemID.CyanPaint, 10);
			recipe9.AddTile(TileID.Anvils);
			recipe9.Register();
			Recipe recipe10 = Recipe.Create(ItemID.ExtendoGrip);
			recipe10.AddIngredient(ItemID.Wrench);
			recipe10.AddIngredient(RecipeGroupID.IronBar, 10);
			recipe10.AddTile(TileID.Anvils);
			recipe10.Register();
			Recipe recipe11 = Recipe.Create(ItemID.ActuationAccessory);
			recipe11.AddIngredient(ItemID.ActuationRod);
			recipe11.AddIngredient(ItemID.Actuator, 30);
			recipe11.AddIngredient(ItemID.Wire, 25);
			recipe11.AddTile(TileID.Anvils);
			recipe11.Register();
			Recipe recipe12a = Recipe.Create(ItemID.TurtleHelmet);
			recipe12a.AddIngredient(ItemID.ChlorophyteMask);
			recipe12a.AddIngredient(ItemID.TurtleShell, 1);
			recipe12a.AddTile(TileID.MythrilAnvil);
			recipe12a.Register();
			Recipe recipe12b = Recipe.Create(ItemID.TurtleScaleMail);
			recipe12b.AddIngredient(ItemID.ChlorophytePlateMail);
			recipe12b.AddIngredient(ItemID.TurtleShell, 1);
			recipe12b.AddTile(TileID.MythrilAnvil);
			recipe12b.Register();
			Recipe recipe12c = Recipe.Create(ItemID.TurtleLeggings);
			recipe12c.AddIngredient(ItemID.ChlorophyteGreaves);
			recipe12c.AddIngredient(ItemID.TurtleShell, 1);
			recipe12c.AddTile(TileID.MythrilAnvil);
			recipe12c.Register();
			Recipe recipe13aa = Recipe.Create(ItemID.ShroomiteHeadgear);
			recipe13aa.AddIngredient(ItemID.ChlorophyteHelmet);
			recipe13aa.AddIngredient(ItemID.GlowingMushroom, 180);
			recipe13aa.AddTile(TileID.Autohammer);
			recipe13aa.Register();
			Recipe recipe13ab = Recipe.Create(ItemID.ShroomiteHelmet);
			recipe13ab.AddIngredient(ItemID.ChlorophyteHelmet);
			recipe13ab.AddIngredient(ItemID.GlowingMushroom, 180);
			recipe13ab.AddTile(TileID.Autohammer);
			recipe13ab.Register();
			Recipe recipe13ac = Recipe.Create(ItemID.ShroomiteMask);
			recipe13ac.AddIngredient(ItemID.ChlorophyteHelmet);
			recipe13ac.AddIngredient(ItemID.GlowingMushroom, 180);
			recipe13ac.AddTile(TileID.Autohammer);
			recipe13ac.Register();
			Recipe recipe13b = Recipe.Create(ItemID.ShroomiteBreastplate);
			recipe13b.AddIngredient(ItemID.ChlorophytePlateMail);
			recipe13b.AddIngredient(ItemID.GlowingMushroom, 360);
			recipe13b.AddTile(TileID.Autohammer);
			recipe13b.Register();
			Recipe recipe13c = Recipe.Create(ItemID.ShroomiteLeggings);
			recipe13c.AddIngredient(ItemID.ChlorophyteGreaves);
			recipe13c.AddIngredient(ItemID.GlowingMushroom, 270);
			recipe13c.AddTile(TileID.Autohammer);
			recipe13c.Register();
			Recipe recipe14aa = Recipe.Create(ItemID.SpectreMask);
			recipe14aa.AddIngredient(ItemID.ChlorophyteHeadgear);
			recipe14aa.AddIngredient(ItemID.Ectoplasm, 6);
			recipe14aa.AddTile(TileID.AdamantiteForge);
			recipe14aa.Register();
			Recipe recipe14ab = Recipe.Create(ItemID.SpectreHood);
			recipe14ab.AddIngredient(ItemID.ChlorophyteHeadgear);
			recipe14ab.AddIngredient(ItemID.Ectoplasm, 6);
			recipe14ab.AddTile(TileID.AdamantiteForge);
			recipe14ab.Register();
			Recipe recipe14b = Recipe.Create(ItemID.SpectreRobe);
			recipe14b.AddIngredient(ItemID.ChlorophytePlateMail);
			recipe14b.AddIngredient(ItemID.Ectoplasm, 12);
			recipe14b.AddTile(TileID.AdamantiteForge);
			recipe14b.Register();
			Recipe recipe14c = Recipe.Create(ItemID.SpectrePants);
			recipe14c.AddIngredient(ItemID.ChlorophyteGreaves);
			recipe14c.AddIngredient(ItemID.Ectoplasm, 9);
			recipe14c.AddTile(TileID.AdamantiteForge);
			recipe14c.Register();
        }
	}
}