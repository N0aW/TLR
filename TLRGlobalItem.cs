using Mono.CompilerServices.SymbolWriter;
using Terraria;
using Terraria.GameContent.Events;
using Terraria.GameContent.UI.Chat;
using Terraria.ID;
using Terraria.ModLoader;

namespace TLR
{
	// This file shows a very simple example of a GlobalItem class. GlobalItem hooks are called on all items in the game and are suitable for sweeping changes like 
	// adding additional data to all items in the game. Here we simply adjust the damage of the Copper Shortsword item, as it is simple to understand. 
	// See other GlobalItem classes in ExampleMod to see other ways that GlobalItem can be used.
	public class TLRGlobalItem : GlobalItem
	{
	}
	public class HolyGlobalItem : GlobalItem
	{
		public override void SetDefaults(Item item) {
			if (item.type == ItemID.HolyWater) {
				item.DamageType = ModContent.GetInstance<Content.Core.DamageClasses.Holy>();
			}
			if (item.type == ItemID.Excalibur || item.type == ItemID.TrueExcalibur || item.type == ItemID.PickaxeAxe || item.type == ItemID.Drax || item.type == ItemID.Pwnhammer ||
				item.type == ItemID.EnchantedSword || item.type == ItemID.PearlwoodSword || item.type == ItemID.PearlwoodHammer || item.type == ItemID.PiercingStarlight) {
				item.DamageType = ModContent.GetInstance<Content.Core.DamageClasses.HolyMelee>();
			}
			if (item.type == ItemID.Gungnir || item.type == ItemID.HallowJoustingLance || item.type == ItemID.LightDisc) {
				item.DamageType = ModContent.GetInstance<Content.Core.DamageClasses.HolyMeleeNoSpeed>();
			}
            if (item.type == ItemID.HallowedRepeater || item.type == ItemID.SuperStarCannon || item.type == ItemID.FairyQueenRangedItem) {
				item.DamageType = ModContent.GetInstance<Content.Core.DamageClasses.HolyRanged>();
			}
			if (item.type == ItemID.RainbowRod || item.type == ItemID.CrystalStorm || item.type == ItemID.SkyFracture || item.type == ItemID.SparkleGuitar ||
				item.type == ItemID.CrystalSerpent || item.type == ItemID.PrincessWeapon) {
				item.DamageType = ModContent.GetInstance<Content.Core.DamageClasses.HolyMagic>();
			}
			if (item.type == ItemID.Smolstar || item.type == ItemID.EmpressBlade) {
				item.DamageType = ModContent.GetInstance<Content.Core.DamageClasses.HolySummon>();
			}
            if (item.type == ItemID.SwordWhip || item.type == ItemID.RainbowWhip) {
				item.DamageType = ModContent.GetInstance<Content.Core.DamageClasses.HolySummonWhip>();
			}
			if (item.type == ItemID.UnholyWater || item.type == ItemID.BloodWater) {
				item.DamageType = ModContent.GetInstance<Content.Core.DamageClasses.Unholy>();
			}
			if (item.type == ItemID.EbonwoodSword || item.type == ItemID.ShadewoodSword || item.type == ItemID.EbonwoodHammer || item.type == ItemID.ShadewoodHammer ||
				item.type == ItemID.LightsBane || item.type == ItemID.BloodButcherer || item.type == ItemID.NightsEdge || item.type == ItemID.TrueNightsEdge ||
				item.type == ItemID.WarAxeoftheNight || item.type == ItemID.NightmarePickaxe || item.type == ItemID.TheBreaker || item.type == ItemID.DeathbringerPickaxe ||
				item.type == ItemID.BloodLustCluster || item.type == ItemID.FleshGrinder || item.type == ItemID.EoCShield || item.type == ItemID.TentacleSpike ||
				item.type == ItemID.Bladetongue || item.type == ItemID.FetidBaghnakhs || item.type == ItemID.PurpleClubberfish) {
				item.DamageType = ModContent.GetInstance<Content.Core.DamageClasses.UnholyMelee>();
			}
			if (item.type == ItemID.CorruptYoyo || item.type == ItemID.TheMeatball || item.type == ItemID.CrimsonYoyo || item.type == ItemID.TheRottedFork ||
				item.type == ItemID.ScourgeoftheCorruptor || item.type == ItemID.BallOHurt) {
				item.DamageType = ModContent.GetInstance<Content.Core.DamageClasses.UnholyMeleeNoSpeed>();
			}
			if (item.type == ItemID.EbonwoodBow || item.type == ItemID.ShadewoodBow || item.type == ItemID.DemonBow || item.type == ItemID.TendonBow ||
				item.type == ItemID.OnyxBlaster || item.type == ItemID.Musket || item.type == ItemID.TheUndertaker || item.type == ItemID.Toxikarp) {
				item.DamageType = ModContent.GetInstance<Content.Core.DamageClasses.UnholyRanged>();
			}
			if (item.type == ItemID.CursedFlames || item.type == ItemID.SpiritFlame || item.type == ItemID.Vilethorn || item.type == ItemID.CrimsonRod ||
				item.type == ItemID.ClingerStaff) {
				item.DamageType = ModContent.GetInstance<Content.Core.DamageClasses.UnholyMagic>();
			}
		}
	}
	public class SOTSHolyItem : GlobalItem {
        public override void SetDefaults(Item item) {
			if (ModLoader.TryGetMod("SOTS", out Mod SOTS)) {
				if (item.type == SOTS.Find<ModItem>("DeathSpiral").Type) {
					item.DamageType = ModContent.GetInstance<Content.Core.DamageClasses.UnholyMelee>();
				}
				if (item.type == SOTS.Find<ModItem>("AbyssalFury").Type) {
					item.DamageType = ModContent.GetInstance<Content.Core.DamageClasses.UnholyVoidMelee>();
				}
			}
		}
    }
}