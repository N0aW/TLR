using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TLR.Content.Core.Items.Accessories.Movement.Boots
{ 
    [AutoloadEquip(EquipType.Shoes)]
	public class Shroomts : ModItem
	{
        public override void SetDefaults()
		{
			Item.width = 32;
			Item.height = 28;
			Item.value = Item.sellPrice(gold: 20);
			Item.rare = ItemRarityID.Red;
			Item.accessory = true;
			Item.ResearchUnlockCount = 1;
			Item.maxStack = 1;
		}
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.accRunSpeed = 8f;
            player.moveSpeed += 0.16f;
            player.vanityRocketBoots = player.rocketBoots = 5;
            player.iceSkate = true;
            player.waterWalk = true;
            player.waterWalk2 = true;
            player.fireWalk = true;
            player.lavaMax += 600;
			player.accFlipper = true;
			player.accDivingHelm = true;
			player.arcticDivingGear = true;
            player.dashType = 1;
			player.frogLegJumpBoost = true;
			player.noFallDmg = true;
			player.autoJump = true;
			player.noKnockback = true;
        }

        public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ModContent.ItemType<MechaBoots>())
				.AddIngredient(ItemID.Tabi)
				.AddIngredient(ItemID.ShroomiteBar, 18)
				.AddTile(TileID.TinkerersWorkbench)
				.Register();
		}
	}
}
