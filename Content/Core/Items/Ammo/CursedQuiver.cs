using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using tModPorter;
using Terraria.ModLoader.Config;

namespace TLR.Content.Core.Items.Ammo
{
	public class CursedQuiver : ModItem
	{
        public override bool IsLoadingEnabled(Mod mod)
        {
            return false;
        }
        // Is way too fast and doesn't break when used.
        public override void SetDefaults() {
            Item.damage = 4;
            Item.knockBack = 2;
            Item.DamageType = ModContent.GetInstance<Content.Core.DamageClasses.UnholyRanged>();
            Item.shoot = ModContent.ProjectileType<Content.Core.Projectiles.CursedArrow>();
            Item.shootSpeed = 3f;
            Item.ammo = AmmoID.Arrow;
			Item.width = 32;
			Item.height = 32;
			Item.maxStack = 1;
			Item.consumable = false; // This marks the item as consumable, making it automatically be consumed when it's used as ammunition, or something else, if possible.
			Item.value = Item.sellPrice(gold: 1);
			Item.rare = ItemRarityID.Blue;
            Item.ResearchUnlockCount = 1;
		}

		// Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
		public override void AddRecipes() {
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.WoodenArrow, 3996);
			recipe.AddTile(TileID.DemonAltar);
			recipe.Register();
		}
	}
}