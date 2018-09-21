using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WorldExpansion.Items.WorldContractor
{
	public class WorldContractor : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.DisplayName.SetDefault("World Contractor");
			base.Tooltip.SetDefault("Reduces your world to normal size.");
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
			Main.leftWorld = 0f;
			Main.rightWorld = Main.maxTilesX * 16;
			Main.topWorld = 0f;
			Main.bottomWorld = Main.maxTilesY * 16;
			this.Talk("Your world is back to normal. Not fun enough?");
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}
