using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TLR.Content.Brawl.Slots
{

	public class GadgetSlot : ModAccessorySlot
	{
		public override bool CanAcceptItem(Item checkItem, AccessorySlotType context) {
			if (checkItem.dye > 0 || checkItem.rare == ModContent.GetInstance<Rarities.Gadget>().Type)
				return true;
			return false;
		}

		// Designates our slot to be a priority for putting wings in to. NOTE: use ItemLoader.CanEquipAccessory if aiming for restricting other slots from having wings!
		public override bool ModifyDefaultSwapSlot(Item item, int accSlotToSwapTo) {
			if (item.rare == ModContent.GetInstance<Rarities.Gadget>().Type) // If is Wing, then we want to prioritize it to go in to our slot.
				return true;
			return false;
		}
        public override bool DrawDyeSlot => true; public override bool DrawVanitySlot => true;
        public override bool IsEnabled() => Player.GetModPlayer<TLRPlayer>().brawlSlots;

		// Overrides the default behavior where a disabled accessory slot will allow retrieve items if it contains items
		public override bool IsVisibleWhenNotEnabled() {
			return false; // We set to false to just not display if not Enabled. NOTE: this does not affect behavior when mod is unloaded!
		}

		// Icon textures. Nominal image size is 32x32. Will be centered on the slot.
		public override string FunctionalTexture => "TLR/Content/Brawl/Items/Accessories/Gadgets/CardboardBox";
		public override string VanityTexture => "TLR/Content/Brawl/Items/Accessories/Gadgets/BoneInjector";

		// Can be used to modify stuff while the Mouse is hovering over the slot.
		public override void OnMouseHover(AccessorySlotType context) {
			// We will modify the hover text while an item is not in the slot, so that it says "Wings".
			switch (context) {
				case AccessorySlotType.FunctionalSlot:
					Main.hoverItemName = "Gadget";
					break;
				case AccessorySlotType.VanitySlot:
					Main.hoverItemName = "Quick-Swap Gadget";
					break;
				case AccessorySlotType.DyeSlot:
					Main.hoverItemName = "Dye";
					break;
			}
		}
	}
	public class GearSlot : ModAccessorySlot
	{
		public override bool CanAcceptItem(Item checkItem, AccessorySlotType context) {
			if (checkItem.dye > 0 || checkItem.rare == ModContent.GetInstance<Rarities.Gear>().Type || checkItem.rare == ModContent.GetInstance<Rarities.GearEpic>().Type || checkItem.rare == ModContent.GetInstance<Rarities.GearMythic>().Type)
				return true;
			return false;
		}

		// Designates our slot to be a priority for putting wings in to. NOTE: use ItemLoader.CanEquipAccessory if aiming for restricting other slots from having wings!
		public override bool ModifyDefaultSwapSlot(Item item, int accSlotToSwapTo) {
			if (item.rare == ModContent.GetInstance<Rarities.Gear>().Type || item.rare == ModContent.GetInstance<Rarities.GearEpic>().Type || item.rare == ModContent.GetInstance<Rarities.GearMythic>().Type) // If is Wing, then we want to prioritize it to go in to our slot.
				return true;
			return false;
		}
        public override bool DrawDyeSlot => true;
        public override bool DrawVanitySlot => true;
        public override bool IsEnabled() => Player.GetModPlayer<TLRPlayer>().brawlSlots;

		// Overrides the default behavior where a disabled accessory slot will allow retrieve items if it contains items
		public override bool IsVisibleWhenNotEnabled() {
			return false; // We set to false to just not display if not Enabled. NOTE: this does not affect behavior when mod is unloaded!
		}

		// Icon textures. Nominal image size is 32x32. Will be centered on the slot.
		public override string FunctionalTexture => "TLR/Content/Brawl/Items/Accessories/Gears/DamageGear";
		public override string VanityTexture => "TLR/Content/Brawl/Items/Accessories/Gears/HealthGear";

		// Can be used to modify stuff while the Mouse is hovering over the slot.
		public override void OnMouseHover(AccessorySlotType context) {
			// We will modify the hover text while an item is not in the slot, so that it says "Wings".
			switch (context) {
				case AccessorySlotType.FunctionalSlot:
					Main.hoverItemName = "Gear";
					break;
				case AccessorySlotType.VanitySlot:
					Main.hoverItemName = "Second Gear";
					break;
				case AccessorySlotType.DyeSlot:
					Main.hoverItemName = "Dye";
					break;
			}
		}
	}
	public class StarPowerSlot : ModAccessorySlot
	{
		public override bool CanAcceptItem(Item checkItem, AccessorySlotType context) {
			if (checkItem.dye > 0 || checkItem.rare == ModContent.GetInstance<Rarities.StarPower>().Type)
				return true;
			return false;
		}

		// Designates our slot to be a priority for putting wings in to. NOTE: use ItemLoader.CanEquipAccessory if aiming for restricting other slots from having wings!
		public override bool ModifyDefaultSwapSlot(Item item, int accSlotToSwapTo) {
			if (item.rare == ModContent.GetInstance<Rarities.StarPower>().Type) // If is Wing, then we want to prioritize it to go in to our slot.
				return true;
			return false;
		}
        public override bool DrawDyeSlot => true; public override bool DrawVanitySlot => true;
        public override bool IsEnabled() => Player.GetModPlayer<TLRPlayer>().brawlSlots;

		// Overrides the default behavior where a disabled accessory slot will allow retrieve items if it contains items
		public override bool IsVisibleWhenNotEnabled() {
			return false; // We set to false to just not display if not Enabled. NOTE: this does not affect behavior when mod is unloaded!
		}

		// Icon textures. Nominal image size is 32x32. Will be centered on the slot.
		public override string FunctionalTexture => "TLR/Content/Brawl/Items/Accessories/StarPowers/BullStar";
		public override string VanityTexture => "TLR/Content/Brawl/Items/Accessories/StarPowers/DaggerStar";

		// Can be used to modify stuff while the Mouse is hovering over the slot.
		public override void OnMouseHover(AccessorySlotType context) {
			// We will modify the hover text while an item is not in the slot, so that it says "Wings".
			switch (context) {
				case AccessorySlotType.FunctionalSlot:
					Main.hoverItemName = "Star Power";
					break;
				case AccessorySlotType.VanitySlot:
					Main.hoverItemName = "Quick-Swap Star Power";
					break;
				case AccessorySlotType.DyeSlot:
					Main.hoverItemName = "Dye";
					break;
			}
		}
	}
	public class HyperchargeSlot : ModAccessorySlot
	{
		public override bool CanAcceptItem(Item checkItem, AccessorySlotType context) {
			if (checkItem.dye > 0 || checkItem.rare == ModContent.GetInstance<Rarities.Hypercharge>().Type)
				return true;
			return false;
		}

		// Designates our slot to be a priority for putting wings in to. NOTE: use ItemLoader.CanEquipAccessory if aiming for restricting other slots from having wings!
		public override bool ModifyDefaultSwapSlot(Item item, int accSlotToSwapTo) {
			if (item.rare == ModContent.GetInstance<Rarities.Hypercharge>().Type) // If is Wing, then we want to prioritize it to go in to our slot.
				return true;
			return false;
		}
        public override bool DrawDyeSlot => true; public override bool DrawVanitySlot => true;
        public override bool IsEnabled() => Player.GetModPlayer<TLRPlayer>().brawlSlots;

		// Overrides the default behavior where a disabled accessory slot will allow retrieve items if it contains items
		public override bool IsVisibleWhenNotEnabled() {
			return false; // We set to false to just not display if not Enabled. NOTE: this does not affect behavior when mod is unloaded!
		}

		// Icon textures. Nominal image size is 32x32. Will be centered on the slot.
		public override string FunctionalTexture => "TLR/Content/Brawl/Items/Accessories/Hypercharges/BullHyper";
		public override string VanityTexture => "TLR/Content/Brawl/Items/Accessories/Hypercharges/DaggerHyper";

		// Can be used to modify stuff while the Mouse is hovering over the slot.
		public override void OnMouseHover(AccessorySlotType context) {
			// We will modify the hover text while an item is not in the slot, so that it says "Wings".
			switch (context) {
				case AccessorySlotType.FunctionalSlot:
					Main.hoverItemName = "Hypercharge";
					break;
				case AccessorySlotType.VanitySlot:
					Main.hoverItemName = "Quick-Swap Hypercharge";
					break;
				case AccessorySlotType.DyeSlot:
					Main.hoverItemName = "Dye";
					break;
			}
		}
	}
}