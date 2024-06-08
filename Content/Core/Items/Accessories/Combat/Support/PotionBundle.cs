using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TLR.Content.Core.Items.Accessories.Combat.Support
{ 
	// This is a basic item template.
	// Please see tModLoader's ExampleMod for every other example:
	// https://github.com/tModLoader/tModLoader/tree/stable/ExampleMod
	public class PotionBundle : ModItem
	{
        // The Display Name and Tooltip of this item can be edited in the 'Localization/en-US_Mods.TLR.hjson' file.
        public override void SetDefaults()
		{
			Item.width = 28;
			Item.height = 20;
			Item.value = Item.sellPrice(gold: 1);
			Item.rare = ItemRarityID.LightRed;
			Item.accessory = true;
			Item.ResearchUnlockCount = 1;
			Item.maxStack = 1;
		}
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			// Healing potions heal 40 HP more
			// Mana potions recover 40 mana more
            // Grants Regeneration, Ironskin and Swiftness to you and allies in a 25 block radius
			// 6% increase to support damage and critical strike chance
            player.GetDamage(ModContent.GetInstance<DamageClasses.Support>()) += 5f / 100f;
			player.GetCritChance(ModContent.GetInstance<DamageClasses.Support>()) += 5;
			ModContent.GetInstance<TLRPlayer>().healPotionAdd += 40;
			ModContent.GetInstance<TLRPlayer>().manaPotionAdd += 40;
			player.AddBuff(BuffID.Regeneration, 1, true, false);
			player.AddBuff(BuffID.Ironskin, 1, true, false);
			player.AddBuff(BuffID.Swiftness, 1, true, false);
        }

        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.HealingPotion, 10);
			recipe.AddIngredient(ItemID.ManaPotion, 10);
			recipe.AddIngredient(ItemID.IronskinPotion, 5);
			recipe.AddIngredient(ItemID.RegenerationPotion, 5);
			recipe.AddIngredient(ItemID.SwiftnessPotion, 5);
			recipe.AddTile(TileID.CrystalBall);
			recipe.Register();
		}
	}
}
