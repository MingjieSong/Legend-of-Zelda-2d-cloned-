using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

/*Find the sprite in enemy2.png*/
namespace Sprint2
{
    class FlameSilentBurningSprite : ISprite
    {
        public Texture2D Texture;
        private int sourceLocX = 300;
        private int sourceLocY = 0;
        private int width = 16;
        private int height = 16;

        private int delay = 0;
        private int totalDelay = 10;

       
        public FlameSilentBurningSprite(Texture2D texture)
        {
            Texture = texture;
        }

        public FlameSilentBurningSprite()
        {
            //another constructor, show nothing
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            if (spriteBatch == null)
            {
                throw new ArgumentNullException(nameof(spriteBatch));
            }
            if (Texture != null)
            {
                Rectangle sourceRectangle = new Rectangle(sourceLocX, sourceLocY, width, height);
                Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, width * 2, height * 2);

                spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            }
        }

        public void Update()
        {
            if (delay > totalDelay / 2)
            {

                width = 16;
                height = 16;
                sourceLocX = 300;
                sourceLocY = 0;
                if (delay == totalDelay)
                {
                    delay = 0;
                }
            }
            else
            {

                width = 16;
                height = 16;
                sourceLocX = 300;
                sourceLocY = 30;
            }
            delay++;
        }
    }
}
