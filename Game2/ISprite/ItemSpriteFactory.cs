using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
	class ItemSpriteFactory
	{
		private Texture2D itemArrowSpriteSheet = Texture2DStorage.GetItemSpriteSheet();
		private Texture2D itemSpriteSheet = Texture2DStorage.GetLinkSpriteSheet();
		private Texture2D textureHurtWeapon = Texture2DStorage.GetHurtWeaponSpriteSheet();
		private Texture2D textureFire = Texture2DStorage.GetEnemySpriteSheet2();
		private Texture2D textureDamageFire = Texture2DStorage.GetHurtFireSpriteSheet();
		private Texture2D textureDamageBomb = Texture2DStorage.GetHurtBoomSpriteSheet();
		private Texture2D textureDamageBoomer = Texture2DStorage.GetHurtBoomerangSpriteSheet();
		private Texture2D textureBoomer = Texture2DStorage.GetWoodBoomerangSpriteSheet();
		private Texture2D textureBow = Texture2DStorage.GetBowSpriteSheet();
		private Texture2D textureDamageBow = Texture2DStorage.GetHurtBowSpriteSheet();
		private Texture2D textureSword = Texture2DStorage.GetLinkSpriteSheet();
		private Texture2D itemHurtLeftRightArrowSword = Texture2DStorage.GetLinkSpriteSheet2();
		private static ItemSpriteFactory instance = new ItemSpriteFactory();

		public static ItemSpriteFactory Instance
		{
			get
			{
				return instance;
			}
		}

		private ItemSpriteFactory()
		{
		}

		public ISprite CreateArrowSprite(string direction, IItem arrow, bool ifDamage)
		{
			if (ifDamage)
			{
				if (direction.Equals("Up", StringComparison.Ordinal) || direction.Equals("Down", StringComparison.Ordinal))
				{
					return new ArrowDamageSprite(textureHurtWeapon, arrow, direction);
				}
				else
				{
					return new ArrowDamageSprite(itemHurtLeftRightArrowSword, arrow, direction);
				}
			}
			else
			{
				return new ArrowSprite(itemArrowSpriteSheet, arrow, direction);
			}
		}
		public ISprite CreateBlueCandleSprite(string direction, IItem candle, bool ifDamage)
		{
			if (ifDamage)
			{
				return new BlueCandleDamageSprite(textureDamageFire, candle, direction);
			}
			else
			{
				return new BlueCandleSprite(textureFire, candle, direction);
			}
		}
		public ISprite CreateBombSprite(bool ifExplode, bool ifDamage)
		{
			if (ifDamage)
			{
				return new BombDamageSprite(textureDamageBomb, ifExplode);
			}
			else
			{
				return new BombSprite(itemSpriteSheet, ifExplode);
			}
		}
		
		public ISprite CreateWoodBoomerangSprite(string direction, IItem boomerang, bool ifDamage)
		{
			if (ifDamage)
			{
				return new WoodBoomerangDamageSprite(textureDamageBoomer, boomerang, direction);
			}
			else
			{
				return new WoodBoomerangSprite(textureBoomer, boomerang, direction);
			}
		}
		public ISprite CreateBowSprite(string direction, bool ifDamage)
		{
			if (ifDamage)
			{
				return new BowDamageSprite(textureDamageBow, direction);
			}
			else
			{
				return new BowSprite(textureBow, direction);
			}
		}
		public ISprite CreateFireballSprite(string direction, IItem fire, bool ifSpread)
		{
			if (ifSpread)
			{
				return new FireBallSpreadSprite(textureFire, fire, direction);
			}
			else
			{
				return new FireBallSprite(textureFire, fire, direction);
			}
		}
		public ISprite CreateWoodSwordSprite(string direction, IItem sword, bool ifDamage)
		{
			if (ifDamage)
			{
				if (direction.Equals("Up", StringComparison.Ordinal) || direction.Equals("Down", StringComparison.Ordinal))
				{
					return new WoodSwordDamageSprite(textureHurtWeapon, sword, direction);
				}
				else
				{
					return new WoodSwordDamageSprite(itemHurtLeftRightArrowSword, sword, direction);
				}
			}
			else
			{
				return new WoodSwordSprite(textureSword, sword, direction);
			}
		}
	}
}
