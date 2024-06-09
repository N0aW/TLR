using System.Runtime.CompilerServices;
using Terraria;
using Terraria.ID;
using Terraria.IO;
using Terraria.ModLoader;

namespace TLR.Content.Core.Items.Accessories.Movement
{ 
	// This is a basic item template.
	// Please see tModLoader's ExampleMod for every other example:
	// https://github.com/tModLoader/tModLoader/tree/stable/ExampleMod
	[AutoloadEquip(EquipType.Shoes)]
	public class AvatarBoots : ModItem
	{
		// The Display Name and Tooltip of this item can be edited in the 'Localization/en-US_Mods.TLR.hjson' file.
		public override void SetDefaults()
		{
			Item.width = 34;
			Item.height = 32;
			Item.value = Item.sellPrice(gold: 25);
			Item.rare = ItemRarityID.Yellow;
			Item.accessory = true;
			Item.ResearchUnlockCount = 1;
			Item.maxStack = 1;
		}
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			// Any Master
			player.moveSpeed += 0.12f;
			player.hasLuck_LuckyHorseshoe = true;
			// Ground Master
            player.accRunSpeed = 7f;
			player.iceSkate = true;
			player.noFallDmg = true;
			player.frogLegJumpBoost = true;
			player.autoJump = true;
			// Fire Master
			player.lavaMax += 600;
			player.fireWalk = true;
			player.lavaRose = true;
			// Water Master
			player.waterWalk = true;
			player.accFlipper = true;
			// Air Master
			player.rocketBoots = ArmorIDs.RocketBoots.TerrasparkBoots;
            player.vanityRocketBoots = ArmorIDs.RocketBoots.TerrasparkBoots;
			player.slowFall = true;
        }

        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.TerrasparkBoots);
			recipe.AddIngredient(ItemID.FrogFlipper);
            recipe.AddIngredient(ItemID.LuckyHorseshoe);
			recipe.AddIngredient(ItemID.Feather, 10);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.Register();
		}
	}
}
