using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WorldExpansion.Items.WorldExpander
{
	public class WorldExpander : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.DisplayName.SetDefault("World Expander");
			base.Tooltip.SetDefault("Expand your world to the very end!");
		}

		public override void SetDefaults()
		{
			base.item.width = 32;
			base.item.height = 32;
			base.item.rare = -12;
			base.item.useAnimation = 45;
			base.item.useTime = 45;
			base.item.useStyle = 4;
			base.item.consumable = false;
			base.item.maxStack = 1;
		}
		
		private void Talk(string Words)
		{
			Main.NewText(Words, 255, 227, 0, false);
		}

		public override bool UseItem(Player player)
		{
			this.Expand();
			return true;
		}
		
		private void Expand()
		{
			float Xpand = Main.rightWorld;
			float Ypand = Main.bottomWorld;
			Main.leftWorld = -576f;
			Main.rightWorld = (Main.maxTilesX * 16) + 608f;
			Main.topWorld = -576f;
			Main.bottomWorld = (Main.maxTilesY * 16) + 608f;
			this.Talk("Your world has been expanded. Have fun with the extra space!");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}
