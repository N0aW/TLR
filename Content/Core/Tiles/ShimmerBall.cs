using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace TLR.Content.Core.Tiles
{
    public class ShimmerBallItem : ModItem
	{
		public override void SetDefaults() {
			Item.DefaultToPlaceableTile(ModContent.TileType<ShimmerBallTile>());
            Item.SetShopValues(Terraria.Enums.ItemRarityColor.Pink5, Item.sellPrice(0, 2, 0, 0));
            Item.ResearchUnlockCount = 1;
		}
    }
	public class ShimmerBallTile : ModTile
	{
		public override void SetStaticDefaults() {
			Main.tileSolid[Type] = false;
			Main.tileLavaDeath[Type] = false;
			Main.tileFrameImportant[Type] = true;

			TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
			TileObjectData.newTile.CoordinateHeights = new[] { 16, 18 };
			TileObjectData.addTile(Type);
            
            LocalizedText name = CreateMapEntryName();
			AddMapEntry(new Color(246, 163, 255), name);

			DustType = 84;
			AdjTiles = [TileID.DemonAltar, TileID.CrystalBall];
		}
		public override void NumDust(int i, int j, bool fail, ref int num) {
			num = fail ? 1 : 3;
		}
	}
}