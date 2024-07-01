using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Achievements;
using Terraria.ID;
using Terraria.ModLoader;
using TLR.Content.Core.Classes.Cookie;

namespace TLR.Content.Core.Items.Consumables.Cookie
{ 
	// This is a basic item template.
	// Please see tModLoader's ExampleMod for every other example:
	// https://github.com/tModLoader/tModLoader/tree/stable/ExampleMod
	public class ResetCookie : ModItem
	{
        // The Display Name and Tooltip of this item can be edited in the 'Localization/en-US_Mods.TLR.hjson' file.
        public override void SetDefaults()
		{
            Item.useStyle = ItemUseStyleID.Shoot;
			Item.width = 30; Item.height = 28;
			Item.value = Item.sellPrice(0, 0, 0, 0); Item.rare = ItemRarityID.Gray;
			Item.ResearchUnlockCount = 99; Item.maxStack = 9999;
            Item.consumable = true; Item.color = Color.Red;
            Item.damage = 1; Item.DamageType = ModContent.GetInstance<CookieRanged>();
            Item.crit = 0; Item.useTime = 1; Item.useAnimation = 1;
            Item.shoot = ModContent.ProjectileType<Projectiles.Cookie.Ranged.Cookie>();
            Item.shootSpeed = 11f;
		}
        public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
        {
            player.GetModPlayer<TLRPlayer>().cookies = [0, 0, 0, 0, 0, 0, 0];
            player.GetModPlayer<TLRPlayer>().style = 0;
        }
    }
}
