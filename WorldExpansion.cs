using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WorldExpansion
{
	public class WorldExpansion : Mod
	{
		internal static WorldExpansion instance;
		
		public override void Load()
		{
			Main.maxTilesX = 16800;
			Main.maxTilesY = 4800;
			Main.mapTargetX = 10;
			Main.mapTargetY = 4;
		}
	}
}
