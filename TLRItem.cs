using System.Collections.Generic;
using System.Drawing.Text;
using Microsoft.Xna.Framework;
using Mono.CompilerServices.SymbolWriter;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.GameContent.Events;
using Terraria.GameContent.UI.Chat;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;
using tModPorter;

namespace TLR
{
	// This file shows a very simple example of a GlobalItem class. GlobalItem hooks are called on all items in the game and are suitable for sweeping changes like 
	// adding additional data to all items in the game. Here we simply adjust the damage of the Copper Shortsword item, as it is simple to understand. 
	// See other GlobalItem classes in ExampleMod to see other ways that GlobalItem can be used.
	public class TLRItem : GlobalItem
	{
        public override void SetStaticDefaults()
        {
            ItemID.Sets.ShimmerTransformToItem[ItemID.CrystalBall] = ModContent.ItemType<Content.Core.Tiles.ShimmerBallItem>();
            ItemID.Sets.ShimmerTransformToItem[ItemID.CobaltShield] = ModContent.ItemType<Content.Core.Items.Accessories.Combat.Defensive.PalladiumShield>();
            ItemID.Sets.ShimmerTransformToItem[ModContent.ItemType<Content.Core.Items.Accessories.Combat.Defensive.PalladiumShield>()] = ItemID.CobaltShield;
        }
    }
}