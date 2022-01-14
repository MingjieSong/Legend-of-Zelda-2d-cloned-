using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;

namespace Sprint2
{
    public class Box : IItem
    {
        //this part only needed for link item
        public int Count { get; set; } = 0;
        public int TotalCount { get; set; } = 100;
        public bool Appear { get; set; } = true;
        private int p = 100;
        //Sprite parameters
        private Texture2D texture = Texture2DStorage.GetBlockSpriteSheet();
        private int sourceLocX =1254;
        private int sourceLocY=643;
        private int width=80 ;
        private int height=80;

        private int desWidth=52;
        private int desHeight=53;
      
        public int PosX { get; set; }
        public int PosY { get; set; } 
        public Rectangle BoundingBox { get; set; }
        

        public Box(  Vector2 desLoc)
        {
            
            PosX = (int)desLoc.X;
            PosY = (int)desLoc.Y; 
            BoundingBox = new Rectangle(PosX, PosY, desWidth, desHeight);


        }

        public void Update()
        {
            BoundingBox = new Rectangle(PosX, PosY, desWidth, desHeight);
             
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if(spriteBatch == null)
            {
                throw new ArgumentNullException(nameof(spriteBatch));
            }
            Rectangle sourceRectangle = new Rectangle(sourceLocX, sourceLocY, width, height);
            Rectangle destinationRectangle = new Rectangle(PosX, PosY, desWidth, desHeight);
            spriteBatch.Draw(texture, destinationRectangle, sourceRectangle, Color.White);
        }

        //method needed for non static item
        //here to implement the interface
        public int GetItem()
        {
            return p;
        }
        public static void ChangeState()
        {
            //do nothing
        }

        public void ChangeSprite(ISprite sprite)
        {
            //do nothing
        }

    }
}
