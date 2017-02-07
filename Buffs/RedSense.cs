using Terraria;
using Terraria.ModLoader;

namespace SenseBad.Buffs
{
    class RedSense : ModBuff
    {
        public override void SetDefaults()
        {
            Main.buffName[this.Type] = "Red Sense";
            Main.buffTip[this.Type] = "Shows the location of crimson blocks.";
            Main.debuff[Type] = false;
            Main.pvpBuff[Type] = false;
            Main.buffNoSave[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.GetModPlayer<SenseBadPlayer>(mod).SenseRed = true;
        }
    }
}
