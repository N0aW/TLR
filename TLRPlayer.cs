using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using TLR.Content.Core.Buffs;
using Terraria.DataStructures;
using Terraria.ModLoader.IO;
using Terraria.Social.Steam;
using System;
using System.Security.Policy;
using Terraria.GameInput;
namespace TLR
{
    public class TLRPlayer : ModPlayer
    {
        public static TLRPlayer ModPlayer(Player player) {
			return player.GetModPlayer<TLRPlayer>();
		}
        public bool hallowGlove = false;
        public bool spookyGlove = false;
        public int healPotionAdd = 0;
        public int manaPotionAdd = 0;
        public int style = 0;
        public int[] cookies = [0, 0, 0, 0, 0, 0, 0];
        // -, K, M, T, Qa, Qi
        // Regular, Thousand, Million, Billion, Trillion, Quadrillion, Quintillion
        public int cookieBaking = 0;
        // How many cookies are based per second
        public int cookieBakeProgress = 0;
        // Increases by 1, every tick
        // When at 60, cooks cookies
        public bool displayCookies = false;
        public bool displayStyle = false;
        public int lifeCostMult = 1;
        public bool CanSwitchGravity = false;
        public bool CanTPCursor = false;
        public float useCookieAmmoChance = 1f;
        public float styleGain = 1f;
        public float supportHealMult = 1f;
        public override void ResetEffects()
        {
            hallowGlove = false;
            spookyGlove = false;
            healPotionAdd = 0;
            manaPotionAdd = 0;
            lifeCostMult = 1;
            cookieBaking = 0;
            displayCookies = false;
            displayStyle = false;
            CanSwitchGravity = false;
            CanTPCursor = false;
            useCookieAmmoChance = 1f;
            styleGain = 1f;
            supportHealMult = 1f;
        }
        public override void LoadData(TagCompound tag) {
			cookies = tag.GetIntArray("cookies");
            style = tag.GetInt("style");
		}

		public override void SaveData(TagCompound tag) {
			tag["cookies"] = cookies;
            tag["style"] = style;
		}
        public override void ProcessTriggers(TriggersSet triggersSet)
        {
        }
        public override void PostUpdate()
        {
            cookieBakeProgress += 1;
            if (cookieBakeProgress >= 60) {
                cookies[0] += cookieBaking;
                cookieBakeProgress -= 60;
            }
            if (cookies[0] > 1000) {
                cookies[1] += 1;
                cookies[0] -= 1000;
            }
            if (cookies[1] > 1000) {
                cookies[2] += 1;
                cookies[1] -= 1000;
            }
            if (cookies[2] > 1000) {
                cookies[3] += 1;
                cookies[2] -= 1000;
            }
            if (cookies[3] > 1000) {
                cookies[4] += 1;
                cookies[3] -= 1000;
            }
            if (cookies[4] > 1000) {
                cookies[5] += 1;
                cookies[4] -= 1000;
            }
            if (cookies[5] > 1000) {
                cookies[6] += 1;
                cookies[5] -= 1000;
            }
        }
        public override void PreUpdate()
        {
            if (cookies[0] < 0 && cookies[1] > 0) {
                cookies[1] -= 1;
                cookies[0] += 1000;
            }
            if (cookies[1] < 0 && cookies[2] > 0) {
                cookies[2] -= 1;
                cookies[1] += 1000;
            }
            if (cookies[2] < 0 && cookies[3] > 0) {
                cookies[3] -= 1;
                cookies[2] += 1000;
            }
            if (cookies[3] < 0 && cookies[4] > 0) {
                cookies[4] -= 1;
                cookies[3] += 1000;
            }
            if (cookies[4] < 0 && cookies[5] > 0) {
                cookies[5] -= 1;
                cookies[4] += 1000;
            }
            if (cookies[5] < 0 && cookies[6] > 0) {
                cookies[6] -= 1;
                cookies[5] += 1000;
            }
        }
        public override void OnHitNPCWithItem(Item item, NPC target, NPC.HitInfo hit, int damageDone)
        {
            style += (int)(2 * styleGain);
            if (item.DamageType.CountsAsClass(DamageClass.Melee))
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
            style += (int)(1 * styleGain);
            if (proj.DamageType.CountsAsClass(DamageClass.Melee))
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
        public override void OnHitByNPC(NPC npc, Player.HurtInfo hurtInfo)
        {
            style -= (int)(5 / styleGain);
        }
        public override void OnHitByProjectile(Projectile proj, Player.HurtInfo hurtInfo)
        {
            style -= (int)(2 / styleGain);
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
        public override bool PreKill(double damage, int hitDirection, bool pvp, ref bool playSound, ref bool genDust, ref PlayerDeathReason damageSource)
        {
            style -= (int)(1000 / styleGain);
            return true;
        }
    }
}