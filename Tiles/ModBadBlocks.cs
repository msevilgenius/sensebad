using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SenseBad.Tiles
{
    class ModBadBlocks : GlobalTile
    {
        public override void DrawEffects(int i, int j, int type, SpriteBatch spriteBatch, ref Color drawColor)
        {
            if (type == TileID.Crimstone || type == TileID.FleshIce || type == TileID.FleshGrass
                || type == TileID.Crimsand || type == TileID.CrimsonHardenedSand || type == TileID.CrimsonSandstone
                || type == TileID.CrimsonVines || type == TileID.CrimtaneThorns)
            {
                SenseBadPlayer player = Main.LocalPlayer.GetModPlayer<SenseBadPlayer>(mod);
                if (player.SenseRed == true)
                {
                    byte red = 200;
                    if (drawColor.R < red)
                    {
                        drawColor.R = red;
                    }
                }
            }
            else if (type == TileID.Ebonstone || type == TileID.CorruptIce || type == TileID.CorruptGrass
                || type == TileID.Ebonsand || type == TileID.CorruptHardenedSand || type == TileID.CorruptSandstone
                || type == TileID.CorruptPlants || type == TileID.CorruptThorns)
            {
                SenseBadPlayer player = Main.LocalPlayer.GetModPlayer<SenseBadPlayer>(mod);
                if (player.SensePurple == true)
                {
                    byte red = 120;
                    byte blue = 170;
                    byte green = 40;
                    if (drawColor.R < red)
                    {
                        drawColor.R = red;
                    }
                    if (drawColor.B < blue)
                    {
                        drawColor.B = blue;
                    }
                    if (drawColor.G < green)
                    {
                        drawColor.G = green;
                    }
                }
            }
            else if (type == TileID.Pearlstone || type == TileID.HallowedIce || type == TileID.HallowedGrass
                || type == TileID.Pearlsand || type == TileID.HallowHardenedSand || type == TileID.HallowSandstone
                || type == TileID.HallowedPlants || type == TileID.HallowedVines || type == TileID.HallowedPlants2)
            {
                SenseBadPlayer player = Main.LocalPlayer.GetModPlayer<SenseBadPlayer>(mod);
                if (player.SensePink == true)
                {
                    byte red = 220;
                    byte blue = 200;
                    byte green = 40;
                    if (drawColor.R < red)
                    {
                        drawColor.R = red;
                    }
                    if (drawColor.B < blue)
                    {
                        drawColor.B = blue;
                    }
                    if (drawColor.G < green)
                    {
                        drawColor.G = green;
                    }
                }
            }
        }

        /*
        public override void PostDraw(int i, int j, int type, SpriteBatch spriteBatch)
        {
            SenseBadPlayer player = Main.LocalPlayer.GetModPlayer<SenseBadPlayer>(mod);
            if (player.SenseRed == true)
            {

            }
        }
        */
    }
}
