using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.UI;
using System.Net;
using TLR.Content.Core.Currencies;

namespace TLR
{
	// Please read https://github.com/tModLoader/tModLoader/wiki/Basic-tModLoader-Modding-Guide#mod-skeleton-contents for more information about the various files in a mod.
	public class TLR : Mod
	{
		public static int ForestEssenceId;
		public static int UndergroundEssenceId;
		public static int SnowEssenceId;
		public static int DesertEssenceId;
		public static int CorruptEssenceId;
		public static int CrimsonEssenceId;
		public static int DungeonEssenceId;
		public static int DungeonEssence2Id;
		public static int JungleEssenceId;
		public static int OceanEssenceId;
		public static int GlowshroomEssenceId;
		public static int HallowEssenceId;
		public static int UnderworldEssenceId;
		public override void Load() {
			// Registers a new custom currency
			/*
			ForestEssenceId = CustomCurrencyManager.RegisterCurrency(new ForestEssence(ModContent.ItemType<Content.Core.Items.Coins.ForestEssence>(), 9999L, "Forest Essence"));
			UndergroundEssenceId = CustomCurrencyManager.RegisterCurrency(new UndergroundEssence(ModContent.ItemType<Content.Core.Items.Coins.UndergroundEssence>(), 9999L, "Underground Essence"));
			SnowEssenceId = CustomCurrencyManager.RegisterCurrency(new SnowEssence(ModContent.ItemType<Content.Core.Items.Coins.SnowEssence>(), 9999L, "Snow Essence"));
			DesertEssenceId = CustomCurrencyManager.RegisterCurrency(new DesertEssence(ModContent.ItemType<Content.Core.Items.Coins.DesertEssence>(), 9999L, "Desert Essence"));
			CorruptEssenceId = CustomCurrencyManager.RegisterCurrency(new CorruptEssence(ModContent.ItemType<Content.Core.Items.Coins.CorruptEssence>(), 9999L, "Corrupt Essence"));
			CrimsonEssenceId = CustomCurrencyManager.RegisterCurrency(new CrimsonEssence(ModContent.ItemType<Content.Core.Items.Coins.SnowEssence>(), 9999L, "Crimson Essence"));
			DungeonEssenceId = CustomCurrencyManager.RegisterCurrency(new DungeonEssence(ModContent.ItemType<Content.Core.Items.Coins.DungeonEssence>(), 9999L, "Dungeon Essence"));
			DungeonEssence2Id = CustomCurrencyManager.RegisterCurrency(new DungeonEssence2(ModContent.ItemType<Content.Core.Items.Coins.DungeonEssence2>(), 9999L, "Strong Dungeon Essence"));
			JungleEssenceId = CustomCurrencyManager.RegisterCurrency(new JungleEssence(ModContent.ItemType<Content.Core.Items.Coins.JungleEssence>(), 9999L, "Jungle Essence"));
			OceanEssenceId = CustomCurrencyManager.RegisterCurrency(new OceanEssence(ModContent.ItemType<Content.Core.Items.Coins.OceanEssence>(), 9999L, "Ocean Essence"));
			GlowshroomEssenceId = CustomCurrencyManager.RegisterCurrency(new GlowshroomEssence(ModContent.ItemType<Content.Core.Items.Coins.GlowshroomEssence>(), 9999L, "Glowing Mushroom Essence"));
			HallowEssenceId = CustomCurrencyManager.RegisterCurrency(new HallowEssence(ModContent.ItemType<Content.Core.Items.Coins.HallowEssence>(), 9999L, "Hallow Essence"));
			UnderworldEssenceId = CustomCurrencyManager.RegisterCurrency(new UnderworldEssence(ModContent.ItemType<Content.Core.Items.Coins.UnderworldEssence>(), 9999L, "Underworld Essence"));
			*/
		}
    }
}
