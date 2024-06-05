using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using TLR.Content.Core.Buffs;
using Terraria.DataStructures;
namespace TLR
{
    public class TLRPlayer : ModPlayer
    {
        public bool hallowGlove = false;
        public bool hallowGloveCD = false;
        public bool warGlove = false;
        public int healPotionAdd = 0;
        public int manaPotionAdd = 0;
        public override void ResetEffects()
        {
            hallowGlove = false;
            hallowGloveCD = false;
            warGlove = false;
            healPotionAdd = 0;
            manaPotionAdd = 0;
        }
        public override void OnHitNPCWithItem(Item item, NPC target, NPC.HitInfo hit, int damageDone)
        {
            if (item.DamageType == DamageClass.Melee && hallowGlove == true && hallowGloveCD == false)
            {
                Player.AddBuff(ModContent.BuffType<BlessedDefense>(), 300, true, false);
            }
        }
        public override void OnHitNPCWithProj(Projectile proj, NPC target, NPC.HitInfo hit, int damageDone)
        {
            if (proj.DamageType == DamageClass.Melee && hallowGlove == true && hallowGloveCD == false)
            {
                Player.AddBuff(ModContent.BuffType<BlessedDefense>(), 300, true, false);
            }
        }
        public override void OnHitByNPC(NPC npc, Player.HurtInfo hurtInfo)
        {
            if (Player.HasBuff(ModContent.BuffType<BlessedDefense>()))
            {
                Player.AddBuff(ModContent.BuffType<BlessingCooldown>(), 600, true, false);
                Player.ClearBuff(ModContent.BuffType<BlessedDefense>());
            }
        }
        public override bool PreKill(double damage, int hitDirection, bool pvp, ref bool playSound, ref bool genDust, ref PlayerDeathReason damageSource)
        {
            if (ModLoader.TryGetMod("SOTS", out Mod SOTS)) {
                if (warGlove == true) {
                    return false;
                }
                else {
                    return true;
                }
            }
            return true;
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