using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TLR.Content.Core.Items.Accessories.Combat.Melee
{ 
	// This is a basic item template.
	// Please see tModLoader's ExampleMod for every other example:
	// https://github.com/tModLoader/tModLoader/tree/stable/ExampleMod
	[AutoloadEquip(EquipType.HandsOn, EquipType.HandsOff)]
	public class HallowedGauntlet : ModItem
	{
        // The Display Name and Tooltip of this item can be edited in the 'Localization/en-US_Mods.TLR.hjson' file.
        public override void SetDefaults()
		{
			Item.width = 22;
			Item.height = 28;
			Item.value = Item.sellPrice(gold: 30);
			Item.rare = ItemRarityID.Yellow;
			Item.accessory = true;
			Item.ResearchUnlockCount = 1;
			Item.maxStack = 1;
            Item.defense = 8;
		}
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.aggro += 400;
            player.magmaStone = true;
			player.GetDamage(DamageClass.Melee) += 0.15f;
			player.GetAttackSpeed(DamageClass.Melee) += 0.15f;
			player.autoReuseGlove = true;
            player.kbGlove = true;
            player.yoyoGlove = true;
            player.counterWeight = 556 + Main.rand.Next(6);
            player.GetModPlayer<TLRPlayer>().hallowGlove = true;
			player.AddBuff(BuffID.Sharpened, 1);
        }

        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.FireGauntlet);
			recipe.AddIngredient(ItemID.YoyoBag);
            recipe.AddIngredient(ItemID.FleshKnuckles);
			recipe.AddIngredient(ItemID.SharpeningStation);
			recipe.AddIngredient(ItemID.HallowedBar, 15);
			recipe.AddTile(TileID.MythrilAnvil);
            recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.Register();
			Recipe recipe2 = CreateRecipe();
			recipe2.AddIngredient(ItemID.BerserkerGlove);
			recipe2.AddIngredient(ItemID.AvengerEmblem);
			recipe2.AddIngredient(ItemID.MagmaStone);
			recipe2.AddIngredient(ItemID.YoyoBag);
			recipe2.AddIngredient(ItemID.SharpeningStation);
			recipe2.AddIngredient(ItemID.HallowedBar, 15);
			recipe2.AddTile(TileID.MythrilAnvil);
            recipe2.AddTile(TileID.TinkerersWorkbench);
			recipe2.Register();
		}
	}
}
