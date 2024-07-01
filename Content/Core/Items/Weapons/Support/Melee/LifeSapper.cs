using System.Collections.Generic;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Achievements;
using Terraria.ID;
using Terraria.ModLoader;
using TLR.Content.Core.Classes.Sacrifical;
using TLR.Content.Core.Classes.Support;

namespace TLR.Content.Core.Items.Weapons.Support.Melee
{ 
	// This is a basic item template.
	// Please see tModLoader's ExampleMod for every other example:
	// https://github.com/tModLoader/tModLoader/tree/stable/ExampleMod
	public class LifeSapper : ModItem
	{
        // The Display Name and Tooltip of this item can be edited in the 'Localization/en-US_Mods.TLR.hjson' file
        public override void SetDefaults()
		{
			Item.width = 40; Item.height = 54;
			Item.value = Item.sellPrice(0, 5, 0, 0); Item.rare = ItemRarityID.Green;
			Item.ResearchUnlockCount = 1; Item.maxStack = 1;
			Item.DamageType = ModContent.GetInstance<SupportMelee>();
			Item.damage = 14; Item.crit = 0; Item.knockBack = 4.5f;
			Item.useTime = 16; Item.useAnimation = 16; Item.autoReuse = true;
			Item.useStyle = ItemUseStyleID.Swing; Item.UseSound = SoundID.Item1;
			// Heals you by 25% of the damage dealt
		}
        public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
        {
            player.Heal(damageDone / 4);
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.LightsBane);
			recipe.AddIngredient(ItemID.JungleSpores, 12);
			recipe.AddIngredient(ItemID.Stinger, 6);
			recipe.AddTile(TileID.Anvils);
			recipe.Register();
			Recipe recipe2 = CreateRecipe();
			recipe2.AddIngredient(ItemID.BloodButcherer);
			recipe2.AddIngredient(ItemID.JungleSpores, 12);
			recipe2.AddIngredient(ItemID.Stinger, 6);
			recipe2.AddTile(TileID.Anvils);
			recipe2.Register();
        }
    }
}
