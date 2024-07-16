using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using TLR.Content.Core.Buffs;
namespace TLR
{
    public class TLRPlayer : ModPlayer
    {
        public static TLRPlayer ModPlayer(Player player) {
			return player.GetModPlayer<TLRPlayer>();
		}
        public bool hallowGlove = false;
        public bool cyberScope = false;
        public int healPotionAdd = 0;
        public int manaPotionAdd = 0;
        public bool brokenHeart = false;
        public override void ResetEffects()
        {
            hallowGlove = false;
            cyberScope = false;
            healPotionAdd = 0;
            manaPotionAdd = 0;
            brokenHeart = false;
        }
        public override void ModifyHitNPC(NPC target, ref NPC.HitModifiers modifiers)
        {
            if (cyberScope && modifiers.DamageType.CountsAsClass(DamageClass.Ranged)) { modifiers.CritDamage += 0.25f; }
        }
        public override void OnHitNPCWithItem(Item item, NPC target, NPC.HitInfo hit, int damageDone)
        {
            if (brokenHeart) { Player.statLife += 10; }
            if (item.DamageType.CountsAsClass(DamageClass.Melee))
            {
                if (hallowGlove && hit.Crit) {
                    if ((target.life / target.lifeMax) <= 0.15) {
                        target.life = 0;
                    }
                    else {
                        target.AddBuff(ModContent.BuffType<BrokenBlessing>(), 600, false);
                    }
                }
            }
        }
        public override void OnHitNPCWithProj(Projectile proj, NPC target, NPC.HitInfo hit, int damageDone)
        {
            if (brokenHeart) { Player.statLife += 10; }
            if (proj.DamageType.CountsAsClass(DamageClass.Melee))
            {
                if (hallowGlove && hit.Crit) {
                    if ((target.life / target.lifeMax) <= 0.1) {
                        target.life = 0;
                    }
                    else {
                        target.AddBuff(ModContent.BuffType<BrokenBlessing>(), 300, false);
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
        public override void PostUpdate()
        {
            if (brokenHeart) { Player.statLife -= 1; }
        }
    }
}