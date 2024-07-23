using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TLR.Content.Core.Items.Accessories.Combat.Magic
{ 
	public class Manamaster : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 28;
			Item.height = 32;
			Item.value = Item.sellPrice(gold: 15);
			Item.rare = ItemRarityID.Lime;
			Item.accessory = true;
			Item.ResearchUnlockCount = 1;
			Item.maxStack = 1;
		}
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.manaFlower = true;
            player.manaCost -= 0.08f;
            player.aggro -= 400;
			player.statManaMax2 += 40;
            player.GetDamage(DamageClass.Magic) += 0.12f;
            player.magicCuffs = true;
            player.manaMagnet = true;
            player.starCloakItem = Item;
            player.starCloakItem_manaCloakOverrideItem = Item;
			player.AddBuff(BuffID.Clairvoyance, 1);
        }

        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.ArcaneFlower);
			recipe.AddIngredient(ItemID.StarCloak);
			recipe.AddIngredient(ItemID.MagicCuffs);
            recipe.AddIngredient(ItemID.CelestialEmblem);
			recipe.AddIngredient(ItemID.CrystalBall);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.Register();
            Recipe recipe2 = CreateRecipe();
			recipe2.AddIngredient(ItemID.ManaCloak);
			recipe2.AddIngredient(ItemID.PutridScent);
			recipe2.AddIngredient(ItemID.MagicCuffs);
            recipe2.AddIngredient(ItemID.CelestialEmblem);
			recipe2.AddIngredient(ItemID.CrystalBall);
			recipe2.AddTile(TileID.TinkerersWorkbench);
			recipe2.Register();
            Recipe recipe3 = CreateRecipe();
			recipe3.AddIngredient(ItemID.ManaCloak);
			recipe3.AddIngredient(ItemID.PutridScent);
			recipe3.AddIngredient(ItemID.CelestialCuffs);
            recipe3.AddIngredient(ItemID.AvengerEmblem);
			recipe3.AddIngredient(ItemID.CrystalBall);
			recipe3.AddTile(TileID.TinkerersWorkbench);
			recipe3.Register();
			Recipe recipe4 = CreateRecipe();
			recipe4.AddIngredient(ItemID.MagnetFlower);
			recipe4.AddIngredient(ItemID.StarCloak);
			recipe4.AddIngredient(ItemID.PutridScent);
			recipe4.AddIngredient(ItemID.MagicCuffs);
			recipe4.AddIngredient(ItemID.AvengerEmblem);
			recipe4.AddIngredient(ItemID.CrystalBall);
			recipe4.AddTile(TileID.TinkerersWorkbench);
			recipe4.Register();
		}
	}
}
