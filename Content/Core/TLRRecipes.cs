using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace TLR.Content.Core
{
	// This class contains thoughtful examples of item recipe creation.
	// Recipes are explained in detail on the https://github.com/tModLoader/tModLoader/wiki/Basic-Recipes and https://github.com/tModLoader/tModLoader/wiki/Intermediate-Recipes wiki pages. Please visit the wiki to learn more about recipes if anything is unclear.
	public class TLRRecipes : ModSystem
	{
		// A place to store the recipe group so we can easily use it later
		public static RecipeGroup ExampleRecipeGroup;

		public override void Unload() {
			ExampleRecipeGroup = null;
		}

		public override void AddRecipeGroups() {
		}

		public override void AddRecipes() {
			////////////////////////////////////////////////////////////////////////////////////
			// The following basic recipe makes 999 ExampleItems out of 1 stone block. //
			////////////////////////////////////////////////////////////////////////////////////

			Recipe recipe = Recipe.Create(ItemID.BoneWelder);
			recipe.AddIngredient(ItemID.Bone, 100);
			recipe.AddTile(TileID.DemonAltar);
			recipe.Register();
			Recipe recipe2 = Recipe.Create(ItemID.IceMachine);
			recipe2.AddIngredient(ItemID.IceBlock, 100);
			recipe2.AddIngredient(ItemID.SnowBlock, 100);
			recipe2.AddTile(TileID.TinkerersWorkbench);
			recipe2.Register();
			Recipe recipe3 = Recipe.Create(ItemID.MeatGrinder);
			recipe3.AddIngredient(ItemID.RottenChunk, 8);
			recipe3.AddIngredient(ItemID.SoulofNight, 3);
			recipe3.AddIngredient(ItemID.DarkShard, 1);
			recipe3.AddTile(TileID.MythrilAnvil);
			recipe3.Register();
			Recipe recipe4 = Recipe.Create(ItemID.HoneyDispenser);
			recipe4.AddIngredient(ItemID.HoneyBlock, 50);
			recipe4.AddIngredient(ItemID.HoneyBucket, 5);
			recipe4.AddIngredient(ItemID.BeeWax, 4);
			recipe4.AddTile(TileID.WorkBenches);
			recipe4.AddCondition(Condition.NearHoney);
			recipe4.Register();
			Recipe recipe5 = Recipe.Create(ItemID.SkyMill);
			recipe5.AddIngredient(ItemID.SunplateBlock, 30);
			recipe5.AddIngredient(ItemID.Cloud, 20);
			recipe5.AddTile(TileID.Anvils);
			recipe5.Register();
			Recipe recipe6 = Recipe.Create(ItemID.LivingLoom);
			recipe6.AddIngredient(ItemID.Wood, 50);
			recipe6.AddIngredient(ItemID.Vine, 3);
			recipe6.AddIngredient(ItemID.JungleSpores, 8);
			recipe6.AddTile(TileID.WorkBenches);
			recipe6.AddCondition(Condition.InJungle);
			recipe6.Register();
        }
	}
}