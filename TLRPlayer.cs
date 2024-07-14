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
using System.Collections;
using TLR.Content.Core.Items.Accessories.Combat.Defensive;
using log4net.Repository.Hierarchy;
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
        public bool CanSwitchGravity = false;
        public bool CanTPCursor = false;
        public int points = 0;
        public float pointGainMult = 0f;
        public int equippedGadget = 0;
        public override void ResetEffects()
        {
            hallowGlove = false;
            cyberScope = false;
            healPotionAdd = 0;
            manaPotionAdd = 0;
            CanSwitchGravity = false;
            CanTPCursor = false;
            pointGainMult = 0f;
            equippedGadget = 0;
        }
        public override void LoadData(TagCompound tag) {
			points = tag.GetInt("points");
		}

		public override void SaveData(TagCompound tag) {
		    tag["points"] = points;
		}
        public override void ProcessTriggers(TriggersSet triggersSet)
        {
            if (TLRKeybinds.UseGadget.JustPressed) {
                switch(equippedGadget) {
                    default:
                        break;
                }
            }
        }
        public override void ModifyHitNPC(NPC target, ref NPC.HitModifiers modifiers)
        {
            if (cyberScope && modifiers.DamageType.CountsAsClass(DamageClass.Ranged)) { modifiers.CritDamage += 0.25f; }
        }
        public override void OnHitNPCWithItem(Item item, NPC target, NPC.HitInfo hit, int damageDone)
        {
            if (item.DamageType.CountsAsClass(DamageClass.Melee))
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
        public override void OnHitNPCWithProj(Projectile proj, NPC target, NPC.HitInfo hit, int damageDone)
        {
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
    }
}