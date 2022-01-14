using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class LinkAttack : ISprite
    {
        public Texture2D Texture { get; set; }
        private int posX;
        private int posY;
        private int width;
        private int height;
        private int delay;
        private int totalDelay;
        private string direction;
        public LinkAttack(Texture2D texture, string d)
        {
            direction = d ?? throw new ArgumentNullException(nameof(d));
            Texture = texture;
            if (direction.Equals("Down", StringComparison.Ordinal))
            {
                posX = 0;
                posY = 0;
                width = 15;
                height = 16;
                delay = 0;
                totalDelay = 25;
            }
            else if (direction.Equals("Left", StringComparison.Ordinal))
            {
                posX = 30;
                posY = 0;
                width = 15;
                height = 16;
                delay = 0;
                totalDelay = 25;
            }
            else if (direction.Equals("Right", StringComparison.Ordinal))
            {
                posX = 90;
                posY = 30;
                width = 15;
                height = 16;
                delay = 0;
                totalDelay = 25;
            }
            else if (direction.Equals("Up", StringComparison.Ordinal)) {
                posX = 62;
                posY = 0;
                width = 15;
                height = 16;
                delay = 0;
                totalDelay = 25;
            }


        }
        public void Update()
        {
            if (direction.Equals("Down", StringComparison.Ordinal))
            {
                if (delay <= totalDelay / 5)
                {
                    posX = 0;
                    posY = 0;
                    width = 15;
                    height = 16;
                }


                if (delay > totalDelay / 5 && delay < 2 * totalDelay / 5)
                {
                    posX = 1;
                    posY = 30;
                    width = 13;
                    height = 16;

                }
                if (delay >= 2 * totalDelay / 5 && delay < 3 * totalDelay / 5)
                {

                    posX = 0;
                    posY = 60;
                    width = 16;
                    height = 15;
                }

                if (delay >= 3 * totalDelay / 6 && delay < 5 * totalDelay / 5)
                {

                    posX = 0;
                    posY = 84;
                    width = 16;
                    height = 27;
                }

                delay++;
                if (delay == totalDelay)
                {
                    posX = 0;
                    posY = 0;
                    width = 15;
                    height = 16;
                }
            }
            else if (direction.Equals("Left", StringComparison.Ordinal))
            {
                if (delay <= totalDelay / 5)
                {
                    posX = 30;
                    posY = 0;
                    width = 15;
                    height = 16;
                }


                if (delay > totalDelay / 5 && delay < 2 * totalDelay / 5)
                {
                    posX = 31;
                    posY = 30;
                    width = 14;
                    height = 15;

                }
                if (delay >= 2 * totalDelay / 5 && delay < 3 * totalDelay / 5)
                {

                    posX = 30;
                    posY = 60;
                    width = 15;
                    height = 15;
                }

                if (delay >= 3 * totalDelay / 5 && delay < 5 * totalDelay / 5)
                {

                    posX = 24;
                    posY = 90;
                    width = 27;
                    height = 15;
                }

                delay++;
                if (delay == totalDelay)
                {
                    posX = 30;
                    posY = 0;
                    width = 15;
                    height = 16;
                }
            }
            else if (direction.Equals("Right", StringComparison.Ordinal))
            {
                if (delay <= totalDelay / 5)
                {
                    posX = 90;
                    posY = 30;
                    width = 15;
                    height = 16;

                }
                if (delay > totalDelay / 5 && delay < 2 * totalDelay / 5)
                {
                    posX = 91;
                    posY = 0;
                    width = 14;
                    height = 15;

                }
                if (delay >= 2 * totalDelay / 5 && delay < 3 * totalDelay / 5)
                {

                    posX = 90;
                    posY = 60;
                    width = 15;
                    height = 15;
                }

                if (delay >= 3 * totalDelay / 5 && delay < 5 * totalDelay / 5)
                {

                    posX = 84;
                    posY = 90;
                    width = 27;
                    height = 15;
                }
                delay++;
                if (delay == totalDelay)
                {
                    posX = 90;
                    posY = 30;
                    width = 15;
                    height = 16;
                }
            }
            else if (direction.Equals("Up", StringComparison.Ordinal)) {
                if (delay <= totalDelay / 5)
                {
                    posX = 62;
                    posY = 0;
                    width = 12;
                    height = 16;
                }

                if (delay > totalDelay / 5 && delay < 2 * totalDelay / 5)
                {
                    posX = 62;
                    posY = 30;
                    width = 12;
                    height = 16;

                }
                if (delay >= 2 * totalDelay / 5 && delay < 3 * totalDelay / 5)
                {

                    posX = 60;
                    posY = 60;
                    width = 16;
                    height = 16;
                }

                if (delay >= 3 * totalDelay / 5 && delay < 5 * totalDelay / 5)
                {

                    posX = 60;
                    posY = 84;
                    width = 16;
                    height = 28;
                }

                delay++;
                if (delay == totalDelay)
                {
                    posX = 62;
                    posY = 0;
                    width = 12;
                    height = 16;
                }
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
                    Rectangle sourceRectangle = new Rectangle(posX, posY, width, height);     // determine which frame
                    Rectangle destinationRectangle = new Rectangle((int)vector.X, (int)vector.Y, width * 3, height * 3);    // determine location and demension of the current frame


                    spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);

                }
          
        }

    }
}

