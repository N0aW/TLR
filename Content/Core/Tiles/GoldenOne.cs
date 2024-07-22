using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;
using TLR.Content.Core.Buffs;

namespace TLR.Content.Core.Tiles
{
    public class GoldenOneItem : ModItem
	{
		public override void SetDefaults() {
			Item.DefaultToPlaceableTile(ModContent.TileType<GoldenOneTile>());
            Item.SetShopValues(Terraria.Enums.ItemRarityColor.LightPurple6, Item.sellPrice(0, 0, 0, 60));
            Item.ResearchUnlockCount = 1;
            Item.accessory = true;
            Item.maxStack = 1;
		}
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.AddBuff(ModContent.BuffType<TheBigOne>(), 1);
        }
    }
	public class GoldenOneTile : ModTile
	{
		public override void SetStaticDefaults() {
			Main.tileSolid[Type] = false;
			Main.tileLavaDeath[Type] = false;
			Main.tileFrameImportant[Type] = true;

			TileObjectData.newTile.CopyFrom(TileObjectData.Style2xX);
			TileObjectData.newTile.CoordinateHeights = new[] { 16, 16, 16 };
			TileObjectData.addTile(Type);
            
            LocalizedText name = CreateMapEntryName();
			AddMapEntry(new Color(143, 145, 0), name);

			DustType = 84;
		}
        public override void NearbyEffects(int i, int j, bool closer)
        {
            Main.LocalPlayer.AddBuff(ModContent.BuffType<TheBigOne>(), 60);
        }
        public override void NumDust(int i, int j, bool fail, ref int num) {
			num = fail ? 1 : 3;
		}
	}
}