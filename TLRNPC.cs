using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.ItemDropRules;
namespace TLR
{
	public class TLRNPC : GlobalNPC
	{
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if (npc.type == NPCID.AngryBones) {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Content.Core.Items.Accessories.Combat.Defensive.PalladiumShield>(), 200, 1, 1));
            }
        }
    }
}