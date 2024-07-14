using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace TLR.Content.Core.Classes
{
	public class SadistGeneric : DamageClass
	{
		public override StatInheritanceData GetModifierInheritance(DamageClass damageClass) => StatInheritanceData.None;

		public override bool GetEffectInheritance(DamageClass damageClass) => false;
		public override bool UseStandardCritCalcs => true;
		public override bool ShowStatTooltipLine(Player player, string lineName) => true;
	}
	public class SadistMelee : DamageClass
	{
		public override StatInheritanceData GetModifierInheritance(DamageClass damageClass) {
			if (damageClass == ModContent.GetInstance<SadistGeneric>() || damageClass == Melee) { return StatInheritanceData.Full; }
			return StatInheritanceData.None;
		}
		public override bool GetEffectInheritance(DamageClass damageClass) {
            if (damageClass == ModContent.GetInstance<SadistGeneric>() || damageClass == Melee) { return true;}
            return false;
        }
		public override bool UseStandardCritCalcs => true;
		public override bool ShowStatTooltipLine(Player player, string lineName) => true;
	}
    public class SadistRanged : DamageClass
	{
		public override StatInheritanceData GetModifierInheritance(DamageClass damageClass) {
			if (damageClass == ModContent.GetInstance<SadistGeneric>() || damageClass == Ranged) { return StatInheritanceData.Full; }
			return StatInheritanceData.None;
		}
		public override bool GetEffectInheritance(DamageClass damageClass) {
            if (damageClass == ModContent.GetInstance<SadistGeneric>() || damageClass == Ranged) { return true;}
            return false;
        }
		public override bool UseStandardCritCalcs => true;
		public override bool ShowStatTooltipLine(Player player, string lineName) => true;
	}
    public class SadistMagic : DamageClass
	{
		public override StatInheritanceData GetModifierInheritance(DamageClass damageClass) {
			if (damageClass == ModContent.GetInstance<SadistGeneric>() || damageClass == Magic) { return StatInheritanceData.Full; }
			return StatInheritanceData.None;
		}
		public override bool GetEffectInheritance(DamageClass damageClass) {
            if (damageClass == ModContent.GetInstance<SadistGeneric>() || damageClass == Magic) { return true;}
            return false;
        }
		public override bool UseStandardCritCalcs => true;
		public override bool ShowStatTooltipLine(Player player, string lineName) => true;
	}
    public class SadistSummon : DamageClass
	{
		public override StatInheritanceData GetModifierInheritance(DamageClass damageClass) {
			if (damageClass == ModContent.GetInstance<SadistGeneric>() || damageClass == Summon) { return StatInheritanceData.Full; }
			return StatInheritanceData.None;
		}
		public override bool GetEffectInheritance(DamageClass damageClass) {
            if (damageClass == ModContent.GetInstance<SadistGeneric>() || damageClass == Summon) { return true;}
            return false;
        }
		public override bool UseStandardCritCalcs => true;
		public override bool ShowStatTooltipLine(Player player, string lineName) => true;
	}
    public class SadistMeleeNoSpeed : DamageClass
	{
		public override StatInheritanceData GetModifierInheritance(DamageClass damageClass) {
			if (damageClass == ModContent.GetInstance<SadistGeneric>() || damageClass == MeleeNoSpeed) { return StatInheritanceData.Full; }
			return StatInheritanceData.None;
		}
		public override bool GetEffectInheritance(DamageClass damageClass) {
            if (damageClass == ModContent.GetInstance<SadistGeneric>() || damageClass == MeleeNoSpeed) { return true;}
            return false;
        }
		public override bool UseStandardCritCalcs => true;
		public override bool ShowStatTooltipLine(Player player, string lineName) => true;
	}
    public class SadistSummonMeleeSpeed : DamageClass
	{
		public override StatInheritanceData GetModifierInheritance(DamageClass damageClass) {
			if (damageClass == ModContent.GetInstance<SadistGeneric>() || damageClass == SummonMeleeSpeed) { return StatInheritanceData.Full; }
			return StatInheritanceData.None;
		}
		public override bool GetEffectInheritance(DamageClass damageClass) {
            if (damageClass == ModContent.GetInstance<SadistGeneric>() || damageClass == SummonMeleeSpeed) { return true;}
            return false;
        }
		public override bool UseStandardCritCalcs => true;
		public override bool ShowStatTooltipLine(Player player, string lineName) => true;
	}
}