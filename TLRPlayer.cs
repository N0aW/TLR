using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using TLR.Content.Core.Buffs;
namespace TLR
{
    public class TLRPlayer : ModPlayer
    {
        public bool hallowGlove = false;
        public bool hallowGloveCD = false;
        public override void ResetEffects()
        {
            hallowGlove = false;
            hallowGloveCD = false;
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
    }
}