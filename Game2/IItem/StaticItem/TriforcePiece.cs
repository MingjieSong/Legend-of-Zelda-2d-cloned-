using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class TriforcePiece : IItem
    {
        public int Count { get; set; } = 0;
        public int TotalCount { get; set; } = 100;
        public bool Appear { get; set; } = false;
        private int p = 14;
        //Sprite class parameter
        private Texture2D texture = Texture2DStorage.GetItemSpriteSheet();
        private int sourceLocX = 343;
        private int sourceLocY = 123;
        private int width = 10;
        private int height = 10;
        public Rectangle BoundingBox { get; set; }
        //Sprite Object
        private ISprite triforcePieceSprite;

        //initial position on the ground
        public int PosX { get; set; }
        public int PosY { get; set; }

        public TriforcePiece(Vector2 vector)
        {
            PosX = (int)vector.X;
            PosY = (int)vector.Y;
            triforcePieceSprite = new StaticSprite(texture, sourceLocX, sourceLocY, width, height);

        }


        public void Draw(SpriteBatch spriteBatch)
        {
            triforcePieceSprite.Draw(spriteBatch, new Vector2(PosX, PosY));
        }

        public void Update()
        {
            BoundingBox = new Rectangle(PosX, PosY, width * 3, height * 3);
            triforcePieceSprite.Update();
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


          //  myGame.item = new BlueDiamond();
     //   }

#pragma warning disable CA1822 // Mark members as static
       // public void PreItem(Game1 myGame)
#pragma warning restore CA1822 // Mark members as static
      //  {

            //myGame.item = new Map();
      //  }
    }
}
