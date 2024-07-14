using System.Drawing;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace TLR.Content.Core.Items.Accessories.Combat.Masochism
{ 
	// This is a basic item template.
	// Please see tModLoader's ExampleMod for every other example:
	// https://github.com/tModLoader/tModLoader/tree/stable/ExampleMod
	public class BrokenHeart : ModItem
	{
        // The Display Name and Tooltip of this item can be edited in the 'Localization/en-US_Mods.TLR.hjson' file.
        public override void SetDefaults()
		{
			Item.width = 30;
			Item.height = 28;
			Item.value = Item.sellPrice(gold: 1);
			Item.rare = ItemRarityID.Gray;
			Item.accessory = true;
			Item.ResearchUnlockCount = 1;
			Item.maxStack = 1;
            Item.color = Colors.RarityTrash;
		}
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetModPlayer<TLRPlayer>().brokenHeart = true;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.LifeCrystal)
                .AddTile(TileID.Anvils)
                .AddCondition(Language.GetOrRegister("Mods.TLR.Conditions.HoldHammer"), () => Main.LocalPlayer.HeldItem.hammer > 0)
                .Register();
        }
    }
}
