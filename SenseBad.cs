using SenseBad.Tiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace SenseBad
{
    public class SenseBad : Terraria.ModLoader.Mod
    {
        public SenseBad()
        {
            Properties = new ModProperties()
            {
                Autoload = true
            };
            //ModCrimstone mCrimstone = new ModCrimstone();
            //this.AddGlobalTile("Crimstone", mCrimstone);
        }
    }
}
