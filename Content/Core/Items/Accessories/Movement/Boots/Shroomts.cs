using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TLR.Content.Core.Items.Accessories.Movement.Boots
{ 
	// This is a basic item template.
	// Please see tModLoader's ExampleMod for every other example:
	// https://github.com/tModLoader/tModLoader/tree/stable/ExampleMod
    [AutoloadEquip(EquipType.Shoes, EquipType.Wings)]
	public class Shroomts : ModItem
	{
        // The Display Name and Tooltip of this item can be edited in the 'Localization/en-US_Mods.TLR.hjson' file.
        public override bool IsLoadingEnabled(Mod mod) => ModContent.GetInstance<TLRConfigServer>().Spriteless >= 1;
        public override void SetDefaults()
		{
            Item.CloneDefaults(ItemID.Hoverboard);
			Item.width = 32;
			Item.height = 28;
			Item.value = Item.sellPrice(gold: 25);
			Item.rare = ItemRarityID.Red;
			Item.accessory = true;
			Item.ResearchUnlockCount = 1;
			Item.maxStack = 1;
		}
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.accRunSpeed = 8f;
            player.moveSpeed += 0.33f;
            player.vanityRocketBoots = player.rocketBoots = 5;
            player.iceSkate = true;
            player.waterWalk = true;
            player.waterWalk2 = true;
            player.fireWalk = true;
            player.lavaMax += 900;
			player.accFlipper = true;
			player.accDivingHelm = true;
			player.arcticDivingGear = true;
            player.dashType = 1;
            player.spikedBoots = 2;
            player.blackBelt = true;
            player.endurance += 0.06f;
        }

        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ModContent.ItemType<MechaBoots>());
            recipe.AddIngredient(ItemID.Hoverboard);
			recipe.AddIngredient(ItemID.MasterNinjaGear);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.Register();
		}
	}
}
