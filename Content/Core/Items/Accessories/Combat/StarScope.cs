using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TLR.Content.Core.Items.Accessories.Combat
{ 
	// This is a basic item template.
	// Please see tModLoader's ExampleMod for every other example:
	// https://github.com/tModLoader/tModLoader/tree/stable/ExampleMod
	public class StarScope : ModItem
	{
		// The Display Name and Tooltip of this item can be edited in the 'Localization/en-US_Mods.TLR.hjson' file.
		public override void SetDefaults()
		{
			Item.width = 36;
			Item.height = 36;
			Item.value = Item.sellPrice(gold: 40);
			Item.rare = ItemRarityID.Red;
			Item.accessory = true;
			Item.ResearchUnlockCount = 1;
			Item.maxStack = 1;
		}
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.hasMoltenQuiver = true;
			if (player.HeldItem.useAmmo == AmmoID.Arrow) {
				player.magicQuiver = true;
			}
			else {
				player.ammoCost80 = true;
			}
			if (player.HeldItem.DamageType == DamageClass.Ranged) {
				player.scope = true;
			}
			player.GetDamage(DamageClass.Ranged) += 20 / 100;
			player.GetDamage(DamageClass.Magic) += 20 / 100;
			player.GetCritChance(DamageClass.Ranged) += 20;
			player.GetCritChance(DamageClass.Magic) += 20;
			player.aggro -= 800;
			player.manaFlower = true;
            player.manaCost -= 0.20f;
			player.statManaMax2 += 100;
            player.magicCuffs = true;
            player.manaMagnet = true;
            player.starCloakItem = Item;
            player.starCloakItem_manaCloakOverrideItem = Item;
        }

        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ModContent.ItemType<Ranged.CyberScope>());
			recipe.AddIngredient(ModContent.ItemType<Magic.Manamaster>());
			recipe.AddIngredient(ItemID.FallenStar, 35);
			recipe.AddIngredient(ItemID.FragmentVortex, 12);
			recipe.AddIngredient(ItemID.FragmentNebula, 12);
            recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.Register();
		}
	}
}
