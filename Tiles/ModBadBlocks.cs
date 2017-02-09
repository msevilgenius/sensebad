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
            byte red = 0;
            byte blue = 0;
            byte green = 0;

            if (type == TileID.Crimstone || type == TileID.FleshIce || type == TileID.FleshGrass
                || type == TileID.Crimsand || type == TileID.CrimsonHardenedSand || type == TileID.CrimsonSandstone
                || type == TileID.CrimsonVines || type == TileID.CrimtaneThorns)
            {
                SenseBadPlayer player = Main.LocalPlayer.GetModPlayer<SenseBadPlayer>(mod);
                if (player.SenseRed == true)
                {
                    red = 200;
                }
            }
            else if (type == TileID.Ebonstone || type == TileID.CorruptIce || type == TileID.CorruptGrass
                || type == TileID.Ebonsand || type == TileID.CorruptHardenedSand || type == TileID.CorruptSandstone
                || type == TileID.CorruptPlants || type == TileID.CorruptThorns)
            {
                SenseBadPlayer player = Main.LocalPlayer.GetModPlayer<SenseBadPlayer>(mod);
                if (player.SensePurple == true)
                {
                    red = 180;
                    blue = 200;
                    green = 150;
                }
            }
            else if (type == TileID.Pearlstone || type == TileID.HallowedIce || type == TileID.HallowedGrass
                || type == TileID.Pearlsand || type == TileID.HallowHardenedSand || type == TileID.HallowSandstone
                || type == TileID.HallowedPlants || type == TileID.HallowedVines || type == TileID.HallowedPlants2)
            {
                SenseBadPlayer player = Main.LocalPlayer.GetModPlayer<SenseBadPlayer>(mod);
                if (player.SensePink == true)
                {
                    red = 240;
                    blue = 220;
                    green = 160;
                }
            }
            else
            {
                return;
            }

            // Modify render colours if necessary
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
