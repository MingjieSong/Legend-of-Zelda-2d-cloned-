 
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
    {
      public  class staticWoodenBoomerang : IItem
        {
            public int Count { get; set; } = 0;
            public int TotalCount { get; set; } = 100;
            public bool Appear { get; set; } = false;
            private int p = 15;
            //Sprite parameter
            private Texture2D texture = Texture2DStorage.GetItemSpriteSheet();
            private int sourceLocX = 285;
            private int sourceLocY = 4;
            private int width = 5;
            private int height = 8;
            public Rectangle BoundingBox { get; set; }
        //Sprite Object
#pragma warning disable CA1051 // Do not declare visible instance fields
        public ISprite Sprite;
#pragma warning restore CA1051 // Do not declare visible instance fields

        //initial position in the center
        public int PosX { get; set; }
            public int PosY { get; set; }

            public staticWoodenBoomerang(Vector2 vector)
            {
                PosX = (int)vector.X;
                PosY = (int)vector.Y;
                Sprite = new StaticSprite(texture, sourceLocX, sourceLocY, width, height);

            }

            public void Draw(SpriteBatch spriteBatch)
            {
                Sprite.Draw(spriteBatch, new Vector2(PosX, PosY));
            }

            public void Update()
            {
                BoundingBox = new Rectangle(PosX, PosY, width * 3, height * 3);
                 Sprite.Update();
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
        //    public void PreItem(Game1 myGame)
        //    {

                 

        //    }
        //    public void NextItem(Game1 myGame)
        //    {

                

        //    }
        }
    }
 