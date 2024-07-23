using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TLR.Content.Core.Items.Accessories.Combat.Summon
{ 
	public class SpookyStory : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 36;
			Item.height = 36;
			Item.value = Item.sellPrice(gold: 15);
			Item.rare = ItemRarityID.Yellow;
			Item.accessory = true;
			Item.ResearchUnlockCount = 1;
			Item.maxStack = 1;
		}
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetDamage(DamageClass.Summon) += 20f / 100f;
            player.maxMinions += 2;
            player.maxTurrets += 2;
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
