﻿using Terraria;
using Terraria.ModLoader;

namespace SenseBad
{
    class SenseBadPlayer : ModPlayer
    {
        public bool SenseRed = false;
        public bool SensePurple = false;
        public bool SensePink = false;

        public override void ResetEffects()
        {
            SenseRed = false;
            SensePurple = false;
            SensePink = false;
        }

        public override void UpdateDead()
        {
            SenseRed = false;
            SensePurple = false;
            SensePink = false;
        }

    }
}
