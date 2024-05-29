using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TLR.Content.Core.Items.Weapons
{ 
	// This is a basic item template.
	// Please see tModLoader's ExampleMod for every other example:
	// https://github.com/tModLoader/tModLoader/tree/stable/ExampleMod
	public class TerragemBlade : ModItem
	{
		private int randomgem = 0;
		// The Display Name and Tooltip of this item can be edited in the 'Localization/en-US_Mods.TLR.hjson' file.
		public override void SetDefaults()
		{
			Item.damage = 32;
			Item.crit = 6;
			Item.DamageType = DamageClass.Melee;
			Item.useTime = 22;
			Item.useAnimation = 22;
			Item.knockBack = 5;
			Item.autoReuse = true;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.width = 56;
			Item.height = 56;
			Item.value = Item.sellPrice(gold: 10);
			Item.rare = ItemRarityID.LightRed;
			Item.ResearchUnlockCount = 1;
			Item.maxStack = 1;
		}

        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.FieryGreatsword);
			recipe.AddIngredient(ItemID.IceBlade);
			recipe.AddIngredient(ItemID.LargeAmethyst);
			recipe.AddIngredient(ItemID.LargeTopaz);
			recipe.AddIngredient(ItemID.LargeSapphire);
			recipe.AddIngredient(ItemID.LargeEmerald);
			recipe.AddIngredient(ItemID.LargeAmber);
			recipe.AddIngredient(ItemID.LargeRuby);
			recipe.AddIngredient(ItemID.LargeDiamond);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.Register();
		}
        public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
        {
			Random rnd = new();
            randomgem = rnd.Next(1, 7);
			if (randomgem == 1) { // Amethyst
				target.AddBuff(BuffID.Venom, 180, false);
			}
			else if (randomgem == 2) { // Topaz
				target.AddBuff(BuffID.Midas, 180, false);
			}
			else if (randomgem == 3) { // Sapphire
				target.AddBuff(BuffID.Frozen, 180, false);
			}
			else if (randomgem == 4) { // Emerald
				target.AddBuff(BuffID.Cursed, 180, false);
			}
			else if (randomgem == 5) { // Amber
				target.AddBuff(BuffID.Ichor, 180, false);
			}
			else if (randomgem == 6) { // Ruby
				target.AddBuff(BuffID.Weak, 180, false);
				target.AddBuff(BuffID.Bleeding, 180, false);
			}
			else if (randomgem == 7) { // Diamond
				target.AddBuff(BuffID.BrokenArmor, 180, false);
			}
		}
        public override void OnHitPvp(Player player, Player target, Player.HurtInfo hurtInfo)
        {
            Random rnd = new();
            randomgem = rnd.Next(1, 7);
			if (randomgem == 1) { // Amethyst
				target.AddBuff(BuffID.Venom, 180, false);
			}
			else if (randomgem == 2) { // Topaz
				target.AddBuff(BuffID.Midas, 180, false);
			}
			else if (randomgem == 3) { // Sapphire
				target.AddBuff(BuffID.Frozen, 180, false);
			}
			else if (randomgem == 4) { // Emerald
				target.AddBuff(BuffID.Cursed, 180, false);
			}
			else if (randomgem == 5) { // Amber
				target.AddBuff(BuffID.Ichor, 180, false);
			}
			else if (randomgem == 6) { // Ruby
				target.AddBuff(BuffID.Weak, 180, false);
				target.AddBuff(BuffID.Bleeding, 180, false);
			}
			else if (randomgem == 7) { // Diamond
				target.AddBuff(BuffID.BrokenArmor, 180, false);
			}
        }
    }
}
