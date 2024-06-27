using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace TLR.Content.Core.Classes.Support
{
	public class SupportGeneric : DamageClass
	{
		public override StatInheritanceData GetModifierInheritance(DamageClass damageClass) {
			if (damageClass == Generic) { return StatInheritanceData.Full; }
			return StatInheritanceData.None;
		}

		public override bool GetEffectInheritance(DamageClass damageClass) => false;
		public override bool UseStandardCritCalcs => true;
		public override bool ShowStatTooltipLine(Player player, string lineName) => true;
	}
	public class SupportMelee : DamageClass
	{
		public override StatInheritanceData GetModifierInheritance(DamageClass damageClass) {
			if (damageClass == Generic || damageClass == Melee || damageClass == ModContent.GetInstance<SupportGeneric>())
			{ return StatInheritanceData.Full; }
			return StatInheritanceData.None;
		}
		public override bool GetEffectInheritance(DamageClass damageClass)
		{if (damageClass == Melee || damageClass == ModContent.GetInstance<SupportGeneric>()) {return true;} return false;}
		public override bool UseStandardCritCalcs => true;
		public override bool ShowStatTooltipLine(Player player, string lineName) => true;
	}
	public class SupportMeleeNoSpeed : DamageClass
	{
		public override StatInheritanceData GetModifierInheritance(DamageClass damageClass) {
			if (damageClass == Generic || damageClass == Melee || damageClass == ModContent.GetInstance<SupportGeneric>())
			{ return new StatInheritanceData()
			{attackSpeedInheritance = 0f, damageInheritance = 1f, armorPenInheritance = 1f, critChanceInheritance = 1f, knockbackInheritance = 1f};}
			return StatInheritanceData.None;
		}
		public override bool GetEffectInheritance(DamageClass damageClass)
		{if (damageClass == Melee || damageClass == ModContent.GetInstance<SupportGeneric>()) {return true;} return false;}
		public override bool UseStandardCritCalcs => true;
		public override bool ShowStatTooltipLine(Player player, string lineName) => true;
	}
	public class SupportRanged : DamageClass
	{
		public override StatInheritanceData GetModifierInheritance(DamageClass damageClass) {
			if (damageClass == Generic || damageClass == Ranged || damageClass == ModContent.GetInstance<SupportGeneric>())
			{ return StatInheritanceData.Full; }
			return StatInheritanceData.None;
		}
		public override bool GetEffectInheritance(DamageClass damageClass)
		{if (damageClass == Ranged || damageClass == ModContent.GetInstance<SupportGeneric>()) {return true;} return false;}
		public override bool UseStandardCritCalcs => true;
		public override bool ShowStatTooltipLine(Player player, string lineName) => true;
	}
	public class SupportMagic : DamageClass
	{
		public override StatInheritanceData GetModifierInheritance(DamageClass damageClass) {
			if (damageClass == Generic || damageClass == Magic || damageClass == ModContent.GetInstance<SupportGeneric>())
			{ return StatInheritanceData.Full; }
			return StatInheritanceData.None;
		}
		public override bool GetEffectInheritance(DamageClass damageClass)
		{if (damageClass == Magic || damageClass == ModContent.GetInstance<SupportGeneric>()) {return true;} return false;}
		public override bool UseStandardCritCalcs => true;
		public override bool ShowStatTooltipLine(Player player, string lineName) => true;
	}
	public class SupportSummon : DamageClass
	{
		public override StatInheritanceData GetModifierInheritance(DamageClass damageClass) {
			if (damageClass == Generic || damageClass == Summon || damageClass == ModContent.GetInstance<SupportGeneric>())
			{ return StatInheritanceData.Full; }
			return StatInheritanceData.None;
		}
		public override bool GetEffectInheritance(DamageClass damageClass)
		{if (damageClass == Summon || damageClass == ModContent.GetInstance<SupportGeneric>()) {return true;} return false;}
		public override bool UseStandardCritCalcs => true;
		public override bool ShowStatTooltipLine(Player player, string lineName) => true;
	}
	public class SupportSummonWhip : DamageClass
	{
		public override StatInheritanceData GetModifierInheritance(DamageClass damageClass) {
			if (damageClass == Generic || damageClass == Summon || damageClass == ModContent.GetInstance<SupportGeneric>())
			{ return StatInheritanceData.Full; }
			if (damageClass == Melee) { return new StatInheritanceData(attackSpeedInheritance: 1f); }
			return StatInheritanceData.None;
		}
		public override bool GetEffectInheritance(DamageClass damageClass)
		{if (damageClass == Melee || damageClass == ModContent.GetInstance<SupportGeneric>()) {return true;} return false;}
		public override bool UseStandardCritCalcs => true;
		public override bool ShowStatTooltipLine(Player player, string lineName) => true;
	}
}