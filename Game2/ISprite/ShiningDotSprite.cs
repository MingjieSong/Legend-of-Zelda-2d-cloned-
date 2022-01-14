 using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class ShiningDotSprite : ISprite
    {
        private Texture2D Texture;
        private int width;
        private int height;

        private int sourceLocX;
        private int sourceLocY;
        private int timer;
        private int origWidth  ;
        private int origHeight  ;

        public ShiningDotSprite(Texture2D texture, int posX, int posY, int spriteWidth, int spriteHeight)
        {
            Texture = texture;
            sourceLocX = posX;
            sourceLocY = posY;
            width = spriteWidth;
            height = spriteHeight;
            origHeight = spriteHeight;
            origWidth = spriteWidth;

        }
       

        public void Update()
        {
            timer++; 
            if (timer >= 20 && timer<=40)
            {
                //dot disappear
                width = 0;
                height = 0;
            }
            else if(timer>60)
            {
                width = origWidth;
                height = origHeight;
                timer = 0;
            }

        }

        public void Draw(SpriteBatch spriteBatch, Vector2 vector)
        {
            if (spriteBatch == null)
            {
                throw new ArgumentNullException(nameof(spriteBatch));
            }
            if (Texture != null)
            {
                Rectangle sourceRectangle = new Rectangle(sourceLocX, sourceLocY, width, height);
                Rectangle destinationRectangle = new Rectangle((int)vector.X, (int)vector.Y, width , height );

                
                spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
                

            }
        }
    }
}