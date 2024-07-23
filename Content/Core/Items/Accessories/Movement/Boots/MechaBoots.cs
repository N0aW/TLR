using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TLR.Content.Core.Items.Accessories.Movement.Boots
{ 
    [AutoloadEquip(EquipType.Shoes)]
	public class MechaBoots : ModItem
	{
        public override void SetDefaults()
		{
			Item.width = 32;
			Item.height = 32;
			Item.value = Item.sellPrice(gold: 20);
			Item.rare = ItemRarityID.Yellow;
			Item.accessory = true;
			Item.ResearchUnlockCount = 1;
			Item.maxStack = 1;
		}
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.accRunSpeed = 7f;
            player.moveSpeed += 0.12f;
            player.vanityRocketBoots = player.rocketBoots = 4;
            player.iceSkate = true;
            player.waterWalk = true;
            player.waterWalk2 = true;
            player.fireWalk = true;
            player.lavaMax += 600;
			player.accFlipper = true;
			player.accDivingHelm = true;
			player.arcticDivingGear = true;
			player.frogLegJumpBoost = true;
			player.noFallDmg = true;
			player.autoJump = true;
			player.noKnockback = true;
        }

        public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.TerrasparkBoots)
				.AddIngredient(ItemID.AmphibianBoots)
				.AddIngredient(ItemID.AdamantiteBar, 18)
				.AddIngredient(ItemID.Cog, 75)
				.AddIngredient(ItemID.SoulofFlight, 10)
				.AddTile(TileID.TinkerersWorkbench)
				.Register();
			CreateRecipe()
				.AddIngredient(ItemID.TerrasparkBoots)
				.AddIngredient(ItemID.AmphibianBoots)
				.AddIngredient(ItemID.TitaniumBar, 18)
				.AddIngredient(ItemID.Cog, 75)
				.AddIngredient(ItemID.SoulofFlight, 10)
				.AddTile(TileID.TinkerersWorkbench)
				.Register();
		}
	}
}
