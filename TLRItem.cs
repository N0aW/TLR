using System.Runtime.Serialization.Formatters;
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
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<ShimmerBallItem>()] = ItemID.CrystalBall;
            ItemID.Sets.ShimmerTransformToItem[ItemID.CobaltShield] = ModContent.ItemType<PalladiumShield>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<PalladiumShield>()] = ItemID.CobaltShield;
            ItemID.Sets.ShimmerTransformToItem[ItemID.AlphabetStatue1] = ModContent.ItemType<GoldenOneItem>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<GoldenOneItem>()] = ItemID.AlphabetStatue1;
        }
    }
    public class UselessOverhaulItem : GlobalItem
    {
        public override bool IsLoadingEnabled(Mod mod)
        {
            return ModContent.GetInstance<TLRConfigServer>().UselessOverhauls;
        }
        public override void SetDefaults(Item entity)
        {
            if (entity.type == ItemID.PearlwoodSword) { entity.damage = 34; entity.scale = 1.5f; }
            if (entity.type == ItemID.PearlwoodHammer) { entity.damage = 22; entity.hammer = 80; }
            if (entity.type == ItemID.PearlwoodBow) { entity.damage = 38; }
            if (entity.type == ItemID.PearlwoodHelmet) { entity.defense = 14; }
            if (entity.type == ItemID.PearlwoodBreastplate) { entity.defense = 18; }
            if (entity.type == ItemID.PearlwoodGreaves) { entity.defense = 14; }
        }
    }
}