using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace TLR.Content.Core.Classes
{
	public class MasochistGeneric : DamageClass
	{
		public override StatInheritanceData GetModifierInheritance(DamageClass damageClass) => StatInheritanceData.None;

		public override bool GetEffectInheritance(DamageClass damageClass) => false;
		public override bool UseStandardCritCalcs => true;
		public override bool ShowStatTooltipLine(Player player, string lineName) => true;
	}
	public class MasochistMelee : DamageClass
	{
		public override StatInheritanceData GetModifierInheritance(DamageClass damageClass) {
			if (damageClass == ModContent.GetInstance<MasochistGeneric>() || damageClass == Melee) { return StatInheritanceData.Full; }
			return StatInheritanceData.None;
		}
		public override bool GetEffectInheritance(DamageClass damageClass) {
            if (damageClass == ModContent.GetInstance<MasochistGeneric>() || damageClass == Melee) { return true;}
            return false;
        }
		public override bool UseStandardCritCalcs => true;
		public override bool ShowStatTooltipLine(Player player, string lineName) => true;
	}
    public class MasochistRanged : DamageClass
	{
		public override StatInheritanceData GetModifierInheritance(DamageClass damageClass) {
			if (damageClass == ModContent.GetInstance<MasochistGeneric>() || damageClass == Ranged) { return StatInheritanceData.Full; }
			return StatInheritanceData.None;
		}
		public override bool GetEffectInheritance(DamageClass damageClass) {
            if (damageClass == ModContent.GetInstance<MasochistGeneric>() || damageClass == Ranged) { return true;}
            return false;
        }
		public override bool UseStandardCritCalcs => true;
		public override bool ShowStatTooltipLine(Player player, string lineName) => true;
	}
    public class MasochistMagic : DamageClass
	{
		public override StatInheritanceData GetModifierInheritance(DamageClass damageClass) {
			if (damageClass == ModContent.GetInstance<MasochistGeneric>() || damageClass == Magic) { return StatInheritanceData.Full; }
			return StatInheritanceData.None;
		}
		public override bool GetEffectInheritance(DamageClass damageClass) {
            if (damageClass == ModContent.GetInstance<MasochistGeneric>() || damageClass == Magic) { return true;}
            return false;
        }
		public override bool UseStandardCritCalcs => true;
		public override bool ShowStatTooltipLine(Player player, string lineName) => true;
	}
    public class MasochistSummon : DamageClass
	{
		public override StatInheritanceData GetModifierInheritance(DamageClass damageClass) {
			if (damageClass == ModContent.GetInstance<MasochistGeneric>() || damageClass == Summon) { return StatInheritanceData.Full; }
			return StatInheritanceData.None;
		}
		public override bool GetEffectInheritance(DamageClass damageClass) {
            if (damageClass == ModContent.GetInstance<MasochistGeneric>() || damageClass == Summon) { return true;}
            return false;
        }
		public override bool UseStandardCritCalcs => true;
		public override bool ShowStatTooltipLine(Player player, string lineName) => true;
	}
    public class MasochistMeleeNoSpeed : DamageClass
	{
		public override StatInheritanceData GetModifierInheritance(DamageClass damageClass) {
			if (damageClass == ModContent.GetInstance<MasochistGeneric>() || damageClass == MeleeNoSpeed) { return StatInheritanceData.Full; }
			return StatInheritanceData.None;
		}
		public override bool GetEffectInheritance(DamageClass damageClass) {
            if (damageClass == ModContent.GetInstance<MasochistGeneric>() || damageClass == MeleeNoSpeed) { return true;}
            return false;
        }
		public override bool UseStandardCritCalcs => true;
		public override bool ShowStatTooltipLine(Player player, string lineName) => true;
	}
    public class MasochistSummonMeleeSpeed : DamageClass
	{
		public override StatInheritanceData GetModifierInheritance(DamageClass damageClass) {
			if (damageClass == ModContent.GetInstance<MasochistGeneric>() || damageClass == SummonMeleeSpeed) { return StatInheritanceData.Full; }
			return StatInheritanceData.None;
		}
		public override bool GetEffectInheritance(DamageClass damageClass) {
            if (damageClass == ModContent.GetInstance<MasochistGeneric>() || damageClass == SummonMeleeSpeed) { return true;}
            return false;
        }
		public override bool UseStandardCritCalcs => true;
		public override bool ShowStatTooltipLine(Player player, string lineName) => true;
	}
}