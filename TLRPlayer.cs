using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using TLR.Content.Core.Buffs;
using Terraria.DataStructures;
using Terraria.ModLoader.IO;
using Terraria.Social.Steam;
namespace TLR
{
    public class TLRPlayer : ModPlayer
    {
        public bool hallowGlove = false;
        public bool spookyGlove = false;
        public int healPotionAdd = 0;
        public int manaPotionAdd = 0;
        public override void ResetEffects()
        {
            hallowGlove = false;
            spookyGlove = false;
            healPotionAdd = 0;
            manaPotionAdd = 0;
        }
        public override void OnHitNPCWithItem(Item item, NPC target, NPC.HitInfo hit, int damageDone)
        {
            if (item.DamageType == DamageClass.Melee)
            {
                if (hallowGlove && hit.Crit) {
                    if ((target.life / target.lifeMax) <= 0.1) {
                        target.life = 0;
                    }
                    else {
                        target.AddBuff(BuffID.BrokenArmor, 5, false);
                    }
                }
                if (spookyGlove && hit.Crit) {
                    if ((target.life / target.lifeMax) <= 0.1) {
                        Player.statLife += target.lifeMax / 5;
                        target.life = 0;
                    }
                    else {
                        Player.statLife += Player.statLifeMax2 / 20;
                        target.AddBuff(BuffID.BrokenArmor, 5, false);
                        target.AddBuff(BuffID.CursedInferno, 5, false);
                        target.AddBuff(BuffID.Ichor, 5, false);
                        target.AddBuff(BuffID.OnFire, 5, false);
                    }
                }
            }
        }
        public override void OnHitNPCWithProj(Projectile proj, NPC target, NPC.HitInfo hit, int damageDone)
        {
            if (proj.DamageType == DamageClass.Melee)
            {
                if (hallowGlove && hit.Crit) {
                    if ((target.life / target.lifeMax) <= 0.1) {
                        target.life = 0;
                    }
                    else {
                        target.AddBuff(BuffID.BrokenArmor, 5, false);
                    }
                }
                if (spookyGlove && hit.Crit) {
                    if ((target.life / target.lifeMax) <= 0.1) {
                        Player.statLife += target.lifeMax / 5;
                        target.life = 0;
                    }
                    else {
                        Player.statLife += Player.statLifeMax2 / 20;
                        target.AddBuff(BuffID.BrokenArmor, 5, false);
                        target.AddBuff(BuffID.CursedInferno, 5, false);
                        target.AddBuff(BuffID.Ichor, 5, false);
                        target.AddBuff(BuffID.OnFire, 5, false);
                    }
                }
            }
        }
        public override void GetHealLife(Item item, bool quickHeal, ref int healValue)
        {
            if (healValue > 0) {
                healValue += healPotionAdd;
            }
        }
        public override void GetHealMana(Item item, bool quickHeal, ref int healValue)
        {
            if (healValue > 0) {
                healValue += manaPotionAdd;
            }
		}
    }
}