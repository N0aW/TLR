using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace TLR.Content.Core.Classes.Style
{
	public class StyleGeneric : DamageClass
	{
		public override StatInheritanceData GetModifierInheritance(DamageClass damageClass) {
			if (damageClass == Generic) { return StatInheritanceData.Full; }
			return StatInheritanceData.None;
		}

		public override bool GetEffectInheritance(DamageClass damageClass) => false;
		public override bool UseStandardCritCalcs => true;
		public override bool ShowStatTooltipLine(Player player, string lineName) => true;
	}
	public class StyleMelee : DamageClass
	{
		public override StatInheritanceData GetModifierInheritance(DamageClass damageClass) {
			if (damageClass == Generic || damageClass == Melee || damageClass == ModContent.GetInstance<StyleGeneric>())
			{ return StatInheritanceData.Full; }
			return StatInheritanceData.None;
		}
		public override bool GetEffectInheritance(DamageClass damageClass)
		{if (damageClass == Melee || damageClass == ModContent.GetInstance<StyleGeneric>()) {return true;} return false;}
		public override bool UseStandardCritCalcs => true;
		public override bool ShowStatTooltipLine(Player player, string lineName) => true;
	}
	public class StyleMeleeNoSpeed : DamageClass
	{
		public override StatInheritanceData GetModifierInheritance(DamageClass damageClass) {
			if (damageClass == Generic || damageClass == Melee || damageClass == ModContent.GetInstance<StyleGeneric>())
			{ return new StatInheritanceData()
			{attackSpeedInheritance = 0f, damageInheritance = 1f, armorPenInheritance = 1f, critChanceInheritance = 1f, knockbackInheritance = 1f};}
			return StatInheritanceData.None;
		}
		public override bool GetEffectInheritance(DamageClass damageClass)
		{if (damageClass == Melee || damageClass == ModContent.GetInstance<StyleGeneric>()) {return true;} return false;}
		public override bool UseStandardCritCalcs => true;
		public override bool ShowStatTooltipLine(Player player, string lineName) => true;
	}
	public class StyleRanged : DamageClass
	{
		public override StatInheritanceData GetModifierInheritance(DamageClass damageClass) {
			if (damageClass == Generic || damageClass == Ranged || damageClass == ModContent.GetInstance<StyleGeneric>())
			{ return StatInheritanceData.Full; }
			return StatInheritanceData.None;
		}
		public override bool GetEffectInheritance(DamageClass damageClass)
		{if (damageClass == Ranged || damageClass == ModContent.GetInstance<StyleGeneric>()) {return true;} return false;}
		public override bool UseStandardCritCalcs => true;
		public override bool ShowStatTooltipLine(Player player, string lineName) => true;
	}
	public class StyleMagic : DamageClass
	{
		public override StatInheritanceData GetModifierInheritance(DamageClass damageClass) {
			if (damageClass == Generic || damageClass == Magic || damageClass == ModContent.GetInstance<StyleGeneric>())
			{ return StatInheritanceData.Full; }
			return StatInheritanceData.None;
		}
		public override bool GetEffectInheritance(DamageClass damageClass)
		{if (damageClass == Magic || damageClass == ModContent.GetInstance<StyleGeneric>()) {return true;} return false;}
		public override bool UseStandardCritCalcs => true;
		public override bool ShowStatTooltipLine(Player player, string lineName) => true;
	}
	public class StyleSummon : DamageClass
	{
		public override StatInheritanceData GetModifierInheritance(DamageClass damageClass) {
			if (damageClass == Generic || damageClass == Summon || damageClass == ModContent.GetInstance<StyleGeneric>())
			{ return StatInheritanceData.Full; }
			return StatInheritanceData.None;
		}
		public override bool GetEffectInheritance(DamageClass damageClass)
		{if (damageClass == Summon || damageClass == ModContent.GetInstance<StyleGeneric>()) {return true;} return false;}
		public override bool UseStandardCritCalcs => true;
		public override bool ShowStatTooltipLine(Player player, string lineName) => true;
	}
	public class StyleSummonWhip : DamageClass
	{
		public override StatInheritanceData GetModifierInheritance(DamageClass damageClass) {
			if (damageClass == Generic || damageClass == Summon || damageClass == ModContent.GetInstance<StyleGeneric>())
			{ return StatInheritanceData.Full; }
			if (damageClass == Melee) { return new StatInheritanceData(attackSpeedInheritance: 1f); }
			return StatInheritanceData.None;
		}
		public override bool GetEffectInheritance(DamageClass damageClass)
		{if (damageClass == Melee || damageClass == ModContent.GetInstance<StyleGeneric>()) {return true;} return false;}
		public override bool UseStandardCritCalcs => true;
		public override bool ShowStatTooltipLine(Player player, string lineName) => true;
	}
}