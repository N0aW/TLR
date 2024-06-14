using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace TLR.Content.Core.DamageClasses
{
	public class Style : DamageClass
	{
		public override void SetStaticDefaults() {
		}
		public override StatInheritanceData GetModifierInheritance(DamageClass damageClass) {
			// Default is, you guessed it, the default damage class. It doesn't scale off of any class-specific stat bonuses or universal stat bonuses.
			// There are a number of items and projectiles that use this, such as thrown waters and the Bone Glove's bones.
			// Generic, on the other hand, scales off of all universal stat bonuses and nothing else; it's the base damage class upon which all others that aren't Default are built.
			if (damageClass == DamageClass.Generic) {
				return new StatInheritanceData(
				damageInheritance: 1f,
				critChanceInheritance: 1f,
				attackSpeedInheritance: 1f,
				armorPenInheritance: 1f,
				knockbackInheritance: 1f
			    );
			}
			return new StatInheritanceData(
				damageInheritance: 0f,
				critChanceInheritance: 0f,
				attackSpeedInheritance: 0f,
				armorPenInheritance: 0f,
				knockbackInheritance: 0f
			);
			// This would allow our custom class to benefit from the following ranged stat bonuses:
			// - Damage, at 100% effectiveness
			// - Attack speed, at 40% effectiveness
			// - Crit chance, at -100% effectiveness (this means anything that raises ranged crit chance specifically will lower the crit chance of our custom class by the same amount)
			// - Armor penetration, at 250% effectiveness
		}

		public override bool GetEffectInheritance(DamageClass damageClass) {
			/*
			if (damageClass == DamageClass.Melee)
				return true;
			if (damageClass == DamageClass.Magic)
				return true;
			*/
			return false;
		}

		public override void SetDefaultStats(Player player) {
			// This method lets you set default statistical modifiers for your example damage class.
			// Here, we'll make our example damage class have more critical strike chance and armor penetration than normal.
			/*
			player.GetCritChance<ExampleDamageClass>() += 4;
			player.GetArmorPenetration<ExampleDamageClass>() += 10;
			*/
			// These sorts of modifiers also exist for damage (GetDamage), knockback (GetKnockback), and attack speed (GetAttackSpeed).
			// You'll see these used all around in referencce to vanilla classes and our example class here. Familiarize yourself with them.
		}

		// This property lets you decide whether or not your damage class can use standard critical strike calculations.
		// Note that setting it to false will also prevent the critical strike chance tooltip line from being shown.
		// This prevention will overrule anything set by ShowStatTooltipLine, so be careful!
		public override bool UseStandardCritCalcs => true;

		public override bool ShowStatTooltipLine(Player player, string lineName) {
			// This method lets you prevent certain common statistical tooltip lines from appearing on items associated with this DamageClass.
			// The four line names you can use are "Damage", "CritChance", "Speed", and "Knockback". All four cases default to true, and thus will be shown. For example...
			return true;
		}
	}
    public class StyleMelee : DamageClass
	{
		public override void SetStaticDefaults() {
		}
		public override StatInheritanceData GetModifierInheritance(DamageClass damageClass) {
			// Default is, you guessed it, the default damage class. It doesn't scale off of any class-specific stat bonuses or universal stat bonuses.
			// There are a number of items and projectiles that use this, such as thrown waters and the Bone Glove's bones.
			// Generic, on the other hand, scales off of all universal stat bonuses and nothing else; it's the base damage class upon which all others that aren't Default are built.
			if (damageClass == DamageClass.Generic) {
				return new StatInheritanceData(
				damageInheritance: 1f,
				critChanceInheritance: 1f,
				attackSpeedInheritance: 1f,
				armorPenInheritance: 1f,
				knockbackInheritance: 1f
			    );
			}
            if (damageClass == DamageClass.Melee) {
				return new StatInheritanceData(
				damageInheritance: 1f,
				critChanceInheritance: 1f,
				attackSpeedInheritance: 1f,
				armorPenInheritance: 1f,
				knockbackInheritance: 1f
			    );
			}
            if (damageClass == ModContent.GetInstance<DamageClasses.Style>()) {
				return new StatInheritanceData(
				damageInheritance: 1f,
				critChanceInheritance: 1f,
				attackSpeedInheritance: 1f,
				armorPenInheritance: 1f,
				knockbackInheritance: 1f
			    );
			}
			return new StatInheritanceData(
				damageInheritance: 0f,
				critChanceInheritance: 0f,
				attackSpeedInheritance: 0f,
				armorPenInheritance: 0f,
				knockbackInheritance: 0f
			);
			// This would allow our custom class to benefit from the following ranged stat bonuses:
			// - Damage, at 100% effectiveness
			// - Attack speed, at 40% effectiveness
			// - Crit chance, at -100% effectiveness (this means anything that raises ranged crit chance specifically will lower the crit chance of our custom class by the same amount)
			// - Armor penetration, at 250% effectiveness
		}

		public override bool GetEffectInheritance(DamageClass damageClass) {
			if (damageClass == DamageClass.Melee)
				return true;
            if (damageClass == ModContent.GetInstance<DamageClasses.Style>())
				return true;
			return false;
		}

		public override void SetDefaultStats(Player player) {
			// This method lets you set default statistical modifiers for your example damage class.
			// Here, we'll make our example damage class have more critical strike chance and armor penetration than normal.
			/*
			player.GetCritChance<ExampleDamageClass>() += 4;
			player.GetArmorPenetration<ExampleDamageClass>() += 10;
			*/
			// These sorts of modifiers also exist for damage (GetDamage), knockback (GetKnockback), and attack speed (GetAttackSpeed).
			// You'll see these used all around in referencce to vanilla classes and our example class here. Familiarize yourself with them.
		}

		// This property lets you decide whether or not your damage class can use standard critical strike calculations.
		// Note that setting it to false will also prevent the critical strike chance tooltip line from being shown.
		// This prevention will overrule anything set by ShowStatTooltipLine, so be careful!
		public override bool UseStandardCritCalcs => true;

		public override bool ShowStatTooltipLine(Player player, string lineName) {
			// This method lets you prevent certain common statistical tooltip lines from appearing on items associated with this DamageClass.
			// The four line names you can use are "Damage", "CritChance", "Speed", and "Knockback". All four cases default to true, and thus will be shown. For example...
			return true;
		}
	}
	public class StyleMeleeNoSpeed : DamageClass
	{
		public override void SetStaticDefaults() {
		}
		public override StatInheritanceData GetModifierInheritance(DamageClass damageClass) {
			// Default is, you guessed it, the default damage class. It doesn't scale off of any class-specific stat bonuses or universal stat bonuses.
			// There are a number of items and projectiles that use this, such as thrown waters and the Bone Glove's bones.
			// Generic, on the other hand, scales off of all universal stat bonuses and nothing else; it's the base damage class upon which all others that aren't Default are built.
			if (damageClass == DamageClass.Generic) {
				return new StatInheritanceData(
				damageInheritance: 1f,
				critChanceInheritance: 1f,
				attackSpeedInheritance: 0f,
				armorPenInheritance: 1f,
				knockbackInheritance: 1f
			    );
			}
            if (damageClass == DamageClass.Melee) {
				return new StatInheritanceData(
				damageInheritance: 1f,
				critChanceInheritance: 1f,
				attackSpeedInheritance: 0f,
				armorPenInheritance: 1f,
				knockbackInheritance: 1f
			    );
			}
            if (damageClass == ModContent.GetInstance<DamageClasses.Style>()) {
				return new StatInheritanceData(
				damageInheritance: 1f,
				critChanceInheritance: 1f,
				attackSpeedInheritance: 0f,
				armorPenInheritance: 1f,
				knockbackInheritance: 1f
			    );
			}
			return new StatInheritanceData(
				damageInheritance: 0f,
				critChanceInheritance: 0f,
				attackSpeedInheritance: 0f,
				armorPenInheritance: 0f,
				knockbackInheritance: 0f
			);
			// This would allow our custom class to benefit from the following ranged stat bonuses:
			// - Damage, at 100% effectiveness
			// - Attack speed, at 40% effectiveness
			// - Crit chance, at -100% effectiveness (this means anything that raises ranged crit chance specifically will lower the crit chance of our custom class by the same amount)
			// - Armor penetration, at 250% effectiveness
		}

		public override bool GetEffectInheritance(DamageClass damageClass) {
			if (damageClass == DamageClass.Melee)
				return true;
            if (damageClass == ModContent.GetInstance<DamageClasses.Style>())
				return true;
			return false;
		}

		public override void SetDefaultStats(Player player) {
			// This method lets you set default statistical modifiers for your example damage class.
			// Here, we'll make our example damage class have more critical strike chance and armor penetration than normal.
			/*
			player.GetCritChance<ExampleDamageClass>() += 4;
			player.GetArmorPenetration<ExampleDamageClass>() += 10;
			*/
			// These sorts of modifiers also exist for damage (GetDamage), knockback (GetKnockback), and attack speed (GetAttackSpeed).
			// You'll see these used all around in referencce to vanilla classes and our example class here. Familiarize yourself with them.
		}

		// This property lets you decide whether or not your damage class can use standard critical strike calculations.
		// Note that setting it to false will also prevent the critical strike chance tooltip line from being shown.
		// This prevention will overrule anything set by ShowStatTooltipLine, so be careful!
		public override bool UseStandardCritCalcs => true;

		public override bool ShowStatTooltipLine(Player player, string lineName) {
			// This method lets you prevent certain common statistical tooltip lines from appearing on items associated with this DamageClass.
			// The four line names you can use are "Damage", "CritChance", "Speed", and "Knockback". All four cases default to true, and thus will be shown. For example...
			return true;
		}
	}
    public class StyleRanged : DamageClass
	{
		public override void SetStaticDefaults() {
		}
		public override StatInheritanceData GetModifierInheritance(DamageClass damageClass) {
			// Default is, you guessed it, the default damage class. It doesn't scale off of any class-specific stat bonuses or universal stat bonuses.
			// There are a number of items and projectiles that use this, such as thrown waters and the Bone Glove's bones.
			// Generic, on the other hand, scales off of all universal stat bonuses and nothing else; it's the base damage class upon which all others that aren't Default are built.
			if (damageClass == DamageClass.Generic) {
				return new StatInheritanceData(
				damageInheritance: 1f,
				critChanceInheritance: 1f,
				attackSpeedInheritance: 1f,
				armorPenInheritance: 1f,
				knockbackInheritance: 1f
			    );
			}
            if (damageClass == DamageClass.Ranged) {
				return new StatInheritanceData(
				damageInheritance: 1f,
				critChanceInheritance: 1f,
				attackSpeedInheritance: 1f,
				armorPenInheritance: 1f,
				knockbackInheritance: 1f
			    );
			}
            if (damageClass == ModContent.GetInstance<DamageClasses.Style>()) {
				return new StatInheritanceData(
				damageInheritance: 1f,
				critChanceInheritance: 1f,
				attackSpeedInheritance: 1f,
				armorPenInheritance: 1f,
				knockbackInheritance: 1f
			    );
			}
			return new StatInheritanceData(
				damageInheritance: 0f,
				critChanceInheritance: 0f,
				attackSpeedInheritance: 0f,
				armorPenInheritance: 0f,
				knockbackInheritance: 0f
			);
			// This would allow our custom class to benefit from the following ranged stat bonuses:
			// - Damage, at 100% effectiveness
			// - Attack speed, at 40% effectiveness
			// - Crit chance, at -100% effectiveness (this means anything that raises ranged crit chance specifically will lower the crit chance of our custom class by the same amount)
			// - Armor penetration, at 250% effectiveness
		}

		public override bool GetEffectInheritance(DamageClass damageClass) {
			if (damageClass == DamageClass.Ranged)
				return true;
            if (damageClass == ModContent.GetInstance<DamageClasses.Style>())
				return true;
			return false;
		}

		public override void SetDefaultStats(Player player) {
			// This method lets you set default statistical modifiers for your example damage class.
			// Here, we'll make our example damage class have more critical strike chance and armor penetration than normal.
			/*
			player.GetCritChance<ExampleDamageClass>() += 4;
			player.GetArmorPenetration<ExampleDamageClass>() += 10;
			*/
			// These sorts of modifiers also exist for damage (GetDamage), knockback (GetKnockback), and attack speed (GetAttackSpeed).
			// You'll see these used all around in referencce to vanilla classes and our example class here. Familiarize yourself with them.
		}

		// This property lets you decide whether or not your damage class can use standard critical strike calculations.
		// Note that setting it to false will also prevent the critical strike chance tooltip line from being shown.
		// This prevention will overrule anything set by ShowStatTooltipLine, so be careful!
		public override bool UseStandardCritCalcs => true;

		public override bool ShowStatTooltipLine(Player player, string lineName) {
			// This method lets you prevent certain common statistical tooltip lines from appearing on items associated with this DamageClass.
			// The four line names you can use are "Damage", "CritChance", "Speed", and "Knockback". All four cases default to true, and thus will be shown. For example...
			return true;
		}
	}
    public class StyleMagic : DamageClass
	{
		public override void SetStaticDefaults() {
		}
		public override StatInheritanceData GetModifierInheritance(DamageClass damageClass) {
			// Default is, you guessed it, the default damage class. It doesn't scale off of any class-specific stat bonuses or universal stat bonuses.
			// There are a number of items and projectiles that use this, such as thrown waters and the Bone Glove's bones.
			// Generic, on the other hand, scales off of all universal stat bonuses and nothing else; it's the base damage class upon which all others that aren't Default are built.
			if (damageClass == DamageClass.Generic) {
				return new StatInheritanceData(
				damageInheritance: 1f,
				critChanceInheritance: 1f,
				attackSpeedInheritance: 1f,
				armorPenInheritance: 1f,
				knockbackInheritance: 1f
			    );
			}
            if (damageClass == DamageClass.Magic) {
				return new StatInheritanceData(
				damageInheritance: 1f,
				critChanceInheritance: 1f,
				attackSpeedInheritance: 1f,
				armorPenInheritance: 1f,
				knockbackInheritance: 1f
			    );
			}
            if (damageClass == ModContent.GetInstance<DamageClasses.Style>()) {
				return new StatInheritanceData(
				damageInheritance: 1f,
				critChanceInheritance: 1f,
				attackSpeedInheritance: 1f,
				armorPenInheritance: 1f,
				knockbackInheritance: 1f
			    );
			}
			return new StatInheritanceData(
				damageInheritance: 0f,
				critChanceInheritance: 0f,
				attackSpeedInheritance: 0f,
				armorPenInheritance: 0f,
				knockbackInheritance: 0f
			);
			// This would allow our custom class to benefit from the following ranged stat bonuses:
			// - Damage, at 100% effectiveness
			// - Attack speed, at 40% effectiveness
			// - Crit chance, at -100% effectiveness (this means anything that raises ranged crit chance specifically will lower the crit chance of our custom class by the same amount)
			// - Armor penetration, at 250% effectiveness
		}

		public override bool GetEffectInheritance(DamageClass damageClass) {
			if (damageClass == DamageClass.Magic)
				return true;
            if (damageClass == ModContent.GetInstance<DamageClasses.Style>())
				return true;
			return false;
		}

		public override void SetDefaultStats(Player player) {
			// This method lets you set default statistical modifiers for your example damage class.
			// Here, we'll make our example damage class have more critical strike chance and armor penetration than normal.
			/*
			player.GetCritChance<ExampleDamageClass>() += 4;
			player.GetArmorPenetration<ExampleDamageClass>() += 10;
			*/
			// These sorts of modifiers also exist for damage (GetDamage), knockback (GetKnockback), and attack speed (GetAttackSpeed).
			// You'll see these used all around in referencce to vanilla classes and our example class here. Familiarize yourself with them.
		}

		// This property lets you decide whether or not your damage class can use standard critical strike calculations.
		// Note that setting it to false will also prevent the critical strike chance tooltip line from being shown.
		// This prevention will overrule anything set by ShowStatTooltipLine, so be careful!
		public override bool UseStandardCritCalcs => true;

		public override bool ShowStatTooltipLine(Player player, string lineName) {
			// This method lets you prevent certain common statistical tooltip lines from appearing on items associated with this DamageClass.
			// The four line names you can use are "Damage", "CritChance", "Speed", and "Knockback". All four cases default to true, and thus will be shown. For example...
			return true;
		}
	}
    public class StyleSummon : DamageClass
	{
		public override void SetStaticDefaults() {
		}
		public override StatInheritanceData GetModifierInheritance(DamageClass damageClass) {
			// Default is, you guessed it, the default damage class. It doesn't scale off of any class-specific stat bonuses or universal stat bonuses.
			// There are a number of items and projectiles that use this, such as thrown waters and the Bone Glove's bones.
			// Generic, on the other hand, scales off of all universal stat bonuses and nothing else; it's the base damage class upon which all others that aren't Default are built.
			if (damageClass == DamageClass.Generic) {
				return new StatInheritanceData(
				damageInheritance: 1f,
				critChanceInheritance: 1f,
				attackSpeedInheritance: 1f,
				armorPenInheritance: 1f,
				knockbackInheritance: 1f
			    );
			}
            if (damageClass == DamageClass.Summon) {
				return new StatInheritanceData(
				damageInheritance: 1f,
				critChanceInheritance: 1f,
				attackSpeedInheritance: 1f,
				armorPenInheritance: 1f,
				knockbackInheritance: 1f
			    );
			}
            if (damageClass == ModContent.GetInstance<DamageClasses.Style>()) {
				return new StatInheritanceData(
				damageInheritance: 1f,
				critChanceInheritance: 1f,
				attackSpeedInheritance: 1f,
				armorPenInheritance: 1f,
				knockbackInheritance: 1f
			    );
			}
			return new StatInheritanceData(
				damageInheritance: 0f,
				critChanceInheritance: 0f,
				attackSpeedInheritance: 0f,
				armorPenInheritance: 0f,
				knockbackInheritance: 0f
			);
			// This would allow our custom class to benefit from the following ranged stat bonuses:
			// - Damage, at 100% effectiveness
			// - Attack speed, at 40% effectiveness
			// - Crit chance, at -100% effectiveness (this means anything that raises ranged crit chance specifically will lower the crit chance of our custom class by the same amount)
			// - Armor penetration, at 250% effectiveness
		}

		public override bool GetEffectInheritance(DamageClass damageClass) {
			if (damageClass == DamageClass.Summon)
				return true;
            if (damageClass == ModContent.GetInstance<DamageClasses.Style>())
				return true;
			return false;
		}

		public override void SetDefaultStats(Player player) {
			// This method lets you set default statistical modifiers for your example damage class.
			// Here, we'll make our example damage class have more critical strike chance and armor penetration than normal.
			/*
			player.GetCritChance<ExampleDamageClass>() += 4;
			player.GetArmorPenetration<ExampleDamageClass>() += 10;
			*/
			// These sorts of modifiers also exist for damage (GetDamage), knockback (GetKnockback), and attack speed (GetAttackSpeed).
			// You'll see these used all around in referencce to vanilla classes and our example class here. Familiarize yourself with them.
		}

		// This property lets you decide whether or not your damage class can use standard critical strike calculations.
		// Note that setting it to false will also prevent the critical strike chance tooltip line from being shown.
		// This prevention will overrule anything set by ShowStatTooltipLine, so be careful!
		public override bool UseStandardCritCalcs => false;

		public override bool ShowStatTooltipLine(Player player, string lineName) {
			// This method lets you prevent certain common statistical tooltip lines from appearing on items associated with this DamageClass.
			// The four line names you can use are "Damage", "CritChance", "Speed", and "Knockback". All four cases default to true, and thus will be shown. For example...
			return true;
		}
	}
	public class StyleSummonWhip : DamageClass
	{
		public override void SetStaticDefaults() {
		}
		public override StatInheritanceData GetModifierInheritance(DamageClass damageClass) {
			// Default is, you guessed it, the default damage class. It doesn't scale off of any class-specific stat bonuses or universal stat bonuses.
			// There are a number of items and projectiles that use this, such as thrown waters and the Bone Glove's bones.
			// Generic, on the other hand, scales off of all universal stat bonuses and nothing else; it's the base damage class upon which all others that aren't Default are built.
			if (damageClass == DamageClass.Generic) {
				return new StatInheritanceData(
				damageInheritance: 1f,
				critChanceInheritance: 1f,
				attackSpeedInheritance: 1f,
				armorPenInheritance: 1f,
				knockbackInheritance: 1f
			    );
			}
            if (damageClass == DamageClass.Summon) {
				return new StatInheritanceData(
				damageInheritance: 1f,
				critChanceInheritance: 1f,
				attackSpeedInheritance: 1f,
				armorPenInheritance: 1f,
				knockbackInheritance: 1f
			    );
			}
			if (damageClass == DamageClass.Melee) {
				return new StatInheritanceData(
				damageInheritance: 0f,
				critChanceInheritance: 0f,
				attackSpeedInheritance: 1f,
				armorPenInheritance: 0f,
				knockbackInheritance: 0f
			    );
			}
            if (damageClass == ModContent.GetInstance<DamageClasses.Style>()) {
				return new StatInheritanceData(
				damageInheritance: 1f,
				critChanceInheritance: 1f,
				attackSpeedInheritance: 1f,
				armorPenInheritance: 1f,
				knockbackInheritance: 1f
			    );
			}
			return new StatInheritanceData(
				damageInheritance: 0f,
				critChanceInheritance: 0f,
				attackSpeedInheritance: 0f,
				armorPenInheritance: 0f,
				knockbackInheritance: 0f
			);
			// This would allow our custom class to benefit from the following ranged stat bonuses:
			// - Damage, at 100% effectiveness
			// - Attack speed, at 40% effectiveness
			// - Crit chance, at -100% effectiveness (this means anything that raises ranged crit chance specifically will lower the crit chance of our custom class by the same amount)
			// - Armor penetration, at 250% effectiveness
		}

		public override bool GetEffectInheritance(DamageClass damageClass) {
			if (damageClass == DamageClass.Summon)
				return true;
            if (damageClass == ModContent.GetInstance<DamageClasses.Style>())
				return true;
			return false;
		}

		public override void SetDefaultStats(Player player) {
			// This method lets you set default statistical modifiers for your example damage class.
			// Here, we'll make our example damage class have more critical strike chance and armor penetration than normal.
			/*
			player.GetCritChance<ExampleDamageClass>() += 4;
			player.GetArmorPenetration<ExampleDamageClass>() += 10;
			*/
			// These sorts of modifiers also exist for damage (GetDamage), knockback (GetKnockback), and attack speed (GetAttackSpeed).
			// You'll see these used all around in referencce to vanilla classes and our example class here. Familiarize yourself with them.
		}

		// This property lets you decide whether or not your damage class can use standard critical strike calculations.
		// Note that setting it to false will also prevent the critical strike chance tooltip line from being shown.
		// This prevention will overrule anything set by ShowStatTooltipLine, so be careful!
		public override bool UseStandardCritCalcs => false;

		public override bool ShowStatTooltipLine(Player player, string lineName) {
			// This method lets you prevent certain common statistical tooltip lines from appearing on items associated with this DamageClass.
			// The four line names you can use are "Damage", "CritChance", "Speed", and "Knockback". All four cases default to true, and thus will be shown. For example...
			return true;
		}
	}
}