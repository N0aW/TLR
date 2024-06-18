using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TLR.Content.Core.Items.Accessories.Combat.Summon
{ 
	// This is a basic item template.
	// Please see tModLoader's ExampleMod for every other example:
	// https://github.com/tModLoader/tModLoader/tree/stable/ExampleMod
	public class SpookyStory : ModItem
	{
		// The Display Name and Tooltip of this item can be edited in the 'Localization/en-US_Mods.TLR.hjson' file.
		public override void SetDefaults()
		{
			Item.width = 36;
			Item.height = 36;
			Item.value = Item.sellPrice(gold: 15);
			Item.rare = ItemRarityID.Cyan;
			Item.accessory = true;
			Item.ResearchUnlockCount = 1;
			Item.maxStack = 1;
		}
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetDamage(DamageClass.Summon) += 20f / 100f;
            player.maxMinions += 2;
            player.maxTurrets += 1;
            player.GetKnockback(DamageClass.Summon) += 2f;
			player.AddBuff(BuffID.Bewitched, 1);
			player.AddBuff(BuffID.WarTable, 1);
        }

        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.PapyrusScarab);
			recipe.AddIngredient(ItemID.PygmyNecklace);
			recipe.AddRecipeGroup("TLR:T2DD2Accessory", 1);
            recipe.AddIngredient(ItemID.AvengerEmblem);
			recipe.AddIngredient(ItemID.BewitchingTable);
			recipe.AddIngredient(ItemID.WarTable);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.Register();
		}
	}
}
