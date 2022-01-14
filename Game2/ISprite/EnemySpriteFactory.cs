using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
	class EnemySpriteFactory
	{
		private Texture2D enemysheet = Texture2DStorage.GetEnemySpriteSheet();
		private Texture2D damageDragon = Texture2DStorage.GetHurtEnemySpriteSheet();
		private Texture2D enemysheet2 = Texture2DStorage.GetEnemySpriteSheet2();
		private Texture2D enemysheet3 = Texture2DStorage.GetEnemySpriteSheet3();


		private static EnemySpriteFactory instance = new EnemySpriteFactory();

		public static EnemySpriteFactory Instance
		{
			get
			{
				return instance;
			}
		}

		private EnemySpriteFactory()
		{
		}

		public ISprite CreateGreenDragonSprite(string direction, IEnemy dragon, bool ifDamage)
		{
			if (ifDamage)
			{
				return new GreenDragonDamageSprite(damageDragon, dragon, direction);
			}
			else
			{
				return new GreenDragonSprite(enemysheet, dragon, direction);
			}
		}
		public ISprite CreateYellowDragonSprite(string direction, IEnemy dragon, bool ifDamage)
		{
			if (ifDamage)
			{
				return new YellowDragonDamageSprite(enemysheet, dragon, direction);
			}
			else
			{
				return new YellowDragonSprite(enemysheet, dragon, direction);
			}
		}
		public ISprite CreateWallMasterSprite(string direction, IEnemy wall, bool ifStatic)
		{

			if (ifStatic)
			{
				return new WallMasterStaticSprite(enemysheet2, wall, direction);
			}
			else
			{
				return new WallMasterSprite(enemysheet2, wall, direction);
			}
		}
		public ISprite CreateBatSprite(string direction, IEnemy bat)
		{
			return new BatSprite(enemysheet3, direction, bat);
		}
		public ISprite CreateFlameSprite()
		{
			return new FlameSilentBurningSprite(enemysheet2);
		}
		public ISprite CreateRedGoriyaSprite(string direction, IEnemy goriya)
		{
			return new RedGoriyaSprite(enemysheet3, direction, goriya);
		}
		public ISprite CreateRopeSprite(string direction, IEnemy rope)
		{
			return new RopeSprite(enemysheet2, direction, rope);
		}
		public ISprite CreateStalfoSprite(string direction, IEnemy stalfo)
		{
			return new StalfoSprite(enemysheet3, direction, stalfo);
		}
		public ISprite CreateTrapSprite(IEnemy trap)
		{
			return new TrapSprite(enemysheet2, trap);
		}
		public ISprite CreateZolSprite(string direction, IEnemy zol)
		{
			return new ZolSprite(enemysheet3, direction, zol);
		}
	}
}
