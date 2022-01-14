using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using System.Collections.Generic;

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;


namespace Sprint2
{
  public static class Texture2DStorage
		{
			// Note that we are not using Game1's ContentLoader here (outside the scope of class methods) since it has not been instantiated yet
			private static Texture2D enemySpriteSheet;
			private static Texture2D itemSpriteSheet;
		    private static Texture2D linkSpriteSheet;
			private static Texture2D linkSpriteSheet2;
		private static Texture2D npcSpriteSheet;
		private static Texture2D cloudSpriteSheet;
		private static Texture2D hurtEnemySpriteSheet;
		private static Texture2D enemySpriteSheet2;
		   private static Texture2D enemySpriteSheet3;
		private static Texture2D hurtWeaponSpriteSheet;
		private static Texture2D hurtBoomerangSpriteSheet;
		private static Texture2D hurtFireSpriteSheet;
		private static Texture2D hurtBowSpriteSheet;
		private static Texture2D hurtBoomSpriteSheet;
		private static Texture2D woodenBoomerangSpriteSheet;
        private static Texture2D blueCandleSpriteSheet;
        private static Texture2D bowSpriteSheet;
		private static Texture2D dungeonSpriteSheet;
		private static Texture2D lockedDoor;
		//start state
		private static Texture2D LogoSpriteSheet;
		private static Texture2D ButtonSpriteSheet;
		private static Texture2D ZeldaStorySpriteSheet;

		//win state
		private static Texture2D triPieceSpriteSheet;
		private static Texture2D blackSpriteSheet;

		//play state
		private static Texture2D inventorySpriteSheet;

		//lose state
		private static Texture2D loseSpriteSheet;


		//letters and numbers
		private static Texture2D numberSpriteSheet;
		private static Texture2D letterSpriteSheet;
		private static Texture2D  cloud;
		private static Texture2D upMap;
		private static Texture2D downMap;
		private static Texture2D container;
		private static Texture2D block;
		//initialize the Texture2D fields
		public static void LoadAllTextures(ContentManager content)
			{
			if (content == null)
			{
				throw new System.ArgumentNullException(nameof(content));
			}

			linkSpriteSheet = content.Load<Texture2D>("link");
			enemySpriteSheet = content.Load<Texture2D>("enemy");
			itemSpriteSheet = content.Load<Texture2D>("item");
			npcSpriteSheet = content.Load<Texture2D>("characters");

			linkSpriteSheet2 = content.Load<Texture2D>("link--final");
			cloudSpriteSheet = content.Load<Texture2D>("cloud");
			hurtEnemySpriteSheet = content.Load<Texture2D>("hurtDragon");
			enemySpriteSheet2 = content.Load<Texture2D>("enemy2");
			enemySpriteSheet3 = content.Load<Texture2D>("enemy3");
			bowSpriteSheet = content.Load<Texture2D>("bow");
            woodenBoomerangSpriteSheet = content.Load<Texture2D>("woodenboomerang");
            blueCandleSpriteSheet = content.Load<Texture2D>("candle");
			hurtWeaponSpriteSheet = content.Load<Texture2D>("UDweapon");
			hurtBoomerangSpriteSheet = content.Load<Texture2D>("HurtBoomg");
			hurtBoomSpriteSheet = content.Load<Texture2D>("HurtBoom");
			hurtBowSpriteSheet = content.Load<Texture2D>("HurtBow");
			hurtFireSpriteSheet = content.Load<Texture2D>("HurtFire");
			dungeonSpriteSheet = content.Load<Texture2D>("dugeon");

			//start state
			LogoSpriteSheet = content.Load<Texture2D>("Logo");
			ButtonSpriteSheet = content.Load<Texture2D>("Button");
			ZeldaStorySpriteSheet = content.Load<Texture2D>("Zelda_story");

			//win state
			triPieceSpriteSheet = content.Load<Texture2D>("TriForce");
			blackSpriteSheet = content.Load<Texture2D>("black");
			//play state
			inventorySpriteSheet = content.Load<Texture2D>("emptyInventory");


			triPieceSpriteSheet = content.Load<Texture2D>("WinLogo");

			//lose state
			loseSpriteSheet = content.Load<Texture2D>("LoseScreen");

			numberSpriteSheet = content.Load<Texture2D>("item-Inventory");

			letterSpriteSheet = content.Load<Texture2D>("font");
			cloud = content.Load<Texture2D>("enemyCloud");
			upMap = content.Load<Texture2D>("mapInventory");
			downMap = content.Load<Texture2D>("mapBar");
			lockedDoor = content.Load<Texture2D>("door");

			container = content.Load<Texture2D>("container");
			block = content.Load<Texture2D>("block");

		}

		   public static void UnloadAllTextures()
			{
			// unload all the Texture2Ds - not needed for the scope of this project
			// 12
		
			}

		public static Texture2D GetBlockSpriteSheet()
		{
			return  block;
		}
		public static Texture2D GeHeartContainerSpriteSheet()
		{
			return container;
		}

		public static Texture2D GetUpMapSpriteSheet()
		{
			return upMap;
		}

		public static Texture2D GetDownMapSpriteSheet()
		{
			return downMap;
		}
		public static Texture2D GetEnemySpriteSheet()
			{
				return enemySpriteSheet;
			}
	
		public static Texture2D GetEnemySpriteSheet2()
		{
			return enemySpriteSheet2;
		}
		public static Texture2D GetHurtEnemySpriteSheet()
		{
			return hurtEnemySpriteSheet;
		}
		public static Texture2D GetInventorySpriteSheet()
		{
			return inventorySpriteSheet;
		}

		public static Texture2D GetEnemySpriteSheet3()
		{
			return enemySpriteSheet3;
		}
		public static Texture2D GetBowSpriteSheet()
        {
            return bowSpriteSheet;
        }
        public static Texture2D GetWoodBoomerangSpriteSheet()
        {
            return woodenBoomerangSpriteSheet;
        }
        public static Texture2D GetBlueCandleSpriteSheet()
        {
            return blueCandleSpriteSheet;
        }
		public static Texture2D GetCloudSpriteSheet()
		{
			return cloudSpriteSheet;
		}
		public static Texture2D GetHurtWeaponSpriteSheet()
		{
			return hurtWeaponSpriteSheet;
		}
		public static Texture2D GetHurtBoomSpriteSheet()
		{
			return hurtBoomSpriteSheet;
		}
		public static Texture2D GetHurtBoomerangSpriteSheet()
		{
			return hurtBoomerangSpriteSheet;
		}
		public static Texture2D GetHurtBowSpriteSheet()
		{
			return hurtBowSpriteSheet;
		}
		public static Texture2D GetHurtFireSpriteSheet()
		{
			return hurtFireSpriteSheet;
		}

		public static Texture2D GetItemSpriteSheet()
			{
				return itemSpriteSheet;
			}

		    public static Texture2D GetLinkSpriteSheet()
		    {
				return linkSpriteSheet;
		    }
			public static Texture2D GetNpcSpriteSheet()
			{
				return npcSpriteSheet;
			}
		public static Texture2D GetLinkSpriteSheet2()
		{
			return linkSpriteSheet2;
		}
		public static Texture2D GetDungeonSpriteSheet()
		{
			return dungeonSpriteSheet;
		}


		//start state
		public static Texture2D GetLogoSpriteSheet()
		{
			return LogoSpriteSheet;
		}

		public static Texture2D GetButtonSpriteSheet()
		{
			return ButtonSpriteSheet;
		}

		public static Texture2D GetZeldaStorySpriteSheet()
		{
			return ZeldaStorySpriteSheet;
		}
		public static Texture2D GetTriForceSpriteSheet()
		{
			return triPieceSpriteSheet;
		}
		public static Texture2D GetLoseSpriteSheet() {
			return loseSpriteSheet;
		}
		public static Texture2D GetNumberSpriteSheet() {
			return numberSpriteSheet;
		}
		public static Texture2D GetLetterSpriteSheet() {
			return letterSpriteSheet;
		}
		public static Texture2D GetDarkCloudSpriteSheet()
		{
			return cloudSpriteSheet;
		}
		public static Texture2D GetDoorSpriteSheet()
		{
			return lockedDoor;
		}
		public static Texture2D GetBlackBackgroundSpriteSheet()
		{
			return blackSpriteSheet;
		}
	}
	
}
