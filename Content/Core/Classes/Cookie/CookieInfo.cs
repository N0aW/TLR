using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace TLR.Content.Core.Classes.Cookie
{
	public class CookieInfo : InfoDisplay
	{
		public override bool Active() {
			return Main.LocalPlayer.GetModPlayer<TLRPlayer>().displayCookies;
		}
		public override string DisplayValue(ref Color displayColor, ref Color displayShadowColor) {
            Player player = Main.LocalPlayer;
			TLRPlayer tLRPlayer = player.GetModPlayer<TLRPlayer>();
            string cookieTotal;
            int cookieBakeSec = tLRPlayer.cookieBaking;
            if (tLRPlayer.cookies[6] != 0) { cookieTotal = tLRPlayer.cookies[6] + "." + tLRPlayer.cookies[5] + "Qi";}
			else if (tLRPlayer.cookies[5] != 0) { cookieTotal = tLRPlayer.cookies[5] + "." + tLRPlayer.cookies[4] + "Qa";}
            else if (tLRPlayer.cookies[4] != 0) { cookieTotal = tLRPlayer.cookies[4] + "." + tLRPlayer.cookies[3] + "T";}
            else if (tLRPlayer.cookies[3] != 0) { cookieTotal = tLRPlayer.cookies[3] + "." + tLRPlayer.cookies[2] + "B";}
            else if (tLRPlayer.cookies[2] != 0) { cookieTotal = tLRPlayer.cookies[2] + "." + tLRPlayer.cookies[1] + "M";}
            else if (tLRPlayer.cookies[1] != 0) { cookieTotal = tLRPlayer.cookies[1] + "." + tLRPlayer.cookies[0] + "K";}
            else { cookieTotal = tLRPlayer.cookies[0] + "";}
			return $"{cookieTotal} cookies | +{cookieBakeSec}/s";
		}
	}

}