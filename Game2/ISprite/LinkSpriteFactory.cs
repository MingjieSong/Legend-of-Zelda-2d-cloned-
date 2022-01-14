using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
	class LinkSpriteFactory
	{
		private Texture2D linkSpriteSheet = Texture2DStorage.GetLinkSpriteSheet();
		private Texture2D linkSpriteSheet2 = Texture2DStorage.GetLinkSpriteSheet2();


		private static LinkSpriteFactory instance = new LinkSpriteFactory();

		public static LinkSpriteFactory Instance
		{
			get
			{
				return instance;
			}
		}

		private LinkSpriteFactory()
		{
		}

		public ISprite CreateLinkWalkSprite(string direction, bool ifDamage)
		{
			if (ifDamage)
			{
				return new LinkDamageWalk(linkSpriteSheet2, direction);
			}
			else
			{
				return new LinkWalk(linkSpriteSheet, direction);
			}
		}
		public ISprite CreateLinkStandSprite(string direction, bool ifDamage)
		{
			if (ifDamage)
			{
				return new LinkDamageStand(linkSpriteSheet2, direction);
			}
			else
			{
				return new LinkStand(linkSpriteSheet, direction);
			}
		}
		public ISprite CreateLinkAttackSprite(string direction, bool ifDamage)
		{
			if (ifDamage)
			{
				return new LinkDamageAttack(linkSpriteSheet2, direction);
			}
			else
			{
				return new LinkAttack(linkSpriteSheet, direction);
			}
		}
		public ISprite CreateLinkWinningSprite()
		{
			return new LinkWinningSprite(linkSpriteSheet);
		}
	}
}
