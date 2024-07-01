using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace TLR.Content.Core.Classes.Cookie
{
	// This class serves as an example for declaring item 'prefixes', or 'modifiers' in other words.
	public class Lovely : ModPrefix
	{
		public override PrefixCategory Category => PrefixCategory.Accessory;
		public override float RollChance(Item item) => 0.75f;
		public override bool CanRoll(Item item) => true;
		public override void ModifyValue(ref float valueMult) { valueMult *= 1.25f; }
        public override void ApplyAccessoryEffects(Player player) { player.GetModPlayer<TLRPlayer>().supportHealMult += 0.05f; }
        public override IEnumerable<TooltipLine> GetTooltipLines(Item item) {
			yield return new TooltipLine(Mod, "PrefixAccHealth", "+5% support abilities") {
				IsModifier = true, // Sets the color to the positive modifier color.
			};
		}
    }
	public class Comforting : ModPrefix
	{
		public override PrefixCategory Category => PrefixCategory.Accessory;
		public override float RollChance(Item item) => 0.50f;
		public override bool CanRoll(Item item) => true;
		public override void ModifyValue(ref float valueMult) { valueMult *= 1.5f; }
        public override void ApplyAccessoryEffects(Player player) { player.GetModPlayer<TLRPlayer>().supportHealMult += 0.10f; }
		public override IEnumerable<TooltipLine> GetTooltipLines(Item item) {
			yield return new TooltipLine(Mod, "PrefixAccHealth", "+10% support abilities") {
				IsModifier = true, // Sets the color to the positive modifier color.
			};
		}
    }
}