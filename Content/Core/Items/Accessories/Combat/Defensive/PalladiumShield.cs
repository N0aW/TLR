using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TLR.Content.Core.Items.Accessories.Combat.Defensive
{ 
    [AutoloadEquip(EquipType.Shield)]
	public class PalladiumShield : ModItem
	{
        public override void SetDefaults()
		{
			Item.width = 30;
			Item.height = 28;
			Item.value = Item.sellPrice(gold: 1, silver: 75);
			Item.rare = ItemRarityID.Green;
			Item.accessory = true;
			Item.ResearchUnlockCount = 1;
			Item.maxStack = 1;
            Item.defense = 1;
		}
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.accRunSpeed = 6f;
			if ((player.velocity.X >= 6 || player.velocity.X <= -6) && player.velocity.Y == 0) { // Around 30 mph.
				player.endurance = 0.3f;
				player.noKnockback = true;
			}
        }
	}
}