using System.Runtime.CompilerServices;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameInput;

namespace TLR.Content.Core.Items.Accessories.Movement
{ 
	// This is a basic item template.
	// Please see tModLoader's ExampleMod for every other example:
	// https://github.com/tModLoader/tModLoader/tree/stable/ExampleMod
	[AutoloadEquip(EquipType.Shoes)]
	public class KungFuShoes : ModItem
	{
		// The Display Name and Tooltip of this item can be edited in the 'Localization/en-US_Mods.TLR.hjson' file.
		public override void SetDefaults()
		{
			Item.width = 34;
			Item.height = 32;
			Item.value = Item.sellPrice(gold: 30);
			Item.rare = ItemRarityID.Cyan;
			Item.accessory = true;
			Item.ResearchUnlockCount = 1;
			Item.maxStack = 1;
		}
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.accRunSpeed = 7f;
            player.rocketBoots = ArmorIDs.RocketBoots.TerrasparkBoots;
            player.vanityRocketBoots = ArmorIDs.RocketBoots.TerrasparkBoots;
            player.moveSpeed += 0.16f;
            player.iceSkate = true;
            player.lavaMax += 900;
            player.waterWalk = true;
            player.fireWalk = true;
            player.lavaRose = true;
            player.dashType = 1;
            player.blackBelt = true;
            player.noFallDmg = true;
            player.hasLuck_LuckyHorseshoe = true;
            player.spikedBoots = 2;
			player.accFlipper = true;
			player.frogLegJumpBoost = true;
			player.autoJump = true;
			if (PlayerInput.Triggers.Current.Jump) {
				player.slowFall = true;
			}
        }

        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ModContent.ItemType<AvatarBoots>());
			recipe.AddIngredient(ItemID.MasterNinjaGear);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.Register();
		}
	}
}
