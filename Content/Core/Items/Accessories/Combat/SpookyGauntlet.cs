using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TLR.Content.Core.Items.Accessories.Combat
{ 
	// This is a basic item template.
	// Please see tModLoader's ExampleMod for every other example:
	// https://github.com/tModLoader/tModLoader/tree/stable/ExampleMod
	public class SpookyGauntlet : ModItem
	{
        // The Display Name and Tooltip of this item can be edited in the 'Localization/en-US_Mods.TLR.hjson' file.
        public override void SetDefaults()
		{
			Item.width = 22;
			Item.height = 28;
			Item.value = Item.sellPrice(gold: 50);
			Item.rare = ItemRarityID.Red;
			Item.accessory = true;
			Item.ResearchUnlockCount = 1;
			Item.maxStack = 1;
            Item.defense = 16;
		}
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.aggro += 400;
            player.magmaStone = true;
			player.GetDamage(DamageClass.Melee) += 0.2f;
			player.GetAttackSpeed(DamageClass.Melee) += 0.2f;
			player.autoReuseGlove = true;
            player.kbGlove = true;
            player.yoyoGlove = true;
            player.counterWeight = 556 + Main.rand.Next(6);
            player.GetModPlayer<TLRPlayer>().spookyGlove = true; // Saps enemies of their life force, recovering HP with melee attacks
            player.GetDamage(DamageClass.Summon) += 0.25f;
            player.maxMinions += 2;
            player.maxTurrets += 2;
            player.GetKnockback(DamageClass.Summon) += 2f;
        }

        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ModContent.ItemType<Melee.HallowedGauntlet>());
			recipe.AddIngredient(ModContent.ItemType<Summon.SpookyStory>());
            recipe.AddIngredient(ItemID.SpookyWood, 500);
			recipe.AddIngredient(ItemID.FragmentSolar, 12);
			recipe.AddIngredient(ItemID.FragmentStardust, 12);
            recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.Register();
		}
	}
}
