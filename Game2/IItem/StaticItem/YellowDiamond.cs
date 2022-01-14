using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class YellowDiamond : IItem
    {
        public int Count { get; set; } = 0;
        public int TotalCount { get; set; } = 100;
        public bool Appear { get; set; } = false;
        private int p = 6;
        //Sprite class parameter
        private Texture2D texture = Texture2DStorage.GetItemSpriteSheet();
        private int sourceLocX = 164;
        private int sourceLocY = 120;
        private int width = 8;
        private int height = 16;

        public Rectangle BoundingBox { get; set; }

        //Sprite Object
        private ISprite blueDiamondSprite;

        //initial position on the ground
        public int PosX { get; set; }
        public int PosY { get; set; }


        public YellowDiamond(Vector2 vector)
        {
            PosX = (int)vector.X;
            PosY = (int)vector.Y;
            blueDiamondSprite = new StaticSprite(texture, sourceLocX, sourceLocY, width, height);

        }
        public int GetItem()
        {
            return p;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            blueDiamondSprite.Draw(spriteBatch, new Vector2(PosX, PosY));
        }

        public void Update()
        {
            BoundingBox = new Rectangle(PosX, PosY, width * 3, height * 3);
            blueDiamondSprite.Update();
        }

     //   public void NextItem(Game1 myGame)
       // {


          //  myGame.item = new Clock();


     //   }

     //   public void PreItem(Game1 myGame)
     //   {

           // myGame.item = new TriforcePiece();
     //   }

     //   public static void changeState()
     //   {
            //do nothing
     //   }

        public void ChangeSprite(ISprite sprite)
        {
            //do nothing
        }


    }
}
