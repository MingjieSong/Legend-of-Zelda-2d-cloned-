using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class BlueRing : IItem
    {
        public Rectangle BoundingBox { get ; set ; }
        public int PosX { get; set; }
        public int PosY { get ; set ; }
        public int Count { get; set; } = 0;
        public int TotalCount { get; set; } = 200;
        public bool Appear { get; set; } = false;

        private int num = 20;
        //for constructor
        private ISprite blueRingSprite;
        private Texture2D texture = Texture2DStorage.GetLinkSpriteSheet();
        private int sourceLocX = 334;
        private int sourceLocY = 228;
        private int width = 7;
        private int height = 9;

        public BlueRing(Vector2 vector)
        {
            PosX = (int)vector.X;
            PosY = (int)vector.Y;
            blueRingSprite = new StaticSprite(texture, sourceLocX, sourceLocY, width, height);
        }

        public void ChangeSprite(ISprite sprite)
        {
            //nothing
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            blueRingSprite.Draw(spriteBatch, new Vector2(PosX, PosY));
        }

        public int GetItem()
        {
            return num;
        }

        public void Update()
        {
            BoundingBox = new Rectangle(PosX, PosY, width * 3, height * 3);
            blueRingSprite.Update();
        }
    }
}
