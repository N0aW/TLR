using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TLR.Content.Brawl.Items.Accessories.Gears
{ 
	// This is a basic item template.
	// Please see tModLoader's ExampleMod for every other example:
	// https://github.com/tModLoader/tModLoader/tree/stable/ExampleMod
	public class DamageGear : ModItem
	{
        // The Display Name and Tooltip of this item can be edited in the 'Localization/en-US_Mods.TLR.hjson' file.
        public override bool CanEquipAccessory(Player player, int slot, bool modded)
        {
            return slot == ModContent.GetInstance<Slots.GearSlot>().Type;
        }
        public override void SetDefaults()
		{
			Item.width = 32;
			Item.height = 32;
			Item.value = Item.sellPrice(gold: 3);
			Item.rare = ModContent.GetInstance<Rarities.Gear>().Type;
			Item.ResearchUnlockCount = 1;
			Item.maxStack = 1;
			Item.accessory = true;
		}
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            if (player.statLife / player.statLifeMax2 <= 0.5) { player.GetDamage(DamageClass.Generic) += 0.15f; }
        }
        public override void UpdateVanity(Player player)
        {
            if (player.statLife / player.statLifeMax2 <= 0.5) { player.GetDamage(DamageClass.Generic) += 0.15f; }
        }
        public override void AddRecipes()
		{
		}
	}
}
