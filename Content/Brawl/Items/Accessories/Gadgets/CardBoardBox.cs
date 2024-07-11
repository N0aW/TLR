using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TLR.Content.Brawl.Items.Accessories.Gadgets
{ 
	// This is a basic item template.
	// Please see tModLoader's ExampleMod for every other example:
	// https://github.com/tModLoader/tModLoader/tree/stable/ExampleMod
	public class CardboardBox : ModItem
	{
        // The Display Name and Tooltip of this item can be edited in the 'Localization/en-US_Mods.TLR.hjson' file.
        public override bool CanEquipAccessory(Player player, int slot, bool modded)
        {
            return slot == ModContent.GetInstance<Slots.GadgetSlot>().Type;
        }
        public override void SetDefaults()
		{
			Item.width = 32;
			Item.height = 32;
			Item.value = Item.sellPrice(gold: 5);
			Item.rare = ModContent.GetInstance<Rarities.Gadget>().Type;
			Item.ResearchUnlockCount = 1;
			Item.maxStack = 1;
			Item.accessory = true;
		}
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetModPlayer<TLRPlayer>().equippedGadget = 1;
        }

        public override void AddRecipes()
		{
		}
	}
}
