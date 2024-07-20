using System.Drawing;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TLR.Content.Core.Items.Accessories.Movement.Boots
{
	[AutoloadEquip(EquipType.Shoes)]
	public class StellarStreads : ModItem
	{
        public override void SetDefaults()
		{
			Item.width = 32;
			Item.height = 28;
			Item.value = Item.sellPrice(gold: 25);
			Item.rare = ItemRarityID.Expert;
            Item.expert = true;
			Item.accessory = true;
			Item.ResearchUnlockCount = 1;
			Item.maxStack = 1;
		}
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.accRunSpeed = 9f;
            player.moveSpeed += 0.20f;
            player.vanityRocketBoots = player.rocketBoots = 5;
            player.iceSkate = true;
            player.waterWalk = true;
            player.waterWalk2 = true;
            player.fireWalk = true;
            player.lavaMax += 60;
            player.lavaTime = player.lavaMax;
			player.accFlipper = true;
			player.accDivingHelm = true;
			player.arcticDivingGear = true;
            player.dashType = 1;
            player.spikedBoots = 2;
            player.blackBelt = true;
			player.frogLegJumpBoost = true;
			player.noFallDmg = true;
			player.autoJump = true;
            player.empressBrooch = true;
        }

        public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ModContent.ItemType<Shroomts>())
				.AddIngredient(ItemID.EmpressFlightBooster)
				.AddIngredient(ItemID.LunarBar, 10)
				.AddTile(TileID.TinkerersWorkbench)
				.Register();
		}
	}
}
