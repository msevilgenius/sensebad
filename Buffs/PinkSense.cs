using Terraria;
using Terraria.ModLoader;

namespace SenseBad.Buffs
{
    class PinkSense : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Pink Sense");
            Description.SetDefault("Shows the location of hallow blocks.");
            Main.debuff[Type] = false;
            Main.pvpBuff[Type] = false;
            Main.buffNoTimeDisplay[Type] = false;
            Main.buffNoSave[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.GetModPlayer<SenseBadPlayer>().SensePink = true;
        }
    }
}
