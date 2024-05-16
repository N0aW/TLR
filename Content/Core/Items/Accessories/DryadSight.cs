using System.Collections.Generic;
using Terraria;
using Terraria.GameContent.Personalities;
using Terraria.ID;
using Terraria.IO;
using Terraria.ModLoader;
using System.Linq;
using System.Data.SqlTypes;

namespace TLR.Content.Core.Items.Accessories
{ 
	// This is a basic item template.
	// Please see tModLoader's ExampleMod for every other example:
	// https://github.com/tModLoader/tModLoader/tree/stable/ExampleMod
	public class DryadSight : ModItem
	{
        // The Display Name and Tooltip of this item can be edited in the 'Localization/en-US_Mods.TLR.hjson' file.
        public override bool IsLoadingEnabled(Mod mod)
        {
            return false;
        }
        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            foreach (TooltipLine line in tooltips) //goes through each tooltip line
			{
                if (WorldGen.tEvil == 0 && WorldGen.tBlood == 0 && WorldGen.tGood == 0) {
                    if (line.Mod == "Terraria" && line.Name == "Tooltip3") //checks the name of the tootip line
				    {
                        line.Text = "The world is completely purified!";
                        return;
				    }
                    if (line.Mod == "Terraria" && line.Name == "Tooltip4") //checks the name of the tootip line
				    {
                        line.Text = "[c/32ff82:All damage increased by 50%]";
                        return;
				    }
                    if (line.Mod == "Terraria" && line.Name == "Tooltip5") //checks the name of the tootip line
				    {
                        line.Text = null;
                        return;
				    }
                    if (line.Mod == "Terraria" && line.Name == "Tooltip6") //checks the name of the tootip line
				    {
                        line.Text = null;
                        return;
				    }
                    if (line.Mod == "Terraria" && line.Name == "Tooltip7") //checks the name of the tootip line
				    {
                        line.Text = null;
                        return;
				    }
                }
                else {
                    if (line.Mod == "Terraria" && line.Name == "Tooltip3") //checks the name of the tootip line
				    {
                        line.Text = "The world is " + WorldGen.tEvil + "% corrupted.";
                        return;
				    }
                    if (line.Mod == "Terraria" && line.Name == "Tooltip4") //checks the name of the tootip line
				    {
                        line.Text = "The world is " + WorldGen.tBlood + "% crimson.";
                        return;
				    }
                    if (line.Mod == "Terraria" && line.Name == "Tooltip5") //checks the name of the tootip line
				    {
                        line.Text = "The world is " + WorldGen.tGood + "% hallowed.";
                        return;
				    }
                    if (line.Mod == "Terraria" && line.Name == "Tooltip6") //checks the name of the tootip line
				    {
                        line.Text = "[c/af4bff:Unholy damage increased by " + ((WorldGen.tEvil + WorldGen.tBlood) / 2) + "%]";
                        return;
				    }
                    if (line.Mod == "Terraria" && line.Name == "Tooltip7") //checks the name of the tootip line
				    {
                        line.Text = "[c/fddc5c:Holy damage increased by " + (WorldGen.tGood / 2) + "%]";
                        return;
				    }
                }
			}
        }
        public override void SetDefaults()
		{
			Item.width = 40;
			Item.height = 40;
			Item.value = Item.buyPrice(gold: 50);
			Item.rare = ItemRarityID.LightRed;
			Item.accessory = true;
			Item.ResearchUnlockCount = 1;
			Item.maxStack = 1;
		}
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            if (WorldGen.tEvil == 0 && WorldGen.tBlood == 0 && WorldGen.tGood == 0) {
                player.GetDamage(DamageClass.Generic) += 50 / 100f;
            }
            else {
                player.GetDamage(ModContent.GetInstance<DamageClasses.Unholy>()) += WorldGen.tEvil / 200f;
                player.GetDamage(ModContent.GetInstance<DamageClasses.Unholy>()) += WorldGen.tBlood / 200f;
                player.GetDamage(ModContent.GetInstance<DamageClasses.Holy>()) += WorldGen.tGood / 200f;
            }
        }
        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.ReconScope);
			recipe.AddIngredient(ItemID.MoltenQuiver);
			recipe.AddIngredient(ItemID.SoulofSight, 15);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.Register();
		}
	}
}
