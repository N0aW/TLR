using System.Collections.Generic;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Achievements;
using Terraria.ID;
using Terraria.ModLoader;
using TLR.Content.Core.Classes.Sacrifical;

namespace TLR.Content.Core.Items.Weapons.Sacrifical.Melee.Imperfections
{ 
	// This is a basic item template.
	// Please see tModLoader's ExampleMod for every other example:
	// https://github.com/tModLoader/tModLoader/tree/stable/ExampleMod
	public class Hatred : ModItem
	{
        // The Display Name and Tooltip of this item can be edited in the 'Localization/en-US_Mods.TLR.hjson' file.
		public int lifeCost = 8;
		public bool usesLifeOnHit = true;
		public int totalLifeCost = 0;
        public override void SetDefaults()
		{
			Item.width = 40; Item.height = 54;
			Item.value = Item.sellPrice(0, 5, 0, 0); Item.rare = ItemRarityID.Green;
			Item.ResearchUnlockCount = 1; Item.maxStack = 1;
			Item.DamageType = ModContent.GetInstance<SacrificalMelee>();
			Item.damage = 28; Item.crit = 6; Item.knockBack = 5.5f;
			Item.useTime = 16; Item.useAnimation = 16;
			Item.useStyle = ItemUseStyleID.Swing; Item.UseSound = SoundID.Item1;
			// Uses 8 life on hit to grant Rage and Wrath for 5 seconds
		}
        public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
        {
			TLRItem tLRItem = ModContent.GetInstance<TLRItem>();
			TLRPlayer tLRPlayer = player.GetModPlayer<TLRPlayer>();
			player.statLife -= totalLifeCost = lifeCost * (int)tLRItem.healthCostMultiplier * tLRPlayer.lifeCostMult;
            player.AddBuff(BuffID.Wrath, 300); player.AddBuff(BuffID.Rage, 300);
        }
		public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
			Player player = Main.LocalPlayer;
			TLRItem tLRItem = ModContent.GetInstance<TLRItem>();
			TLRPlayer tLRPlayer = player.GetModPlayer<TLRPlayer>();
			totalLifeCost = lifeCost * (int)tLRItem.healthCostMultiplier * tLRPlayer.lifeCostMult;
            tooltips.Add(new(Mod, "Tooltip0", "Uses " + totalLifeCost + " life"));
        }
    }
}
