using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace TLR.Content.Core.Classes
{
	public class SadistGeneric : DamageClass
	{
		public override StatInheritanceData GetModifierInheritance(DamageClass damageClass) {
			if (damageClass == Generic) { return StatInheritanceData.Full; }
			return StatInheritanceData.None;
		}

		public override bool GetEffectInheritance(DamageClass damageClass) {
			if (damageClass == Generic) { return true; }
			return false;
		}
		public override bool UseStandardCritCalcs => true;
		public override bool ShowStatTooltipLine(Player player, string lineName) => true;
	}
	public class SadistMelee : DamageClass
	{
		public override StatInheritanceData GetModifierInheritance(DamageClass damageClass) {
			if (damageClass == ModContent.GetInstance<SadistGeneric>() || damageClass == Melee || damageClass == Generic) { return StatInheritanceData.Full; }
			return StatInheritanceData.None;
		}
		public override bool GetEffectInheritance(DamageClass damageClass) {
            if (damageClass == ModContent.GetInstance<SadistGeneric>() || damageClass == Melee || damageClass == Generic) { return true;}
            return false;
        }
		public override bool UseStandardCritCalcs => true;
		public override bool ShowStatTooltipLine(Player player, string lineName) => true;
	}
    public class SadistRanged : DamageClass
	{
		public override StatInheritanceData GetModifierInheritance(DamageClass damageClass) {
			if (damageClass == ModContent.GetInstance<SadistGeneric>() || damageClass == Ranged || damageClass == Generic) { return StatInheritanceData.Full; }
			return StatInheritanceData.None;
		}
		public override bool GetEffectInheritance(DamageClass damageClass) {
            if (damageClass == ModContent.GetInstance<SadistGeneric>() || damageClass == Ranged || damageClass == Generic) { return true;}
            return false;
        }
		public override bool UseStandardCritCalcs => true;
		public override bool ShowStatTooltipLine(Player player, string lineName) => true;
	}
    public class SadistMagic : DamageClass
	{
		public override StatInheritanceData GetModifierInheritance(DamageClass damageClass) {
			if (damageClass == ModContent.GetInstance<SadistGeneric>() || damageClass == Magic || damageClass == Generic) { return StatInheritanceData.Full; }
			return StatInheritanceData.None;
		}
		public override bool GetEffectInheritance(DamageClass damageClass) {
            if (damageClass == ModContent.GetInstance<SadistGeneric>() || damageClass == Magic || damageClass == Generic) { return true;}
            return false;
        }
		public override bool UseStandardCritCalcs => true;
		public override bool ShowStatTooltipLine(Player player, string lineName) => true;
	}
    public class SadistSummon : DamageClass
	{
		public override StatInheritanceData GetModifierInheritance(DamageClass damageClass) {
			if (damageClass == ModContent.GetInstance<SadistGeneric>() || damageClass == Summon || damageClass == Generic) { return StatInheritanceData.Full; }
			return StatInheritanceData.None;
		}
		public override bool GetEffectInheritance(DamageClass damageClass) {
            if (damageClass == ModContent.GetInstance<SadistGeneric>() || damageClass == Summon || damageClass == Generic) { return true;}
            return false;
        }
		public override bool UseStandardCritCalcs => true;
		public override bool ShowStatTooltipLine(Player player, string lineName) => true;
	}
    public class SadistMeleeNoSpeed : DamageClass
	{
		public override StatInheritanceData GetModifierInheritance(DamageClass damageClass) {
			if (damageClass == ModContent.GetInstance<SadistGeneric>() || damageClass == MeleeNoSpeed || damageClass == Generic) { return StatInheritanceData.Full; }
			return StatInheritanceData.None;
		}
		public override bool GetEffectInheritance(DamageClass damageClass) {
            if (damageClass == ModContent.GetInstance<SadistGeneric>() || damageClass == MeleeNoSpeed || damageClass == Generic) { return true;}
            return false;
        }
		public override bool UseStandardCritCalcs => true;
		public override bool ShowStatTooltipLine(Player player, string lineName) => true;
	}
    public class SadistSummonMeleeSpeed : DamageClass
	{
		public override StatInheritanceData GetModifierInheritance(DamageClass damageClass) {
			if (damageClass == ModContent.GetInstance<SadistGeneric>() || damageClass == SummonMeleeSpeed || damageClass == Generic) { return StatInheritanceData.Full; }
			return StatInheritanceData.None;
		}
		public override bool GetEffectInheritance(DamageClass damageClass) {
            if (damageClass == ModContent.GetInstance<SadistGeneric>() || damageClass == SummonMeleeSpeed || damageClass == Generic) { return true;}
            return false;
        }
		public override bool UseStandardCritCalcs => true;
		public override bool ShowStatTooltipLine(Player player, string lineName) => true;
	}
}