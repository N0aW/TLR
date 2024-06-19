using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TLR.Content.Core.Rarities
{
	public class GlowingWhite : ModRarity
	{
		public override Color RarityColor => new Color(Main.DiscoR / 2, (byte)(Main.DiscoG / 1.25f), (byte)(Main.DiscoB / 1.5f));

		public override int GetPrefixedRarity(int offset, float valueMult) {
            if (offset > 0) {
				return ModContent.RarityType<Cyber>();
			}

			return Type; // no 'higher' tier to go to, so return the type of this rarity.
		}
	}
    public class Cyber : ModRarity
	{
		public override Color RarityColor => new Color(Main.DiscoR / 2, (byte)(Main.DiscoG / 1.25f), (byte)(Main.DiscoB / 1.5f));

		public override int GetPrefixedRarity(int offset, float valueMult) {
			if (offset < 0) {
				return ModContent.RarityType<GlowingWhite>();
			}

			return Type; // no 'higher' tier to go to, so return the type of this rarity.
		}
	}
	public class Essence : ModRarity
	{
		public override Color RarityColor => new Color(181, 43, 151);

		public override int GetPrefixedRarity(int offset, float valueMult) {
			return Type; // no 'higher' tier to go to, so return the type of this rarity.
		}
	}
}