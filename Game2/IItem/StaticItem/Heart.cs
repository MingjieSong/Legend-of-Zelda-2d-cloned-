using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;


namespace Sprint2
{
    public class Heart : IItem
    {
        public int Count { get; set; } = 0;
        public int TotalCount { get; set; } = 100;
        public bool Appear { get; set; } = false;
        private int p = 10;
        //Sprite parameter
        private Texture2D texture = Texture2DStorage.GetLinkSpriteSheet();
        private int sourceLocX = 244;
        private int sourceLocY = 199;
        private int width = 7;
        private int height = 8;

        public Rectangle BoundingBox { get; set; }


        //Sprite Object
        private ISprite heartSprite;

        //initial position in the center
        public int PosX { get; set; }
        public int PosY { get; set; }

        public Heart(Vector2 vector)
        {
            PosX = (int)vector.X;
            PosY = (int)vector.Y;
            heartSprite = new StaticSprite(texture, sourceLocX, sourceLocY, width, height);

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            heartSprite.Draw(spriteBatch, new Vector2(PosX, PosY));
        }

        public void Update()
        {
            BoundingBox = new Rectangle(PosX, PosY, width * 3, height * 3);
            heartSprite.Update();
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
      //  public void PreItem(Game1 myGame)
#pragma warning restore CA1822 // Mark members as static
       // {

          //  myGame.item = new Fairy();

       // }
#pragma warning disable CA1822 // Mark members as static
      //  public void NextItem(Game1 myGame)
#pragma warning restore CA1822 // Mark members as static
      //  {

            //myGame.item = new HeartContainer();

      //  }
    }
}
