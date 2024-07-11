using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TLR.Content.Brawl.Rarities
{
	public class Gadget : ModRarity
	{
		public override Color RarityColor => Color.Green;

		public override int GetPrefixedRarity(int offset, float valueMult) {
			return Type;
		}
	}
    public class Gear : ModRarity
	{
		public override Color RarityColor => Color.SkyBlue;

		public override int GetPrefixedRarity(int offset, float valueMult) {
			return Type;
		}
	}
    public class StarPower : ModRarity
	{
		public override Color RarityColor => Color.Yellow;

		public override int GetPrefixedRarity(int offset, float valueMult) {
			return Type;
		}
	}
    public class Hypercharge : ModRarity
	{
		public override Color RarityColor => Color.Purple;

		public override int GetPrefixedRarity(int offset, float valueMult) {
			return Type;
		}
	}
    public class GearEpic : ModRarity
	{
		public override Color RarityColor => Color.MediumPurple;

		public override int GetPrefixedRarity(int offset, float valueMult) {
			return Type;
		}
	}
    public class GearMythic : ModRarity
	{
		public override Color RarityColor => Color.HotPink;

		public override int GetPrefixedRarity(int offset, float valueMult) {
			return Type;
		}
	}
}