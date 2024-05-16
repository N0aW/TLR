using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TLR.Content.Core.Items.Ammo
{
	public class EndlessRocketIBelt : ModItem
	{
		// Seems to work fine.
		// Breaks completely with Celebration MK2
		public override bool IsLoadingEnabled(Mod mod)
        {
            return false;
        }

		public override void SetDefaults() {
			Item.CloneDefaults(ItemID.RocketI);
			Item.width = 40;
			Item.height = 40;
			Item.maxStack = 1;
			Item.consumable = false; // This marks the item as consumable, making it automatically be consumed when it's used as ammunition, or something else, if possible.
			Item.value = Item.sellPrice(gold: 20);
			Item.rare = ItemRarityID.LightRed;
            Item.ResearchUnlockCount = 1;
		}

		// Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
		public override void AddRecipes() {
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.RocketI, 3996);
			recipe.AddTile(TileID.CrystalBall);
			recipe.Register();
		}
	}
}