using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TLR.Content.Core.Items.Accessories.Combat.Melee
{ 
	[AutoloadEquip(EquipType.HandsOn, EquipType.HandsOff)]
	public class HallowedGauntlet : ModItem
	{
        public override void SetDefaults()
		{
			Item.width = 22;
			Item.height = 28;
			Item.value = Item.sellPrice(gold: 15);
			Item.rare = ItemRarityID.Yellow;
			Item.accessory = true;
			Item.ResearchUnlockCount = 1;
			Item.maxStack = 1;
            Item.defense = 10;
		}
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.aggro += 400;
			player.GetDamage(DamageClass.Melee) += 0.12f;
			player.GetAttackSpeed(DamageClass.Melee) += 0.12f;
			player.autoReuseGlove = true;
            player.kbGlove = true;
            player.yoyoGlove = true;
            player.counterWeight = 556 + Main.rand.Next(6);
            player.GetModPlayer<TLRPlayer>().hallowGlove = true;
			player.AddBuff(BuffID.Sharpened, 1);
        }

        public override void AddRecipes()
		{
			if (ModContent.GetInstance<TLRConfigServer>().HallowGauntletPostPlant) {
				CreateRecipe()
					.AddIngredient(ItemID.FireGauntlet)
					.AddIngredient(ItemID.YoyoBag)
					.AddIngredient(ItemID.FleshKnuckles)
					.AddIngredient(ItemID.SharpeningStation)
					.AddIngredient(ItemID.FrozenTurtleShell)
					.AddIngredient(ItemID.BrokenHeroSword)
					.AddTile(TileID.TinkerersWorkbench)
					.AddTile(TileID.MythrilAnvil)
					.Register();
				CreateRecipe()
					.AddIngredient(ItemID.BerserkerGlove)
					.AddIngredient(ItemID.YoyoBag)
					.AddIngredient(ItemID.AvengerEmblem)
					.AddIngredient(ItemID.MagmaStone)
					.AddIngredient(ItemID.SharpeningStation)
					.AddIngredient(ItemID.FrozenTurtleShell)
					.AddIngredient(ItemID.BrokenHeroSword)
					.AddTile(TileID.TinkerersWorkbench)
					.AddTile(TileID.MythrilAnvil)
					.Register();
			}
			else {
				CreateRecipe()
					.AddIngredient(ItemID.FireGauntlet)
					.AddIngredient(ItemID.YoyoBag)
					.AddIngredient(ItemID.FleshKnuckles)
					.AddIngredient(ItemID.SharpeningStation)
					.AddIngredient(ItemID.FrozenTurtleShell)
					.AddTile(TileID.TinkerersWorkbench)
					.AddTile(TileID.MythrilAnvil)
					.Register();
				CreateRecipe()
					.AddIngredient(ItemID.BerserkerGlove)
					.AddIngredient(ItemID.YoyoBag)
					.AddIngredient(ItemID.AvengerEmblem)
					.AddIngredient(ItemID.MagmaStone)
					.AddIngredient(ItemID.SharpeningStation)
					.AddIngredient(ItemID.FrozenTurtleShell)
					.AddTile(TileID.TinkerersWorkbench)
					.AddTile(TileID.MythrilAnvil)
					.Register();
			}
		}
	}
}
