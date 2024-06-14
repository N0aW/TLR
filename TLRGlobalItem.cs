using System.Collections.Generic;
using Mono.CompilerServices.SymbolWriter;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.GameContent.Events;
using Terraria.GameContent.UI.Chat;
using Terraria.ID;
using Terraria.ModLoader;
using tModPorter;

namespace TLR
{
	// This file shows a very simple example of a GlobalItem class. GlobalItem hooks are called on all items in the game and are suitable for sweeping changes like 
	// adding additional data to all items in the game. Here we simply adjust the damage of the Copper Shortsword item, as it is simple to understand. 
	// See other GlobalItem classes in ExampleMod to see other ways that GlobalItem can be used.
	public class TLRGlobalItem : GlobalItem
	{
        public override void SetStaticDefaults()
        {
            ItemID.Sets.ShimmerTransformToItem[ItemID.CrystalBall] = ModContent.ItemType<Content.Core.Tiles.ShimmerBallItem>();
            ItemID.Sets.ShimmerTransformToItem[ItemID.CobaltShield] = ModContent.ItemType<Content.Core.Items.Accessories.Combat.Defensive.PalladiumShield>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<Content.Core.Items.Accessories.Combat.Defensive.PalladiumShield>()] = ItemID.CobaltShield;
        }
        public override void UpdateAccessory(Item item, Player player, bool hideVisual)
        {
            if (item.type == ItemID.CobaltShield) {
                player.noKnockback = true;
                player.moveSpeed += 0.08f;
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (item.type == ItemID.CobaltShield) {
                tooltips.Add(new(Mod, "Tooltip1", "Increases movement speed by 8%"));
            }
            if (ModContent.GetInstance<TLRConfigClient>().ShimmerInfo != 0) {
                if (item.type == ItemID.CobaltShield) {
                    tooltips.Add(new(Mod, "Tooltip2", "[i:" + ModContent.ItemType<Content.Core.Items.Accessories.Combat.Defensive.PalladiumShield>() + "] Shimmers into Palladium Shield"));
                }
                if (item.type == ModContent.ItemType<Content.Core.Items.Accessories.Combat.Defensive.PalladiumShield>()) {
                    tooltips.Add(new(Mod, "Tooltip2", "[i:" + ItemID.CobaltShield + "] Shimmers into Cobalt Shield"));
                }
                if (item.type == ItemID.CrystalBall) {
                    tooltips.Add(new(Mod, "Tooltip0", "[i:" + ModContent.ItemType<Content.Core.Tiles.ShimmerBallItem>() + "] Shimmers into Shimmer Ball"));
                }
            }
        }
    }
}