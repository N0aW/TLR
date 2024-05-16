using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;

namespace TLR.Content.Core.Buffs
{
	public class BlessingCooldown : ModBuff
	{
        public override void SetStaticDefaults()
        {
            Main.debuff[Type] = true;
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
			BuffID.Sets.LongerExpertDebuff[Type] = false;
        }
		public override void Update(Player player, ref int buffIndex) {
			player.GetModPlayer<TLRPlayer>().hallowGloveCD = true;
		}
	}
}