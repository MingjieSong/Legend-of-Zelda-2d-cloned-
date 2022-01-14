using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;


namespace Sprint2
{
    public class Key : IItem
    {
        public int Count { get; set; } = 0;
        public int TotalCount { get; set; } = 100;
        public bool Appear { get; set; } = false;
        private int p = 12;
        //Sprite parameter
        private Texture2D texture = Texture2DStorage.GetItemSpriteSheet();
        private int sourceLocX = 284;
        private int sourceLocY = 40;
        private int width = 8;
        private int height = 16;
        public Rectangle BoundingBox { get; set; }
        //Sprite Object
        private ISprite keySprite;

        //initial position in the center
        public int PosX { get; set; }
        public int PosY { get; set; }


        public Key(Vector2 vector)
        {
            PosX = (int)vector.X;
            PosY = (int)vector.Y;

            keySprite = new StaticSprite(texture, sourceLocX, sourceLocY, width, height);

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            keySprite.Draw(spriteBatch, new Vector2(PosX, PosY));
        }

        public void Update()
        {
            BoundingBox = new Rectangle(PosX, PosY, width * 3, height * 3);
            keySprite.Update();
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
     //   {

           // myGame.item = new HeartContainer();

      //  }
#pragma warning disable CA1822 // Mark members as static
      //  public void NextItem(Game1 myGame)
#pragma warning restore CA1822 // Mark members as static
      //  {

            //myGame.item = new Map();

      //  }
    }
}
