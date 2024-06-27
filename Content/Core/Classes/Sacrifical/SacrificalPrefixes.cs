using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace TLR.Content.Core.Classes.Sacrifical
{
	// This class serves as an example for declaring item 'prefixes', or 'modifiers' in other words.
	public class Flowing : ModPrefix
	{
		public override PrefixCategory Category => PrefixCategory.Accessory;
		public override float RollChance(Item item) => 0.75f;
		public override bool CanRoll(Item item) => true;
		public override void ModifyValue(ref float valueMult) { valueMult *= 1.75f; }
        public override void ApplyAccessoryEffects(Player player) { player.statLifeMax2 += 5; }
        public override IEnumerable<TooltipLine> GetTooltipLines(Item item) {
			yield return new TooltipLine(Mod, "PrefixAccHealth", "+5 max life") {
				IsModifier = true, // Sets the color to the positive modifier color.
			};
		}
    }
	public class Overflowing : ModPrefix
	{
		public override PrefixCategory Category => PrefixCategory.Accessory;
		public override float RollChance(Item item) => 0.50f;
		public override bool CanRoll(Item item) => true;
		public override void ModifyValue(ref float valueMult) { valueMult *= 3.5f; }
        public override void ApplyAccessoryEffects(Player player) { player.statLifeMax2 += 5; }
		public override IEnumerable<TooltipLine> GetTooltipLines(Item item) {
			yield return new TooltipLine(Mod, "PrefixAccHealth", "+10 max life") {
				IsModifier = true, // Sets the color to the positive modifier color.
			};
		}
    }
	public class Sacrifical : ModPrefix
	{
		public override PrefixCategory Category => PrefixCategory.AnyWeapon;
		public override float RollChance(Item item) => 0.10f;
		public override bool CanRoll(Item item) => true;
		public override void ModifyValue(ref float valueMult) { valueMult *= 5f; }
		public override void Apply(Item item){ item.GetGlobalItem<TLRItem>().healthCostMultiplier -= 0.15f; }
		public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus) {
			damageMult *= 1.16f; knockbackMult *= 1.15f; useTimeMult *= 1.10f; critBonus += 5;
		}
		public override IEnumerable<TooltipLine> GetTooltipLines(Item item) {
			yield return new TooltipLine(Mod, "PrefixWeaponLife", "-15 life cost") {
				IsModifier = true, // Sets the color to the positive modifier color.
				IsModifierBad = true,
			};
		}
    }
	public class Cataclystic : ModPrefix
	{
		public override PrefixCategory Category => PrefixCategory.AnyWeapon;
		public override float RollChance(Item item) => 0.85f;
		public override bool CanRoll(Item item) => true;
		public override void ModifyValue(ref float valueMult) { valueMult *= 1.25f; }
		public override void Apply(Item item){ item.GetGlobalItem<TLRItem>().healthCostMultiplier += 0.75f; }
		public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus) {
			damageMult *= 1.5f; knockbackMult *= 1.12f;
		}
		public override IEnumerable<TooltipLine> GetTooltipLines(Item item) {
			yield return new TooltipLine(Mod, "PrefixWeaponLife", "+75% life cost") {
				IsModifier = true, // Sets the color to the positive modifier color.
				IsModifierBad = true,
			};
		}
    }
}