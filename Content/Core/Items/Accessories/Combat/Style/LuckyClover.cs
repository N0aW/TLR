using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TLR.Content.Core.Items.Accessories.Combat.Style
{ 
	// This is a basic item template.
	// Please see tModLoader's ExampleMod for every other example:
	// https://github.com/tModLoader/tModLoader/tree/stable/ExampleMod
	public class LuckyClover : ModItem
	{
		// The Display Name and Tooltip of this item can be edited in the 'Localization/en-US_Mods.TLR.hjson' file.
		public override void SetDefaults()
		{
			Item.width = 32;
			Item.height = 36;
			Item.value = Item.sellPrice(0, 0, 30, 0);
			Item.rare = ItemRarityID.Orange;
			Item.accessory = true;
			Item.ResearchUnlockCount = 1;
			Item.maxStack = 1;
		}
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.luck += 0.05f;
			player.GetModPlayer<TLRPlayer>().styleGain += 0.10f;
			player.GetModPlayer<TLRPlayer>().styleGain += player.luck;
        }

        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.SkyBlueFlower);
			recipe.AddIngredient(ItemID.GreenDye);
			recipe.AddIngredient(ItemID.JungleSpores, 12);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}
