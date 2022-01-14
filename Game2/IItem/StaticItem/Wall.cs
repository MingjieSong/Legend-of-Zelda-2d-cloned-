using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;

namespace Sprint2
{
    public class Wall : IItem
    {
        //this part only needed for link item
        public int Count { get; set; } = 0;
        public int TotalCount { get; set; } = 100;
        public bool Appear { get; set; } = true;
        private int p = 100;
        //Sprite parameters
        private Texture2D texture = Texture2DStorage.GetDoorSpriteSheet();
        private int sourceLocX;
        private int sourceLocY;
        private int width;
        private int height;

        private int desWidth;
        private int desHeight;
        private string Direction { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }
        public Rectangle BoundingBox { get; set; }
        private int desLocX;
        private int desLocY;

        public Wall(string direction, Vector2 desLoc)
        {
            this.Direction = direction;
            PosX = (int)desLoc.X;
            PosY = (int)desLoc.Y;


        }

        public void Update()
        {
            //static item no need to update
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (Direction.Equals("Left", StringComparison.Ordinal))
            {
                sourceLocX = 0;
                sourceLocY = 402;
                width = 118;
                height = 164;
                desLocX = 24;
                desLocY = 445;
                desWidth = 73;
                desHeight = 112;
                BoundingBox = new Rectangle(desLocX - 5, desLocY, desWidth + 5, desHeight);
            }
            else if (Direction.Equals("Right", StringComparison.Ordinal))

            {
                sourceLocX = 1080;
                sourceLocY = 402;
                width = 118;
                height = 164;
                desLocX = 698;
                desLocY = 445;
                desWidth = 73;
                desHeight = 112;
                BoundingBox = new Rectangle(desLocX, desLocY, desWidth + 5, desHeight);
            } 
            else if (Direction.Equals("Down", StringComparison.Ordinal))
            {
                sourceLocX = 517;
                sourceLocY = 765;
                width = 163;
                height = 117;
                desLocX = 347;
                desLocY = 691;
                desWidth = 103;
                desHeight = 81;
                BoundingBox = new Rectangle(desLocX, desLocY, desWidth, desHeight + 5);
            } 
            if(spriteBatch == null)
            {
                throw new ArgumentNullException(nameof(spriteBatch));
            }
            Rectangle sourceRectangle = new Rectangle(sourceLocX, sourceLocY, width, height);
            Rectangle destinationRectangle = new Rectangle(desLocX, desLocY, desWidth, desHeight);
            spriteBatch.Draw(texture, destinationRectangle, sourceRectangle, Color.White);
        }

        //method needed for non static item
        //here to implement the interface
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

    }
}
