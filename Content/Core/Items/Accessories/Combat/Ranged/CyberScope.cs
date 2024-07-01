using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TLR.Content.Core.Items.Accessories.Combat.Ranged
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
			if (player.HeldItem.DamageType.CountsAsClass(DamageClass.Ranged)) {
				player.scope = true;
			}
			player.GetDamage(DamageClass.Ranged) += 0.15f;
			player.GetCritChance(DamageClass.Ranged) += 15;
			player.aggro -= 400;
			player.AddBuff(BuffID.AmmoBox, 1);
        }

        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.ReconScope);
			recipe.AddIngredient(ItemID.MoltenQuiver);
			recipe.AddIngredient(ItemID.AmmoBox);
			recipe.AddIngredient(ItemID.SoulofSight, 15);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.Register();
		}
	}
}
