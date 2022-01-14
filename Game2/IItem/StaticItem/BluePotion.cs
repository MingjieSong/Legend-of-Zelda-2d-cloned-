using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class BluePotion : IItem
    {
        public Rectangle BoundingBox { get; set; }
        public int PosX { get; set ; }
        public int PosY { get ; set; }
        public int Count { get; set; } = 0;
        public int TotalCount { get; set; } = 200;
        public bool Appear { get; set; } = false;

        private int num = 17;
        //for constructor
        private ISprite bluePotionSprite;
        private Texture2D texture = Texture2DStorage.GetLinkSpriteSheet();
        private int sourceLocX = 424;
        private int sourceLocY = 285;
        private int width = 8;
        private int height = 21;

        public BluePotion(Vector2 vector)
        {
            PosX = (int)vector.X;
            PosY = (int)vector.Y;
            bluePotionSprite = new StaticSprite(texture, sourceLocX, sourceLocY, width, height);
        }

        public void ChangeSprite(ISprite sprite)
        {
            //nothing
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            bluePotionSprite.Draw(spriteBatch, new Vector2(PosX, PosY));
        }

        public int GetItem()
        {
            return num;
        }

        public void Update()
        {
            BoundingBox = new Rectangle(PosX, PosY, width * 3, height * 3);
            bluePotionSprite.Update();
        }
    }
}
