using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TLR.Content.Core.Items.Accessories
{ 
	// This is a basic item template.
	// Please see tModLoader's ExampleMod for every other example:
	// https://github.com/tModLoader/tModLoader/tree/stable/ExampleMod
	public class ExoskeletonMK2 : ModItem
	{
		// The Display Name and Tooltip of this item can be edited in the 'Localization/en-US_Mods.TLR.hjson' file.
		public override void SetDefaults()
		{
			Item.width = 32;
			Item.height = 50;
			Item.value = Item.sellPrice(gold: 50);
			Item.rare = ItemRarityID.Yellow;
			Item.accessory = true;
			Item.ResearchUnlockCount = 1;
			Item.maxStack = 1;
		}
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.jumpBoost = true;
            player.autoJump = true;
            player.accRunSpeed = 6f;
            player.noFallDmg = true;
            player.accFlipper = true;
            player.accFishingLine = true;
            player.accLavaFishing = true;
            player.fishingSkill += 20;
            player.accTackleBox = true;
            player.chiselSpeed = true;
            player.spikedBoots = 2;
            player.iceSkate = true;
            player.frogLegJumpBoost = true;
			player.accDivingHelm = true;
			player.arcticDivingGear = true;
			player.hasLuck_LuckyHorseshoe = true;
            player.equippedAnyTileRangeAcc = true;
            player.equippedAnyWallSpeedAcc = true;
            player.equippedAnyTileSpeedAcc = true;
            player.autoActuator = true;
            player.autoPaint = true;
            player.nightVision = true;
            player.hasMagiluminescence = true;
            player.treasureMagnet = true;
            player.InfoAccMechShowWires = true;
            player.rulerGrid = true;
            player.hasLuck_LuckyCoin = true;
            player.hasLuckyCoin = true;
            player.goldRing = true;
            player.discountEquipped = true;
            player.CanSeeInvisibleBlocks = true;
            player.accMerman = true;
            // following code is for the celestial stone effect. I actually have no idea how to do it otherwise.
            player.GetDamage(DamageClass.Generic) += 10 / 100f;
            player.GetAttackSpeed(DamageClass.Melee) += 10 / 100f;
            player.GetCritChance(DamageClass.Generic) += 2;
            player.lifeRegen += 2 / 120;
            player.statDefense += 4;
            player.pickSpeed -= 15f / 100f;
            player.GetKnockback(DamageClass.Summon) += 0.5f;
            // the code stops here.
            player.wereWolf = true;
            player.shimmerImmune = true;
			if (!player.wet)
			{
				Lighting.AddLight((int)player.Center.X / 16, (int)player.Center.Y / 16, 0.05f, 0.15f, 0.225f);
			}
			if (player.wet)
			{
				Lighting.AddLight((int)player.Center.X / 16, (int)player.Center.Y / 16, 0.4f, 1.2f, 1.8f);
			}
        }

        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ModContent.ItemType<Exoskeleton>());
            recipe.AddIngredient(ItemID.GreedyRing);
            recipe.AddIngredient(ItemID.CelestialShell);
            recipe.AddIngredient(ItemID.SpectreGoggles);
            recipe.AddIngredient(ItemID.ShimmerCloak);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.Register();
		}
	}
}
