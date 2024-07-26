using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TLR.Content.Core.Items.Accessories.Combat.Ranged
{ 
	public class CyberScope : ModItem
	{
		public override void SetDefaults()
		{
			Item.width = 30;
			Item.height = 30;
			Item.value = Item.sellPrice(gold: 15);
			Item.rare = ItemRarityID.Yellow;
			Item.accessory = true;
			Item.ResearchUnlockCount = 1;
			Item.maxStack = 1;
		}
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.hasMoltenQuiver = true;
			player.magicQuiver = true;
			if (player.HeldItem.DamageType.CountsAsClass(DamageClass.Ranged) && ModContent.GetInstance<TLRConfigClient>().AllScope) {
				player.scope = true;
			}
			if (player.HeldItem.DamageType.CountsAsClass(DamageClass.Ranged) && player.HeldItem.useAmmo == AmmoID.Bullet && !ModContent.GetInstance<TLRConfigClient>().AllScope) {
				player.scope = true;
			}
			player.GetDamage(DamageClass.Ranged) += 0.10f;
			player.GetCritChance(DamageClass.Ranged) += 10;
			player.aggro -= 400;
			player.AddBuff(BuffID.AmmoBox, 1);
			player.GetModPlayer<TLRPlayer>().cyberScope = true;
        }

        public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.ReconScope)
				.AddIngredient(ItemID.MoltenQuiver)
				.AddIngredient(ItemID.AmmoBox)
				.AddIngredient(ItemID.AmmoBox)
				.AddTile(TileID.TinkerersWorkbench)
				.Register();
		}
	}
}
