using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class Cloud : IItem
    {
        public int Count { get; set; } = 0;
        public int TotalCount { get; set; } = 100;
        public bool Appear { get; set; } = false;
        private int p = 7;
        //Sprite parameters
        private Texture2D texture = Texture2DStorage.GetDarkCloudSpriteSheet();
        private int sourceLocX = 1;
        private int sourceLocY = 2;
        private int width = 29;
        private int height = 22;

        public Rectangle BoundingBox { get; set; }

        //Sprite Object
        private ISprite cloudSprite;

        //initial position on the ground
        public int PosX { get; set; }
        public int PosY { get; set; }

        public Cloud(Vector2 vector)
        {
            PosX = (int)vector.X;
            PosY = (int)vector.Y;
            cloudSprite = new StaticSprite(texture, sourceLocX, sourceLocY, width, height);
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
            cloudSprite.Draw(spriteBatch, new Vector2(PosX, PosY));
        }

        public void Update()
        {
            BoundingBox = new Rectangle(PosX+10, PosY+10, width*2, height*2);
            
            cloudSprite.Update();
        }


      
    }
}
