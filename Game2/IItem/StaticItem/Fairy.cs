using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class Fairy : IItem
    {
        public int Count { get; set; } = 0;
        public int TotalCount { get; set; } = 100;
        public bool Appear { get; set; } = false;
        private int p = 9;
        //Sprite class parameter
        private Texture2D texture = Texture2DStorage.GetItemSpriteSheet();
        private int sourceLocX = 124;
        private int sourceLocY = 40;
        private int width = 8;
        private int height = 16;

        //Sprite Object
        private ISprite fairySprite;
        public Rectangle BoundingBox { get; set; }

        //initial position on the ground
        public int PosX { get; set; }
        public int PosY { get; set; }


        public Fairy(Vector2 vector)
        {
            PosX = (int)vector.X;
            PosY = (int)vector.Y;
            fairySprite = new StaticSprite(texture, sourceLocX, sourceLocY, width, height);

        }


        public void Draw(SpriteBatch spriteBatch)
        {
            fairySprite.Draw(spriteBatch, new Vector2(PosX, PosY));
        }

        public void Update()
        {

            BoundingBox = new Rectangle(PosX, PosY, width * 3, height * 3);

            fairySprite.Update();
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
#pragma warning disable CA1822 // Mark members as static
      //  public void NextItem(Game1 myGame)
#pragma warning restore CA1822 // Mark members as static
      //  {


          //  myGame.item = new Heart();
      //  }

#pragma warning disable CA1822 // Mark members as static
      //  public void PreItem(Game1 myGame)
#pragma warning restore CA1822 // Mark members as static
      //  {

            //myGame.item = new Compass();
      //  }
    }
}
