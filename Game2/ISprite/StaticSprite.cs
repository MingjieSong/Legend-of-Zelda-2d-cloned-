 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class StaticSprite : ISprite
    {
        private Texture2D Texture;
        private int width;
        private int height;

        private int sourceLocX;
        private int sourceLocY;



        public StaticSprite(Texture2D texture, int posX, int posY, int spriteWidth, int spriteHeight)
        {
            Texture = texture;
            sourceLocX = posX;
            sourceLocY = posY;
            width = spriteWidth;
            height = spriteHeight;

        }
       

        public void Update()
        {
            //do nothing

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
                Rectangle destinationRectangle = new Rectangle((int)vector.X, (int)vector.Y, width * 3, height * 3);

                
                spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
                

            }
        }
    }
}