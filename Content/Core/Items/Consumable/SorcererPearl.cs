using Terraria;
using Terraria.GameContent.Achievements;
using Terraria.ID;
using Terraria.ModLoader;

namespace TLR.Content.Core.Items.Consumable
{ 
	// This is a basic item template.
	// Please see tModLoader's ExampleMod for every other example:
	// https://github.com/tModLoader/tModLoader/tree/stable/ExampleMod
	public class SorcererPearl : ModItem
	{
        // The Display Name and Tooltip of this item can be edited in the 'Localization/en-US_Mods.TLR.hjson' file.
        public override void SetDefaults()
		{
			Item.width = 30;
			Item.height = 28;
			Item.value = Item.buyPrice(platinum: 1);
			Item.rare = ItemRarityID.LightPurple;
			Item.ResearchUnlockCount = 1;
			Item.maxStack = 9999;
            Item.consumable = true;
		}
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetDamage(DamageClass.Generic) += 0.04f;
            player.noKnockback = true;
        }
	}
}
