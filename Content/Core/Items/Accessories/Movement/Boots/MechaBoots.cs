using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TLR.Content.Core.Items.Accessories.Movement.Boots
{ 
	// This is a basic item template.
	// Please see tModLoader's ExampleMod for every other example:
	// https://github.com/tModLoader/tModLoader/tree/stable/ExampleMod
    [AutoloadEquip(EquipType.Shoes, EquipType.Wings)]
	public class MechaBoots : ModItem
	{
        // The Display Name and Tooltip of this item can be edited in the 'Localization/en-US_Mods.TLR.hjson' file.
        public override bool IsLoadingEnabled(Mod mod) => ModContent.GetInstance<TLRConfigServer>().Spriteless >= 1;
        public override void SetDefaults()
		{
            Item.CloneDefaults(ItemID.Jetpack);
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
            player.moveSpeed += 0.16f;
            player.vanityRocketBoots = player.rocketBoots = 4;
            player.iceSkate = true;
            player.waterWalk = true;
            player.waterWalk2 = true;
            player.fireWalk = true;
            player.lavaMax += 600;
			player.accFlipper = true;
			player.accDivingHelm = true;
			player.arcticDivingGear = true;
			player.endurance += 0.04f;
        }

        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.TerrasparkBoots);
            recipe.AddIngredient(ItemID.Jetpack);
			recipe.AddIngredient(ItemID.SoulofFright, 10);
            recipe.AddIngredient(ItemID.SoulofFlight, 20);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.Register();
		}
	}
}
