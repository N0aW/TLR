using System.Drawing;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TLR.Content.Core.Items.Accessories.Combat.Defensive
{ 
	// This is a basic item template.
	// Please see tModLoader's ExampleMod for every other example:
	// https://github.com/tModLoader/tModLoader/tree/stable/ExampleMod
    [AutoloadEquip(EquipType.Shield)]
	public class BalladShield : ModItem
	{
        // The Display Name and Tooltip of this item can be edited in the 'Localization/en-US_Mods.TLR.hjson' file.
        public override string Texture => "TLR/Content/Core/Items/Accessories/Combat/Defensive/PalladiumShield";
        public override bool IsLoadingEnabled(Mod mod) => ModContent.GetInstance<TLRConfigServer>().Spriteless >= 2;
        public override void SetDefaults()
		{
            Item.damage = 40;
            Item.knockBack = 10f;
            Item.DamageType = DamageClass.Melee;
			Item.width = 30;
			Item.height = 28;
			Item.value = Item.sellPrice(gold: 4);
			Item.rare = ItemRarityID.Expert;
            Item.expert = true;
			Item.accessory = true;
			Item.ResearchUnlockCount = 1;
			Item.maxStack = 1;
            Item.defense = 2;
            Item.color = Colors.RarityRed;
		}
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.accRunSpeed = 6.25f;
            player.dashType = 2;
            if ((player.velocity.X >= 6 || player.velocity.X <= -6) && player.velocity.Y == 0) {
				player.endurance = 0.3f;
				player.noKnockback = true;
			}
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<PalladiumShield>())
                .AddIngredient(ItemID.BouncingShield)
                .AddTile(TileID.TinkerersWorkbench)
                .Register();
        }
    }
}
