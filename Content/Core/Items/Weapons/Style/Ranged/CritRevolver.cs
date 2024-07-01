using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Achievements;
using Terraria.ID;
using Terraria.ModLoader;
using TLR.Content.Core.Classes.Style;

namespace TLR.Content.Core.Items.Weapons.Style.Ranged
{ 
	// This is a basic item template.
	// Please see tModLoader's ExampleMod for every other example:
	// https://github.com/tModLoader/tModLoader/tree/stable/ExampleMod
	public class CritRevolver : ModItem
	{
        // The Display Name and Tooltip of this item can be edited in the 'Localization/en-US_Mods.TLR.hjson' file.
        public override void SetDefaults()
		{
			Item.width = 32; Item.height = 22;
			Item.value = Item.sellPrice(0, 0, 30, 0); Item.rare = ItemRarityID.Orange;
			Item.ResearchUnlockCount = 1; Item.maxStack = 1;
			Item.DamageType = ModContent.GetInstance<StyleRanged>();
			Item.damage = 14; Item.crit = 8; Item.knockBack = 4f;
			Item.useTime = 16; Item.useAnimation = 16; Item.autoReuse = false;
			Item.useStyle = ItemUseStyleID.Shoot; Item.UseSound = SoundID.Item11;
			Item.accessory = false; Item.useAmmo = AmmoID.Bullet;
			Item.shoot = ProjectileID.PurificationPowder; Item.shootSpeed = 16f;
            Item.color = Color.Teal; Item.noMelee = true;
		}
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Revolver);
			recipe.AddIngredient(ModContent.ItemType<Accessories.Combat.Style.LuckyClover>());
			recipe.AddIngredient(ItemID.IllegalGunParts);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
        }
        public override void ModifyWeaponCrit(Player player, ref float crit)
        {
            crit += player.GetModPlayer<TLRPlayer>().style / 100;
        }
    }
}
