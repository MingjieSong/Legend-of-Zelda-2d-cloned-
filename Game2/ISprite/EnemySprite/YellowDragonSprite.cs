using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{

    public class YellowDragonSprite : ISprite
    {
        private Texture2D Texture;
        private int width;
        private int height;
        private int sourceLocX;
        private int sourceLocY;

        private int delay = 0;
        private int totalDelay = 20;

        private IEnemy Dragon;
        private string direction;

        public YellowDragonSprite(Texture2D texture, IEnemy dragon, string direction)
        {
            Texture = texture;
            Dragon = dragon;
            this.direction = direction;
        }

        public void Update()
        {
            if (direction.Equals("Down", StringComparison.Ordinal))
            {
                if (Level1.roomUpdate)
                {
                    width = 15;
                    height = 16;
                    sourceLocX = 1;
                    sourceLocY = 91;
                    if (delay > totalDelay / 4 && delay < 2 * totalDelay / 4)
                    {
                        sourceLocY = 121;
                        width = 16;
                    }
                    if (delay >= 2 * totalDelay / 4 && delay < totalDelay)
                    {
                        sourceLocY = 151;
                        width = 16;
                    }
                    delay++;
                    if (delay == totalDelay)
                    {
                        delay = 0;
                    }

                    Dragon.posY++;
                }
            }
            else if (direction.Equals("Up", StringComparison.Ordinal))
            {
                if (Level1.roomUpdate)
                {
                    width = 15;
                    height = 16;
                    sourceLocX = 61;
                    sourceLocY = 91;
                    if (delay > totalDelay / 4 && delay < 2 * totalDelay / 4)
                    {
                        sourceLocY = 121;

                    }
                    if (delay >= 2 * totalDelay / 4 && delay < totalDelay)
                    {
                        sourceLocY = 151;
                        width = 16;
                    }

                    delay++;
                    if (delay == totalDelay)
                    {
                        delay = 0;
                    }


                    Dragon.posY--;
                }
            }
            else if (direction.Equals("Right", StringComparison.Ordinal))
            {
                if (Level1.roomUpdate)
                {
                    width = 28;
                    height = 15;
                    sourceLocX = 85;
                    sourceLocY = 91;
                    if (delay == totalDelay)
                    {
                        delay = 0;

                    }

                    if (delay > totalDelay / 4 && delay < 2 * totalDelay / 4)
                    {
                        sourceLocY = 121;
                        width = 28;
                        height = 16;
                    }
                    if (delay >= 2 * totalDelay / 4 && delay < totalDelay)
                    {
                        sourceLocX = 83;
                        sourceLocY = 151;
                        width = 32;
                        height = 16;

                    }

                    delay++;


                    Dragon.posX++;
                }
            }
            else if (direction.Equals("Left", StringComparison.Ordinal))
            {
                if (Level1.roomUpdate)
                {
                    width = 25;
                    height = 15;
                    sourceLocX = 25;
                    sourceLocY = 91;
                    if (delay == totalDelay)
                    {
                        delay = 0;

                    }

                    if (delay > totalDelay / 4 && delay < 2 * totalDelay / 4)
                    {
                        sourceLocY = 121;
                        height = 16;
                    }
                    if (delay >= 2 * totalDelay / 4 && delay < totalDelay)
                    {
                        sourceLocX = 23;
                        sourceLocY = 151;
                        width = 32;
                        height = 16;

                    }

                    delay++;

                    Dragon.posX--;
                }
            }


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
                Rectangle destinationRectangle = new Rectangle(Dragon.posX, Dragon.posY, width * 3, height * 3);


                spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);

            }
        }
    }
}
