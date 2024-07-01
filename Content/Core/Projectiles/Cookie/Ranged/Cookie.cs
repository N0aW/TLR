using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.Audio;
using Terraria.GameContent;
using Terraria.ID;
using Terraria.ModLoader;
using TLR.Content.Core.Classes.Cookie;

namespace TLR.Content.Core.Projectiles.Cookie.Ranged
{
	public class Cookie : ModProjectile
	{
		public override void SetStaticDefaults() {
			ProjectileID.Sets.TrailCacheLength[Projectile.type] = 5; // The length of old position to be recorded
			ProjectileID.Sets.TrailingMode[Projectile.type] = 0; // The recording mode
		}

		public override void SetDefaults() {
			Projectile.CloneDefaults(ProjectileID.SnowBallFriendly);
			Projectile.DamageType = ModContent.GetInstance<CookieRanged>();; // Is the projectile shoot by a ranged weapon?
			Projectile.light = 0.25f;
			AIType = ProjectileID.SnowBallFriendly; // Act exactly like default Bullet
		}
	}
}