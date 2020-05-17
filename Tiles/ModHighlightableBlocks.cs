using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SenseBad.Tiles
{
    class ModHighlightableBlocks : GlobalTile
    {
        public override void DrawEffects(int i, int j, int type, SpriteBatch spriteBatch, ref Color drawColor, ref int nextSpecialDrawIndex)
        {
            byte red = 0;
            byte blue = 0;
            byte green = 0;

            var player = Main.LocalPlayer.GetModPlayer<SenseBadPlayer>();
            switch (type)
            {
                case TileID.Crimstone:
                case TileID.FleshIce:
                case TileID.FleshGrass:
                case TileID.Crimsand:
                case TileID.CrimsonHardenedSand:
                case TileID.CrimsonSandstone:
                case TileID.CrimsonVines:
                case TileID.CrimtaneThorns:
                {
                    if (player.SenseRed)
                    {
                        red = 200;
                    }

                    break;
                }
                case TileID.Ebonstone:
                case TileID.CorruptIce:
                case TileID.CorruptGrass:
                case TileID.Ebonsand:
                case TileID.CorruptHardenedSand:
                case TileID.CorruptSandstone:
                case TileID.CorruptPlants:
                case TileID.CorruptThorns:
                {
                    if (player.SensePurple)
                    {
                        red = 180;
                        blue = 200;
                        green = 150;
                    }

                    break;
                }
                case TileID.Pearlstone:
                case TileID.HallowedIce:
                case TileID.HallowedGrass:
                case TileID.Pearlsand:
                case TileID.HallowHardenedSand:
                case TileID.HallowSandstone:
                case TileID.HallowedPlants:
                case TileID.HallowedVines:
                case TileID.HallowedPlants2:
                {
                    if (player.SensePink)
                    {
                        red = 240;
                        blue = 220;
                        green = 160;
                    }

                    break;
                }
                default:
                    return; // Don't need to modify other tiles
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
