using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TLR.Content.Core.Items.Accessories
{ 
	// This is a basic item template.
	// Please see tModLoader's ExampleMod for every other example:
	// https://github.com/tModLoader/tModLoader/tree/stable/ExampleMod
	public class Manamaster : ModItem
	{
		// The Display Name and Tooltip of this item can be edited in the 'Localization/en-US_Mods.TLR.hjson' file.
		public override void SetDefaults()
		{
			Item.width = 40;
			Item.height = 40;
			Item.value = Item.sellPrice(gold: 20);
			Item.rare = ItemRarityID.Lime;
			Item.accessory = true;
			Item.ResearchUnlockCount = 1;
			Item.maxStack = 1;
		}
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.manaFlower = true;
            player.manaCost -= 0.12f;
            player.aggro -= 400;
            player.GetDamage(DamageClass.Magic) += 15f / 100f;
            player.magicCuffs = true;
            player.manaMagnet = true;
            player.starCloakItem = Item;
            player.starCloakItem_manaCloakOverrideItem = Item;
        }

        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.ArcaneFlower);
			recipe.AddIngredient(ItemID.StarCloak);
			recipe.AddIngredient(ItemID.MagicCuffs);
            recipe.AddIngredient(ItemID.CelestialEmblem);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.Register();
            Recipe recipe2 = CreateRecipe();
			recipe2.AddIngredient(ItemID.ManaCloak);
			recipe2.AddIngredient(ItemID.PutridScent);
			recipe2.AddIngredient(ItemID.MagicCuffs);
            recipe2.AddIngredient(ItemID.CelestialEmblem);
			recipe2.AddTile(TileID.TinkerersWorkbench);
			recipe2.Register();
            Recipe recipe3 = CreateRecipe();
			recipe3.AddIngredient(ItemID.ManaCloak);
			recipe3.AddIngredient(ItemID.PutridScent);
			recipe3.AddIngredient(ItemID.CelestialCuffs);
            recipe3.AddIngredient(ItemID.AvengerEmblem);
			recipe3.AddTile(TileID.TinkerersWorkbench);
			recipe3.Register();
			Recipe recipe4 = CreateRecipe();
			recipe4.AddIngredient(ItemID.MagnetFlower);
			recipe4.AddIngredient(ItemID.StarCloak);
			recipe4.AddIngredient(ItemID.PutridScent);
			recipe4.AddIngredient(ItemID.MagicCuffs);
			recipe4.AddIngredient(ItemID.AvengerEmblem);
			recipe4.AddTile(TileID.TinkerersWorkbench);
			recipe4.Register();
		}
	}
}
