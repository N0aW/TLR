using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TLR.Content.Core.Items.Accessories.Combat.Defensive;
using TLR.Content.Core.Tiles;

namespace TLR
{
	public class TLRItem : GlobalItem
	{
        public override void SetStaticDefaults()
        {
            ItemID.Sets.ShimmerTransformToItem[ItemID.CrystalBall] = ModContent.ItemType<ShimmerBallItem>();
            ItemID.Sets.ShimmerTransformToItem[ItemID.CobaltShield] = ModContent.ItemType<PalladiumShield>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<PalladiumShield>()] = ItemID.CobaltShield;
        }
    }
}