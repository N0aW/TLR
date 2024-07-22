using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;

namespace TLR.Content.Core.Buffs
{
	public class TheBigOne : ModBuff
	{
        public override void SetStaticDefaults()
        {
            Main.debuff[Type] = true;
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
			BuffID.Sets.LongerExpertDebuff[Type] = false;
        }
		public override void Update(Player player, ref int buffIndex) {
			// Attack Boosts
            player.GetDamage(DamageClass.Generic) += 0.01f;
            player.GetCritChance(DamageClass.Generic) += 1;
            player.GetAttackSpeed(DamageClass.Generic) += 0.01f;
            player.GetKnockback(DamageClass.Generic) += 1f;
            player.manaCost -= 0.01f;
            player.maxMinions += 1;
            player.maxTurrets += 1;
            // Stat Boosts
            player.statLifeMax2 += 1;
            player.statManaMax2 += 1;
            player.lifeRegen += 1;
            player.manaRegen += 1;
            // Defense Boosts
            player.statDefense += 1;
            player.endurance += 0.01f;
            player.luck += 0.01f;
            player.moveSpeed += 0.01f;
		}
	}
}