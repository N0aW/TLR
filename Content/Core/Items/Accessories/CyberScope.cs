using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TLR.Content.Core.Items.Accessories
{ 
	// This is a basic item template.
	// Please see tModLoader's ExampleMod for every other example:
	// https://github.com/tModLoader/tModLoader/tree/stable/ExampleMod
	public class CyberScope : ModItem
	{
		// The Display Name and Tooltip of this item can be edited in the 'Localization/en-US_Mods.TLR.hjson' file.
		public override void SetDefaults()
		{
			Item.width = 30;
			Item.height = 30;
			Item.value = Item.sellPrice(gold: 17, silver: 50);
			Item.rare = ItemRarityID.Yellow;
			Item.accessory = true;
			Item.ResearchUnlockCount = 1;
			Item.maxStack = 1;
		}
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.hasMoltenQuiver = true;
			player.magicQuiver = true;
			if (player.HeldItem.DamageType == DamageClass.Ranged) {
				player.scope = true;
			}
			player.GetDamage(DamageClass.Ranged) += 15 / 100f;
			player.GetCritChance(DamageClass.Ranged) += 15;
			player.aggro -= 800;
        }

        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.ReconScope);
			recipe.AddIngredient(ItemID.MoltenQuiver);
			recipe.AddIngredient(ItemID.PutridScent);
			recipe.AddIngredient(ItemID.SoulofSight, 15);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.Register();
			Recipe recipe2 = CreateRecipe();
			recipe2.AddIngredient(ItemID.ReconScope);
			recipe2.AddIngredient(ItemID.MagmaStone);
			recipe2.AddIngredient(ItemID.StalkersQuiver);
			recipe2.AddIngredient(ItemID.SoulofSight, 15);
			recipe2.AddTile(TileID.TinkerersWorkbench);
			recipe2.Register();
			Recipe recipe3 = CreateRecipe();
			recipe3.AddIngredient(ItemID.ReconScope);
			recipe3.AddIngredient(ItemID.MoltenQuiver);
			recipe3.AddIngredient(ItemID.StalkersQuiver);
			recipe3.AddIngredient(ItemID.SoulofSight, 15);
			recipe3.AddTile(TileID.TinkerersWorkbench);
			recipe3.Register();
		}
	}
}
