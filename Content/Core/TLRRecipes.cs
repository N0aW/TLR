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
			recipe3.AddIngredient(ItemID.RottenChunk, 20);
			recipe3.AddIngredient(ItemID.SoulofNight, 15);
			recipe3.AddIngredient(ItemID.DarkShard, 2);
			recipe3.AddTile(TileID.MythrilAnvil);
			recipe3.Register();
			Recipe recipe3b = Recipe.Create(ItemID.MeatGrinder);
			recipe3b.AddIngredient(ItemID.Vertebrae, 20);
			recipe3b.AddIngredient(ItemID.SoulofNight, 15);
			recipe3b.AddIngredient(ItemID.DarkShard, 2);
			recipe3b.AddTile(TileID.MythrilAnvil);
			recipe3b.Register();
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
			Recipe recipe7 = Recipe.Create(ItemID.BrickLayer);
			recipe7.AddIngredient(ItemID.AncientChisel);
			recipe7.AddIngredient(ItemID.ClayBlock, 30);
			recipe7.AddIngredient(ItemID.RedBrick, 10);
			recipe7.AddTile(TileID.Anvils);
			recipe7.Register();
			Recipe recipe8 = Recipe.Create(ItemID.PortableCementMixer);
			recipe8.AddIngredient(ItemID.EmptyBucket, 2);
			recipe8.AddIngredient(ItemID.Chain, 5);
			recipe8.AddIngredient(ItemID.ClayBlock, 15);
			recipe8.AddTile(TileID.Anvils);
			recipe8.Register();
			Recipe recipe9 = Recipe.Create(ItemID.PaintSprayer);
			recipe9.AddIngredient(ItemID.Minishark);
			recipe9.AddIngredient(ItemID.CyanPaint, 10);
			recipe9.AddTile(TileID.Anvils);
			recipe9.Register();
			Recipe recipe10 = Recipe.Create(ItemID.ExtendoGrip);
			recipe10.AddIngredient(ItemID.Wrench);
			recipe10.AddIngredient(RecipeGroupID.IronBar, 10);
			recipe10.AddTile(TileID.Anvils);
			recipe10.Register();
			Recipe recipe11 = Recipe.Create(ItemID.ActuationAccessory);
			recipe11.AddIngredient(ItemID.ActuationRod);
			recipe11.AddIngredient(ItemID.Actuator, 30);
			recipe11.AddIngredient(ItemID.Wire, 25);
			recipe11.AddTile(TileID.Anvils);
			recipe11.Register();
			Recipe recipe12a = Recipe.Create(ItemID.TurtleHelmet);
			recipe12a.AddIngredient(ItemID.ChlorophyteMask);
			recipe12a.AddIngredient(ItemID.TurtleShell, 1);
			recipe12a.AddTile(TileID.MythrilAnvil);
			recipe12a.Register();
			Recipe recipe12b = Recipe.Create(ItemID.TurtleScaleMail);
			recipe12b.AddIngredient(ItemID.ChlorophytePlateMail);
			recipe12b.AddIngredient(ItemID.TurtleShell, 1);
			recipe12b.AddTile(TileID.MythrilAnvil);
			recipe12b.Register();
			Recipe recipe12c = Recipe.Create(ItemID.TurtleLeggings);
			recipe12c.AddIngredient(ItemID.ChlorophyteGreaves);
			recipe12c.AddIngredient(ItemID.TurtleShell, 1);
			recipe12c.AddTile(TileID.MythrilAnvil);
			recipe12c.Register();
			Recipe recipe13aa = Recipe.Create(ItemID.ShroomiteHeadgear);
			recipe13aa.AddIngredient(ItemID.ChlorophyteHelmet);
			recipe13aa.AddIngredient(ItemID.GlowingMushroom, 180);
			recipe13aa.AddTile(TileID.Autohammer);
			recipe13aa.Register();
			Recipe recipe13ab = Recipe.Create(ItemID.ShroomiteHelmet);
			recipe13ab.AddIngredient(ItemID.ChlorophyteHelmet);
			recipe13ab.AddIngredient(ItemID.GlowingMushroom, 180);
			recipe13ab.AddTile(TileID.Autohammer);
			recipe13ab.Register();
			Recipe recipe13ac = Recipe.Create(ItemID.ShroomiteMask);
			recipe13ac.AddIngredient(ItemID.ChlorophyteHelmet);
			recipe13ac.AddIngredient(ItemID.GlowingMushroom, 180);
			recipe13ac.AddTile(TileID.Autohammer);
			recipe13ac.Register();
			Recipe recipe13b = Recipe.Create(ItemID.ShroomiteBreastplate);
			recipe13b.AddIngredient(ItemID.ChlorophytePlateMail);
			recipe13b.AddIngredient(ItemID.GlowingMushroom, 360);
			recipe13b.AddTile(TileID.Autohammer);
			recipe13b.Register();
			Recipe recipe13c = Recipe.Create(ItemID.TurtleLeggings);
			recipe13c.AddIngredient(ItemID.ChlorophyteGreaves);
			recipe13c.AddIngredient(ItemID.GlowingMushroom, 270);
			recipe13c.AddTile(TileID.Autohammer);
			recipe13c.Register();
			Recipe recipe14aa = Recipe.Create(ItemID.SpectreMask);
			recipe14aa.AddIngredient(ItemID.ChlorophyteHeadgear);
			recipe14aa.AddIngredient(ItemID.Ectoplasm, 6);
			recipe14aa.AddTile(TileID.AdamantiteForge);
			recipe14aa.Register();
			Recipe recipe14ab = Recipe.Create(ItemID.SpectreHood);
			recipe14ab.AddIngredient(ItemID.ChlorophyteHeadgear);
			recipe14ab.AddIngredient(ItemID.Ectoplasm, 6);
			recipe14ab.AddTile(TileID.AdamantiteForge);
			recipe14ab.Register();
			Recipe recipe14b = Recipe.Create(ItemID.SpectreRobe);
			recipe14b.AddIngredient(ItemID.ChlorophytePlateMail);
			recipe14b.AddIngredient(ItemID.Ectoplasm, 12);
			recipe14b.AddTile(TileID.AdamantiteForge);
			recipe14b.Register();
			Recipe recipe14c = Recipe.Create(ItemID.SpectrePants);
			recipe14c.AddIngredient(ItemID.ChlorophyteGreaves);
			recipe14c.AddIngredient(ItemID.Ectoplasm, 9);
			recipe14c.AddTile(TileID.AdamantiteForge);
			recipe14c.Register();
        }
	}
}