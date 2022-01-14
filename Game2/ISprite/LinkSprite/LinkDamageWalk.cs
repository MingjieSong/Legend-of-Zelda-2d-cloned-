using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
namespace Sprint2
{
    public class LinkDamageWalk : ISprite
    {
        private Texture2D Texture;
        private int sourceLocX;
        private int sourceLocY;
        private int width;
        private int height;
        private int blinkTimes;
        private int totalBlink;
        private int delay;
        private int totalDelay;
        private string direction;

        public LinkDamageWalk(Texture2D texture,string d)
        {
            direction = d;
            Texture = texture;
            if (direction.Equals("Down", StringComparison.Ordinal))
            {
                sourceLocX = 77;
                sourceLocY = 1;
                width = 15;
                height = 16;
                blinkTimes = 0;
                totalBlink = 10;
                delay = 0;
                totalDelay = 30;
            }
            else if (direction.Equals("Left", StringComparison.Ordinal)) {
                sourceLocX = 589;
                sourceLocY = 2;
                width = 14;
                height = 15;
                blinkTimes = 0;
                totalBlink = 10;
                delay = 0;
                totalDelay = 30;
            }
            else if (direction.Equals("Right", StringComparison.Ordinal))
            {
                sourceLocX = 131;
                sourceLocY = 2;
                width = 14;
                height = 15;
                blinkTimes = 0;
                totalBlink = 10;
                delay = 0;
                totalDelay = 30;
            }
            else if (direction.Equals("Up", StringComparison.Ordinal))
            {
                sourceLocX = 115;
                sourceLocY = 2;
                width = 14;
                height = 15;
                blinkTimes = 0;
                totalBlink = 10;
                delay = 0;
                totalDelay = 30;
            }
        }


        public void Update()
        {
            if (direction.Equals("Down", StringComparison.Ordinal))
            {
                if (delay < totalDelay / 2)
                {
                    width = 13;
                    height = 16;
                    if (blinkTimes == 0)
                    {
                        sourceLocX = 96;
                        sourceLocY = 1;
                    }
                    else if (blinkTimes == 1)
                    {
                        sourceLocX = 96;
                        sourceLocY = 145;
                    }
                    else if (blinkTimes == 2)
                    {
                        sourceLocX = 96;
                        sourceLocY = 109;
                    }
                    else if (blinkTimes == 3)
                    {
                        sourceLocX = 96;
                        sourceLocY = 127;
                    }
                    else if (blinkTimes == 4)
                    {
                        sourceLocX = 96;
                        sourceLocY = 145;
                    }
                }
                else
                {
                    width = 15;
                    height = 16;
                    if (blinkTimes == 5)
                    {
                        sourceLocX = 77;
                        sourceLocY = 1;
                    }
                    else if (blinkTimes == 6)
                    {
                        sourceLocX = 77;
                        sourceLocY = 145;
                    }
                    else if (blinkTimes == 7)
                    {
                        sourceLocX = 77;
                        sourceLocY = 127;
                    }
                    else if (blinkTimes == 8)
                    {
                        sourceLocX = 77;
                        sourceLocY = 1;
                    }
                    else if (blinkTimes == 9)
                    {
                        sourceLocX = 77;
                        sourceLocY = 145;
                    }

                }
                delay++;
                blinkTimes++;
                if (delay == totalDelay)
                {
                    delay = 0;
                }
                if (blinkTimes == totalBlink)
                {
                    blinkTimes = 0;
                }


                Link.posY++;
            }
            else if (direction.Equals("Left", StringComparison.Ordinal))
            {
                if (delay <= totalDelay / 2)
                {
                    width = 14;
                    height = 15;
                    if (blinkTimes == 0)
                    {
                        sourceLocX = 589;
                        sourceLocY = 2;
                    }
                    else if (blinkTimes == 1)
                    {
                        sourceLocX = 589;
                        sourceLocY = 146;
                    }
                    else if (blinkTimes == 2)
                    {
                        sourceLocX = 589;
                        sourceLocY = 110;
                    }
                    else if (blinkTimes == 3)
                    {
                        sourceLocX = 589;
                        sourceLocY = 128;
                    }
                    else if (blinkTimes == 4)
                    {
                        sourceLocX = 589;
                        sourceLocY = 146;
                    }
                    if (delay == totalDelay)
                    {
                        delay = 0;
                    }
                }
                else
                {
                    width = 15;
                    height = 16;
                    if (blinkTimes == 5)
                    {
                        sourceLocX = 570;
                        sourceLocY = 1;
                    }
                    else if (blinkTimes == 6)
                    {
                        sourceLocX = 570;
                        sourceLocY = 145;
                    }
                    else if (blinkTimes == 7)
                    {
                        sourceLocX = 570;
                        sourceLocY = 109;
                    }
                    else if (blinkTimes == 8)
                    {
                        sourceLocX = 570;
                        sourceLocY = 127;
                    }
                    else if (blinkTimes == 9)
                    {
                        sourceLocX = 570;
                        sourceLocY = 145;
                    }
                }

                delay++;
                blinkTimes++;
                if (delay == totalDelay)
                {
                    delay = 0;
                }
                if (blinkTimes == totalBlink)
                {
                    blinkTimes = 0;
                }


                Link.posX--;
            }
            else if (direction.Equals("Right", StringComparison.Ordinal))
            {
                if (delay <= totalDelay / 2)
                {
                    width = 14;
                    height = 15;
                    if (blinkTimes == 0)
                    {
                        sourceLocX = 131;
                        sourceLocY = 2;
                    }
                    else if (blinkTimes == 1)
                    {
                        sourceLocX = 131;
                        sourceLocY = 146;
                    }
                    else if (blinkTimes == 2)
                    {
                        sourceLocX = 131;
                        sourceLocY = 110;
                    }
                    else if (blinkTimes == 3)
                    {
                        sourceLocX = 131;
                        sourceLocY = 128;
                    }
                    else if (blinkTimes == 4)
                    {
                        sourceLocX = 131;
                        sourceLocY = 146;
                    }
                    if (delay == totalDelay)
                    {
                        delay = 0;
                    }
                }
                else
                {
                    width = 15;
                    height = 16;
                    if (blinkTimes == 5)
                    {
                        sourceLocX = 149;
                        sourceLocY = 1;
                    }
                    else if (blinkTimes == 6)
                    {
                        sourceLocX = 149;
                        sourceLocY = 145;
                    }
                    else if (blinkTimes == 7)
                    {
                        sourceLocX = 149;
                        sourceLocY = 109;
                    }
                    else if (blinkTimes == 8)
                    {
                        sourceLocX = 149;
                        sourceLocY = 127;
                    }
                    else if (blinkTimes == 9)
                    {
                        sourceLocX = 149;
                        sourceLocY = 145;
                    }
                }

                delay++;
                blinkTimes++;
                if (delay == totalDelay)
                {
                    delay = 0;
                }
                if (blinkTimes == totalBlink)
                {
                    blinkTimes = 0;
                }

                //moving left and right 

                Link.posX++;

            }
            else if (direction.Equals("Up", StringComparison.Ordinal)) {
                if (delay <= totalDelay / 2)
                {
                    width = 12;
                    height = 16;
                    if (blinkTimes == 0)
                    {
                        sourceLocX = 115;
                        sourceLocY = 1;
                    }
                    else if (blinkTimes == 1)
                    {
                        sourceLocX = 115;
                        sourceLocY = 145;
                    }
                    else if (blinkTimes == 2)
                    {
                        sourceLocX = 115;
                        sourceLocY = 127;
                    }
                    else if (blinkTimes == 3)
                    {
                        sourceLocX = 115;
                        sourceLocY = 1;
                    }
                    else if (blinkTimes == 4)
                    {
                        sourceLocX = 115;
                        sourceLocY = 145;
                    }
                    if (delay == totalDelay)
                    {
                        delay = 0;
                    }
                }
                else
                {
                    if (blinkTimes == 5)
                    {
                        sourceLocX = 607;
                        sourceLocY = 1;
                    }
                    else if (blinkTimes == 6)
                    {
                        sourceLocX = 607;
                        sourceLocY = 145;
                    }
                    else if (blinkTimes == 7)
                    {
                        sourceLocX = 607;
                        sourceLocY = 109;
                    }
                    else if (blinkTimes == 8)
                    {
                        sourceLocX = 607;
                        sourceLocY = 127;
                    }
                    else if (blinkTimes == 9)
                    {
                        sourceLocX = 607;
                        sourceLocY = 145;
                    }
                }

                delay++;
                blinkTimes++;
                if (delay == totalDelay)
                {
                    delay = 0;
                }
                if (blinkTimes == totalBlink)
                {
                    blinkTimes = 0;
                }


                Link.posY--;
            }


        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            if (spriteBatch == null)
            {
                throw new ArgumentNullException(nameof(spriteBatch));
            }
            Rectangle sourceRectangle = new Rectangle(sourceLocX, sourceLocY, width, height);
            Rectangle destinationRectangle = new Rectangle(Link.posX, Link.posY, width * 3, height * 3);


            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);

        }
    }
}
