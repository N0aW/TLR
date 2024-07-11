using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TLR.Content.Core.Rarities
{
	public class Unsealed : ModRarity
	{
		public override Color RarityColor => Color.Aquamarine;

		public override int GetPrefixedRarity(int offset, float valueMult) {
			return Type; // no 'higher' tier to go to, so return the type of this rarity.
		}
	}
}