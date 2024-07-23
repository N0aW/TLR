using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TLR.Content.Core.Classes.Cursor
{
    public class CursorGeneric : DamageClass
    {
        public override bool GetEffectInheritance(DamageClass damageClass) {
            if (damageClass == Generic) { return true; }
            return false;
        }
        public override StatInheritanceData GetModifierInheritance(DamageClass damageClass)
        {
            if (damageClass == Generic) { return StatInheritanceData.Full; }
            return StatInheritanceData.None;
        }
        public override bool ShowStatTooltipLine(Player player, string lineName) => true;
    }
}