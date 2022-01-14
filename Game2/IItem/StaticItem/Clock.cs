using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class Clock : IItem
    {
        public int Count { get; set; } = 0;
        public int TotalCount { get; set; } = 100;
        public bool Appear { get; set; } = false;
        private int p = 7;
        //Sprite parameters
        private Texture2D texture = Texture2DStorage.GetItemSpriteSheet();
        private int sourceLocX = 362;
        private int sourceLocY = 0;
        private int width = 11;
        private int height = 16;

        public Rectangle BoundingBox { get; set; }

        //Sprite Object
        private ISprite clockSprite;

        //initial position on the ground
        public int PosX { get; set; }
        public int PosY { get; set; }

        public Clock(Vector2 vector)
        {
            PosX = (int)vector.X;
            PosY = (int)vector.Y;
            clockSprite = new StaticSprite(texture, sourceLocX, sourceLocY, width, height);
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

        public void Draw(SpriteBatch spriteBatch)
        {
            clockSprite.Draw(spriteBatch, new Vector2(PosX, PosY));
        }

        public void Update()
        {
            BoundingBox = new Rectangle(PosX, PosY, width * 3, height * 3);
            clockSprite.Update();
        }


      
    }
}
