using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TLR.Content.Core.Items.Accessories
{ 
	// This is a basic item template.
	// Please see tModLoader's ExampleMod for every other example:
	// https://github.com/tModLoader/tModLoader/tree/stable/ExampleMod
	public class Exoskeleton : ModItem
	{
		// The Display Name and Tooltip of this item can be edited in the 'Localization/en-US_Mods.TLR.hjson' file.
		public override void SetDefaults()
		{
			Item.width = 32;
			Item.height = 50;
			Item.value = Item.sellPrice(gold: 30);
			Item.rare = ItemRarityID.Lime;
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
			recipe.AddIngredient(ItemID.HorseshoeBundle);
			recipe.AddIngredient(ItemID.ArcticDivingGear);
            recipe.AddIngredient(ItemID.HandOfCreation);
            recipe.AddIngredient(ItemID.ActuationAccessory);
            recipe.AddIngredient(ItemID.LavaproofTackleBag);
            recipe.AddIngredient(ItemID.FishingBobber);
            recipe.AddIngredient(ItemID.UltrabrightHelmet);
            recipe.AddIngredient(ItemID.FrogWebbing);
            recipe.AddIngredient(ItemID.Magiluminescence);
            recipe.AddIngredient(ItemID.WireKite);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.Register();
            Recipe recipe2 = CreateRecipe();
			recipe2.AddIngredient(ItemID.HorseshoeBundle);
			recipe2.AddIngredient(ItemID.ArcticDivingGear);
            recipe2.AddIngredient(ItemID.HandOfCreation);
            recipe2.AddIngredient(ItemID.ActuationAccessory);
            recipe2.AddIngredient(ItemID.LavaproofTackleBag);
            recipe2.AddIngredient(ItemID.FishingBobber);
            recipe2.AddIngredient(ItemID.UltrabrightHelmet);
            recipe2.AddIngredient(ItemID.FrogGear);
            recipe2.AddIngredient(ItemID.Magiluminescence);
            recipe2.AddIngredient(ItemID.WireKite);
			recipe2.AddTile(TileID.TinkerersWorkbench);
			recipe2.Register();
		}
	}
}
