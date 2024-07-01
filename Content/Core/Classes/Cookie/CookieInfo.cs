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
		private int cookieRound(int toRound) {
			if (toRound >= 900) { return 9; }
			if (toRound >= 800) { return 8; }
			if (toRound >= 700) { return 7; }
			if (toRound >= 600) { return 6; }
			if (toRound >= 500) { return 5; }
			if (toRound >= 400) { return 4; }
			if (toRound >= 300) { return 3; }
			if (toRound >= 200) { return 2; }
			if (toRound >= 100) { return 1; }
			return 0;
		}
		public override string DisplayValue(ref Color displayColor, ref Color displayShadowColor) {
            Player player = Main.LocalPlayer;
			TLRPlayer tLRPlayer = player.GetModPlayer<TLRPlayer>();
			displayColor = Color.SandyBrown;
            string cookieTotal;
            int cookieBakeSec = tLRPlayer.cookieBaking;
            if (tLRPlayer.cookies[6] != 0) { cookieTotal = tLRPlayer.cookies[6] + "." + cookieRound(tLRPlayer.cookies[5]) + "Qi";}
			else if (tLRPlayer.cookies[5] != 0) { cookieTotal = tLRPlayer.cookies[5] + "." + cookieRound(tLRPlayer.cookies[4]) + "Qa";}
            else if (tLRPlayer.cookies[4] != 0) { cookieTotal = tLRPlayer.cookies[4] + "." + cookieRound(tLRPlayer.cookies[3]) + "T";}
            else if (tLRPlayer.cookies[3] != 0) { cookieTotal = tLRPlayer.cookies[3] + "." + cookieRound(tLRPlayer.cookies[2]) + "B";}
            else if (tLRPlayer.cookies[2] != 0) { cookieTotal = tLRPlayer.cookies[2] + "." + cookieRound(tLRPlayer.cookies[1]) + "M";}
            else if (tLRPlayer.cookies[1] != 0) { cookieTotal = tLRPlayer.cookies[1] + "." + cookieRound(tLRPlayer.cookies[0]) + "K";}
            else { cookieTotal = tLRPlayer.cookies[0] + "";}
			return $"{cookieTotal} cookies / +{cookieBakeSec}/s";
		}
	}

}