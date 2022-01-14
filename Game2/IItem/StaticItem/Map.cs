using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    class Map: IItem
    {
        public int Count { get; set; } = 0;
        public int TotalCount { get; set; } = 100;
        public bool Appear { get; set; } = false;
        private int p = 13;
        //Sprite parameter
        private Texture2D texture = Texture2DStorage.GetItemSpriteSheet();
        private int sourceLocX = 244;
        private int sourceLocY = 80;
        private int width = 8;
        private int height = 16;
        public Rectangle BoundingBox { get; set; }
        //Sprite Object
        public ISprite mapSprite;

        //initial position in the center
        public int PosX { get; set; }
        public int PosY { get; set; }

        public Map(Vector2 vector)
        {
            PosX = (int)vector.X;
            PosY = (int)vector.Y;
            mapSprite = new StaticSprite(texture, sourceLocX, sourceLocY, width, height);

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            mapSprite.Draw(spriteBatch, new Vector2(PosX, PosY));
        }

        public void Update()
        {
            BoundingBox = new Rectangle(PosX, PosY, width * 3, height * 3);
            mapSprite.Update();
        }
        public int GetItem()
        {
            return p;
        }
        public void changeState()
        {
            //do nothing
        }

        public void ChangeSprite(ISprite sprite)
        {
            //do nothing
        }
     //   public void PreItem(Game1 myGame)
      //  {

          //  myGame.item = new Key();

      //  }
       // public void NextItem(Game1 myGame)
      //  {

            //myGame.item = new TriforcePiece();

       // }
    }
}
