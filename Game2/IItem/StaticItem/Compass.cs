using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class Compass : IItem
    {
        public int Count { get; set; } = 0;
        public int TotalCount { get; set; } = 100;
        public bool Appear { get; set; } = false;
        private int p = 8;
        //Sprite class parameter
        private Texture2D texture = Texture2DStorage.GetItemSpriteSheet();
        private int sourceLocX = 82;
        private int sourceLocY = 42;
        private int width = 11;
        private int height = 12;

        public Rectangle BoundingBox { get; set; }


        //Sprite Object
        private ISprite compassSprite;

        //initial position on the ground
        public int PosX { get; set; }
        public int PosY { get; set; }


        public Compass(Vector2 vector)
        {
            PosX = (int)vector.X;
            PosY = (int)vector.Y;
            compassSprite = new StaticSprite(texture, sourceLocX, sourceLocY, width, height);

        }


        public void Draw(SpriteBatch spriteBatch)
        {
            compassSprite.Draw(spriteBatch, new Vector2(PosX, PosY));
        }

        public void Update()
        {
            BoundingBox = new Rectangle(PosX, PosY, width * 3, height * 3);
            compassSprite.Update();
        }

        public int GetItem()
        {
            return p;
        }
        public static void changeState()
        {
            //do nothing
        }

        public void ChangeSprite(ISprite sprite)
        {
            //do nothing
        }

#pragma warning disable IDE0060 // Remove unused parameter
#pragma warning disable CA1822 // Mark members as static
     //   public void NextItem(Game1 myGame)
#pragma warning restore CA1822 // Mark members as static
#pragma warning restore IDE0060 // Remove unused parameter
      //  {


           // myGame.item = new Fairy();
      //  }

#pragma warning disable CA1822 // Mark members as static
      //  public void PreItem(Game1 myGame)
#pragma warning restore CA1822 // Mark members as static
      //  {

         //   myGame.item = new Clock();
      //  }
    }
}
