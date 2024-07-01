using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Achievements;
using Terraria.ID;
using Terraria.ModLoader;
using TLR.Content.Core.Classes.Cookie;

namespace TLR.Content.Core.Items.Weapons.Cookie.Ranged
{ 
	// This is a basic item template.
	// Please see tModLoader's ExampleMod for every other example:
	// https://github.com/tModLoader/tModLoader/tree/stable/ExampleMod
	public class CookieCannon : ModItem
	{
        // The Display Name and Tooltip of this item can be edited in the 'Localization/en-US_Mods.TLR.hjson' file.
		public int cookieCost = 1;
		public int cookieBaking = 1;
		public float cookieConsumptionChance = 1f;
        public override void SetDefaults()
		{
			Item.width = 32; Item.height = 22;
			Item.value = Item.sellPrice(0, 0, 30, 0); Item.rare = ItemRarityID.Blue;
			Item.ResearchUnlockCount = 1; Item.maxStack = 1;
			Item.DamageType = ModContent.GetInstance<CookieRanged>();
			Item.damage = 14; Item.crit = 0; Item.knockBack = 1f;
			Item.useTime = 19; Item.useAnimation = 19; Item.autoReuse = true;
			Item.useStyle = ItemUseStyleID.Shoot; Item.UseSound = SoundID.Item11;
			Item.accessory = true;
			Item.shoot = ModContent.ProjectileType<Projectiles.Cookie.Ranged.Cookie>(); Item.shootSpeed = 11f;
		}
        public override void UpdateInventory(Player player)
        {
            player.GetModPlayer<TLRPlayer>().displayCookies = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetModPlayer<TLRPlayer>().displayCookies = true;
			player.GetModPlayer<TLRPlayer>().cookieBaking += cookieBaking;
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.SnowballCannon);
			recipe.AddIngredient(ItemID.GlassKiln);
			recipe.AddIngredient(ItemID.IllegalGunParts);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
        }
        public override bool CanUseItem(Player player)
        {
			TLRPlayer tlrPlayer = player.GetModPlayer<TLRPlayer>();
			tlrPlayer.cookies[0] -= cookieCost;
			if (tlrPlayer.cookies[0] < 0 && tlrPlayer.cookies[1] > 0) {
                tlrPlayer.cookies[1] -= 1;
                tlrPlayer.cookies[0] += 1000;
            }
            if (tlrPlayer.cookies[1] < 0 && tlrPlayer.cookies[2] > 0) {
                tlrPlayer.cookies[2] -= 1;
                tlrPlayer.cookies[1] += 1000;
            }
            if (tlrPlayer.cookies[2] < 0 && tlrPlayer.cookies[3] > 0) {
                tlrPlayer.cookies[3] -= 1;
                tlrPlayer.cookies[2] += 1000;
            }
            if (tlrPlayer.cookies[3] < 0 && tlrPlayer.cookies[4] > 0) {
                tlrPlayer.cookies[4] -= 1;
                tlrPlayer.cookies[3] += 1000;
            }
            if (tlrPlayer.cookies[4] < 0 && tlrPlayer.cookies[5] > 0) {
                tlrPlayer.cookies[5] -= 1;
                tlrPlayer.cookies[4] += 1000;
            }
            if (tlrPlayer.cookies[5] < 0 && tlrPlayer.cookies[6] > 0) {
                tlrPlayer.cookies[6] -= 1;
                tlrPlayer.cookies[5] += 1000;
            }
			if (tlrPlayer.cookies[0] < 0) {
				tlrPlayer.cookies[0] += cookieCost;
				return false;
			}
			return true;
        }
    }
}
