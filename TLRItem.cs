using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;
using Terraria;
using Terraria.DataStructures;
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
        public override bool IsLoadingEnabled(Mod mod) => ModContent.GetInstance<TLRConfigServer>().UselessOverhauls;
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
    public class GemOverhaul : GlobalItem
    {
        public override bool IsLoadingEnabled(Mod mod) => ModContent.GetInstance<TLRConfigServer>().LargeGemBuffs;
        public override void UpdateInventory(Item item, Player player)
        {
            if (item.type == ItemID.LargeAmethyst) { player.statDefense += 4; }
            if (item.type == ItemID.LargeTopaz) { player.GetCritChance(DamageClass.Generic) += 5; }
            if (item.type == ItemID.LargeSapphire) { player.moveSpeed += 0.08f; }
            if (item.type == ItemID.LargeEmerald) { player.statLifeMax2 += 20; player.lifeRegen += 1; }
            if (item.type == ItemID.LargeAmber) { player.luck += 0.04f; }
            if (item.type == ItemID.LargeRuby) { player.GetDamage(DamageClass.Generic) += 0.05f; }
            if (item.type == ItemID.LargeDiamond) { player.GetArmorPenetration(DamageClass.Generic) += 5; }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (item.type == ItemID.LargeAmethyst) { tooltips.Add(new(Mod, "Tooltip1", "Increases defense by 4 when in inventory")); }
            if (item.type == ItemID.LargeTopaz) { tooltips.Add(new(Mod, "Tooltip1", "Increases critical strike chance by 5% when in inventory")); }
            if (item.type == ItemID.LargeSapphire) { tooltips.Add(new(Mod, "Tooltip1", "Increases movement speed by 8% when in inventory")); }
            if (item.type == ItemID.LargeEmerald) { tooltips.Add(new(Mod, "Tooltip1", "Increases max life by 20 and life regen by 1 when in inventory")); }
            if (item.type == ItemID.LargeAmber) { tooltips.Add(new(Mod, "Tooltip1", "Increases player luck by 0.04")); }
            if (item.type == ItemID.LargeRuby) { tooltips.Add(new(Mod, "Tooltip1", "Increases damage by 5% when in inventory")); }
            if (item.type == ItemID.LargeDiamond) { tooltips.Add(new(Mod, "Tooltip1", "Increases armor penetration by 5 when in inventory")); }
        }
    }
}