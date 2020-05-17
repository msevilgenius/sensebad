using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace SenseBad.Items
{
    class PinkPotion : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hallowsense Potion");
            Tooltip.SetDefault("Shows the location of hallow blocks");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 30;
            item.value = Item.buyPrice(0, 0, 25, 0);
            item.rare = ItemRarityID.Orange;
            item.useStyle = ItemUseStyleID.EatingUsing;
            item.useAnimation = 17;
            item.useTime = 17;
            item.UseSound = SoundID.Item3;
            item.useTurn = false;
            item.consumable = true;
            item.buffType = BuffType<Buffs.PinkSense>();
            item.buffTime = 5 * 60 * 60;
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
    }
}
