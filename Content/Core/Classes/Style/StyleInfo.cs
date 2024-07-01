using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace TLR.Content.Core.Classes.Style
{
	public class StyleInfo : InfoDisplay
	{
		public override bool Active() {
			return true;
		}
		public override string DisplayValue(ref Color displayColor, ref Color displayShadowColor) {
            Player player = Main.LocalPlayer;
			TLRPlayer tLRPlayer = player.GetModPlayer<TLRPlayer>();
			if (tLRPlayer.style > 0) { displayColor = Color.Green; }
			else if (tLRPlayer.style < 0) { displayColor = Color.Red; }
			else { displayColor = Color.White; }
			string styled = tLRPlayer.style + "";
			return $"{styled} style";
		}
	}

}