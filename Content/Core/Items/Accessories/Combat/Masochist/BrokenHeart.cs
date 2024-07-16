using System.Drawing;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using TLR.Content.Core.Classes;

namespace TLR.Content.Core.Items.Accessories.Combat.Masochist
{ 
	public class BrokenHeart : ModItem
	{
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
            player.GetDamage(DamageClass.Generic) += 0.2f;
            player.GetDamage(ModContent.GetInstance<MasochistGeneric>()) += 0.15f;
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
