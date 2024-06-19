using Microsoft.Xna.Framework;
using Terraria.GameContent.UI;

namespace TLR.Content.Core.Currencies
{
	public class ForestEssence : CustomCurrencySingleCoin
	{
		public ForestEssence(int coinItemID, long currencyCap, string CurrencyTextKey) : base(coinItemID, currencyCap) {
			this.CurrencyTextKey = CurrencyTextKey;
			CurrencyTextColor = Color.LightGreen;
		}
	}
    public class SnowEssence : CustomCurrencySingleCoin
	{
		public SnowEssence(int coinItemID, long currencyCap, string CurrencyTextKey) : base(coinItemID, currencyCap) {
			this.CurrencyTextKey = CurrencyTextKey;
			CurrencyTextColor = Color.LightBlue;
		}
	}
    public class DesertEssence : CustomCurrencySingleCoin
	{
		public DesertEssence(int coinItemID, long currencyCap, string CurrencyTextKey) : base(coinItemID, currencyCap) {
			this.CurrencyTextKey = CurrencyTextKey;
			CurrencyTextColor = Color.LightYellow;
		}
	}
    public class CorruptEssence : CustomCurrencySingleCoin
	{
		public CorruptEssence(int coinItemID, long currencyCap, string CurrencyTextKey) : base(coinItemID, currencyCap) {
			this.CurrencyTextKey = CurrencyTextKey;
			CurrencyTextColor = Color.Purple;
		}
	}
    public class CrimsonEssence : CustomCurrencySingleCoin
	{
		public CrimsonEssence(int coinItemID, long currencyCap, string CurrencyTextKey) : base(coinItemID, currencyCap) {
			this.CurrencyTextKey = CurrencyTextKey;
			CurrencyTextColor = Color.Red;
		}
	}
    public class DungeonEssence : CustomCurrencySingleCoin
	{
		public DungeonEssence(int coinItemID, long currencyCap, string CurrencyTextKey) : base(coinItemID, currencyCap) {
			this.CurrencyTextKey = CurrencyTextKey;
			CurrencyTextColor = Color.LightGray;
		}
	}
    public class DungeonEssence2 : CustomCurrencySingleCoin
	{
		public DungeonEssence2(int coinItemID, long currencyCap, string CurrencyTextKey) : base(coinItemID, currencyCap) {
			this.CurrencyTextKey = CurrencyTextKey;
			CurrencyTextColor = Color.Gray;
		}
	}
    public class JungleEssence : CustomCurrencySingleCoin
	{
		public JungleEssence(int coinItemID, long currencyCap, string CurrencyTextKey) : base(coinItemID, currencyCap) {
			this.CurrencyTextKey = CurrencyTextKey;
			CurrencyTextColor = Color.Green;
		}
	}
    public class OceanEssence : CustomCurrencySingleCoin
	{
		public OceanEssence(int coinItemID, long currencyCap, string CurrencyTextKey) : base(coinItemID, currencyCap) {
			this.CurrencyTextKey = CurrencyTextKey;
			CurrencyTextColor = Color.SkyBlue;
		}
	}
    public class GlowshroomEssence : CustomCurrencySingleCoin
	{
		public GlowshroomEssence(int coinItemID, long currencyCap, string CurrencyTextKey) : base(coinItemID, currencyCap) {
			this.CurrencyTextKey = CurrencyTextKey;
			CurrencyTextColor = Color.Blue;
		}
	}
    public class HallowEssence : CustomCurrencySingleCoin
	{
		public HallowEssence(int coinItemID, long currencyCap, string CurrencyTextKey) : base(coinItemID, currencyCap) {
			this.CurrencyTextKey = CurrencyTextKey;
			CurrencyTextColor = Color.LightYellow;
		}
	}
    public class UnderworldEssence : CustomCurrencySingleCoin
	{
		public UnderworldEssence(int coinItemID, long currencyCap, string CurrencyTextKey) : base(coinItemID, currencyCap) {
			this.CurrencyTextKey = CurrencyTextKey;
			CurrencyTextColor = Color.OrangeRed;
		}
	}
}