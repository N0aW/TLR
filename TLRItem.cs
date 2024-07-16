using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TLR.Content.Core.Classes;

namespace TLR
{
	public class TLRItem : GlobalItem
	{
        public override void SetStaticDefaults()
        {
            ItemID.Sets.ShimmerTransformToItem[ItemID.CrystalBall] = ModContent.ItemType<Content.Core.Tiles.ShimmerBallItem>();
            ItemID.Sets.ShimmerTransformToItem[ItemID.CobaltShield] = ModContent.ItemType<Content.Core.Items.Accessories.Combat.Defensive.PalladiumShield>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<Content.Core.Items.Accessories.Combat.Defensive.PalladiumShield>()] = ItemID.CobaltShield;
        }
        public override void SetDefaults(Item entity)
        {
            if (entity.type == ItemID.Flymeal && ModContent.GetInstance<TLRConfigServer>().ItemReclassing) {
                entity.DamageType = ModContent.GetInstance<SadistMelee>();
            }
        }
    }
}