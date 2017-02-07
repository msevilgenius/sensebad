using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace SenseBad.Items
{
    class PinkPotion : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Pink Sense Potion";
            item.width = 20;
            item.height = 20;
            item.maxStack = 30;
            AddTooltip("Shows the location of hallow blocks");
            item.value = Item.buyPrice(0, 0, 25, 0); ;
            item.rare = 1;
            item.useStyle = 2;
            item.useAnimation = 17;
            item.useTime = 17;
            item.useTurn = false;
            item.consumable = true;
            item.potion = false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Blinkroot);
            recipe.AddIngredient(ItemID.Moonglow);
            recipe.AddIngredient(ItemID.BottledWater);
            recipe.AddIngredient(ItemID.PixieDust, 3);
            recipe.SetResult(this, 1);
            recipe.AddTile(TileID.AlchemyTable);
            recipe.AddTile(TileID.Bottles);
            recipe.AddRecipe();
        }

        public override bool UseItem(Player player)
        {
            player.AddBuff(mod.BuffType("PinkSense"), 5 * 60 * 60, false);
            Main.PlaySound(SoundID.Item3, -1, -1);
            return true;
        }
    }
}
