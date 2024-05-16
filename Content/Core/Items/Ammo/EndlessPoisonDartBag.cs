using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using tModPorter;
using Terraria.ModLoader.Config;

namespace TLR.Content.Core.Items.Ammo
{
	public class EndlessPoisonDartBag : ModItem
	{
        public override bool IsLoadingEnabled(Mod mod)
        {
            return false;
        }
        // HITTING ENEMY WITH THESE DARTS KILLS THE PLAYER!!!
        public override void SetDefaults() {
			Item.CloneDefaults(ItemID.PoisonDart);
			Item.width = 40;
			Item.height = 40;
			Item.maxStack = 1;
			Item.consumable = false; // This marks the item as consumable, making it automatically be consumed when it's used as ammunition, or something else, if possible.
			Item.value = Item.sellPrice(silver: 4);
			Item.rare = ItemRarityID.Orange;
            Item.ResearchUnlockCount = 1;
		}

		// Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
		public override void AddRecipes() {
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.PoisonDart, 3996);
			recipe.AddTile(TileID.CrystalBall);
			recipe.Register();
		}
	}
}