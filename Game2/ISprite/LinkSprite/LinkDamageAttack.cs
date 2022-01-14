using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class LinkDamageAttack : ISprite
    {
        public Texture2D Texture { get; set; }
        private int sourceLocX;
        private int sourceLocY;
        private int width;
        private int height;
        private int totalBlink;
        private int blinkTimes;
        private int delay;
        private int totalDelay;
        private string direction;
        private Texture2D sword = Texture2DStorage.GetHurtWeaponSpriteSheet();

        public LinkDamageAttack(Texture2D texture, String d)
        {
            direction = d ?? throw new ArgumentNullException(nameof(d));
            Texture = texture;
            if (direction.Equals("Down", StringComparison.Ordinal))
            {

                sourceLocX = 239;
                sourceLocY = 1;
                width = 16;
                height = 15;
                totalBlink = 6;
                blinkTimes = 0;
                delay = 0;
                totalDelay = 30;
                sword = Texture2DStorage.GetHurtWeaponSpriteSheet();
            }
            else if (direction.Equals("Left", StringComparison.Ordinal)) {

                sourceLocX = 589;
                sourceLocY = 254;
                width = 14;
                height = 15;
                totalBlink = 5;
                blinkTimes = 0;
                delay = 0;
                totalDelay = 30;
            }
            else if (direction.Equals("Right", StringComparison.Ordinal))
            {

                sourceLocX = 131;
                sourceLocY = 254;
                width = 14;
                height = 15;
                totalBlink = 5;
                blinkTimes = 0;
                delay = 0;
                totalDelay = 30;
            }
            else if (direction.Equals("Up", StringComparison.Ordinal))
            {

                sourceLocX = 257;
                sourceLocY = 1;
                width = 16;
                height = 16;
                totalBlink = 6;
                blinkTimes = 0;
                delay = 0;
                totalDelay = 30;
                sword = Texture2DStorage.GetHurtWeaponSpriteSheet();
            }


        }
        public void Update()
        {
            if (direction.Equals("Down", StringComparison.Ordinal))
            {
                if (delay <= totalDelay / 2)
                {
                    width = 16;
                    height = 15;
                    if (blinkTimes == 0)
                    {
                        sourceLocX = 239;
                        sourceLocY = 145;
                    }
                    else if (blinkTimes == 1)
                    {
                        sourceLocX = 239;
                        sourceLocY = 91;
                    }
                    else if (blinkTimes == 2)
                    {
                        sourceLocX = 239;
                        sourceLocY = 127;
                    }
                    else if (blinkTimes == 3)
                    {
                        sourceLocX = 239;
                        sourceLocY = 253;
                    }
                    else if (blinkTimes == 4)
                    {
                        sourceLocX = 239;
                        sourceLocY = 37;
                    }
                    else if (blinkTimes == 5)
                    {
                        sourceLocX = 239;
                        sourceLocY = 271;
                    }

                }

                else if (delay > totalDelay / 2)
                {
                    width = 15;
                    height = 16;
                    if ((blinkTimes == 6) || (blinkTimes == 0))
                    {
                        sourceLocX = 77;
                        sourceLocY = 1;
                    }
                    else if ((blinkTimes == 7) || (blinkTimes == 1))
                    {
                        sourceLocX = 77;
                        sourceLocY = 145;
                    }
                    if ((blinkTimes == 8) || (blinkTimes == 2))
                    {
                        sourceLocX = 77;
                        sourceLocY = 109;
                    }
                    else if ((blinkTimes == 9) || (blinkTimes == 3))
                    {
                        sourceLocX = 77;
                        sourceLocY = 127;
                    }
                    else if ((blinkTimes == 10) || (blinkTimes == 4))
                    {
                        sourceLocX = 77;
                        sourceLocY = 145;
                    }
                    else if ((blinkTimes == 11) || (blinkTimes == 5))
                    {
                        sourceLocX = 77;
                        sourceLocY = 1;
                    }
                }
                delay++;
                blinkTimes++;

                if (blinkTimes == totalBlink)
                {
                    blinkTimes = 0;
                }
                /*
                if (delay == totalDelay)
                {
                    delay = 0;
                }*/
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
                        sourceLocY = 254;
                    }
                    else if (blinkTimes == 1)
                    {
                        sourceLocX = 589;
                        sourceLocY = 38;
                    }
                    else if (blinkTimes == 2)
                    {
                        sourceLocX = 589;
                        sourceLocY = 128;
                    }
                    else if (blinkTimes == 3)
                    {
                        sourceLocX = 589;
                        sourceLocY = 146;
                    }
                    else if (blinkTimes == 4)
                    {
                        sourceLocX = 589;
                        sourceLocY = 182;
                    }
                    else if (blinkTimes == 5)
                    {
                        sourceLocX = 589;
                        sourceLocY = 272;
                    }

                }
                else if (delay > totalDelay / 2)
                {
                    width = 15;
                    height = 16;
                    if ((blinkTimes == 6) || (blinkTimes == 0))
                    {
                        sourceLocX = 570;
                        sourceLocY = 37;
                    }
                    else if ((blinkTimes == 7) || (blinkTimes == 1))
                    {
                        sourceLocX = 570;
                        sourceLocY = 109;
                    }
                    if ((blinkTimes == 8) || (blinkTimes == 2))
                    {
                        sourceLocX = 570;
                        sourceLocY = 145;
                    }
                    else if ((blinkTimes == 9) || (blinkTimes == 3))
                    {
                        sourceLocX = 570;
                        sourceLocY = 271;
                    }
                    else if ((blinkTimes == 10) || (blinkTimes == 4))
                    {
                        sourceLocX = 570;
                        sourceLocY = 181;
                    }
                }
                delay++;
                blinkTimes++;

                if (blinkTimes == totalBlink)
                {
                    blinkTimes = 0;
                }/*
            if (delay == totalDelay)
            {
                delay = 0;
            }*/
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
                        sourceLocY = 254;
                    }
                    else if (blinkTimes == 1)
                    {
                        sourceLocX = 131;
                        sourceLocY = 38;
                    }
                    else if (blinkTimes == 2)
                    {
                        sourceLocX = 131;
                        sourceLocY = 128;
                    }
                    else if (blinkTimes == 3)
                    {
                        sourceLocX = 131;
                        sourceLocY = 146;
                    }
                    else if (blinkTimes == 4)
                    {
                        sourceLocX = 131;
                        sourceLocY = 182;
                    }
                    else if (blinkTimes == 5)
                    {
                        sourceLocX = 131;
                        sourceLocY = 272;
                    }

                }
                else if (delay > totalDelay / 2)
                {
                    width = 15;
                    height = 16;
                    if ((blinkTimes == 6) || (blinkTimes == 0))
                    {
                        sourceLocX = 149;
                        sourceLocY = 109;
                    }
                    else if ((blinkTimes == 7) || (blinkTimes == 1))
                    {
                        sourceLocX = 149;
                        sourceLocY = 127;
                    }
                    if ((blinkTimes == 8) || (blinkTimes == 2))
                    {
                        sourceLocX = 149;
                        sourceLocY = 145;
                    }
                    else if ((blinkTimes == 9) || (blinkTimes == 3))
                    {
                        sourceLocX = 149;
                        sourceLocY = 271;
                    }
                    else if ((blinkTimes == 10) || (blinkTimes == 4))
                    {
                        sourceLocX = 149;
                        sourceLocY = 181;
                    }
                }
                delay++;
                blinkTimes++;

                if (blinkTimes == totalBlink)
                {
                    blinkTimes = 0;
                }

            }
            else if (direction.Equals("Up", StringComparison.Ordinal)) {
                if (delay <= totalDelay / 2)
                {
                    width = 16;
                    height = 16;
                    if (blinkTimes == 0)
                    {
                        sourceLocX = 257;
                        sourceLocY = 145;
                    }
                    else if (blinkTimes == 1)
                    {
                        sourceLocX = 257;
                        sourceLocY = 91;
                    }
                    else if (blinkTimes == 2)
                    {
                        sourceLocX = 257;
                        sourceLocY = 127;
                    }
                    else if (blinkTimes == 3)
                    {
                        sourceLocX = 257;
                        sourceLocY = 253;
                    }
                    else if (blinkTimes == 4)
                    {
                        sourceLocX = 257;
                        sourceLocY = 37;
                    }
                    else if (blinkTimes == 5)
                    {
                        sourceLocX = 257;
                        sourceLocY = 271;
                    }

                }

                else if (delay > totalDelay / 2)
                {
                    width = 12;
                    height = 16;
                    if ((blinkTimes == 6) || (blinkTimes == 0))
                    {
                        sourceLocX = 115;
                        sourceLocY = 1;
                    }
                    else if ((blinkTimes == 7) || (blinkTimes == 1))
                    {
                        sourceLocX = 115;
                        sourceLocY = 145;
                    }
                    if ((blinkTimes == 8) || (blinkTimes == 2))
                    {
                        sourceLocX = 115;
                        sourceLocY = 109;
                    }
                    else if ((blinkTimes == 9) || (blinkTimes == 3))
                    {
                        sourceLocX = 115;
                        sourceLocY = 127;
                    }
                    else if ((blinkTimes == 10) || (blinkTimes == 4))
                    {
                        sourceLocX = 115;
                        sourceLocY = 145;
                    }
                }
                delay++;
                blinkTimes++;

                if (blinkTimes == totalBlink)
                {
                    blinkTimes = 0;
                }/*
            if (delay == totalDelay)
            {
                delay = 0;
            }*/
            }



        }

        public void Draw(SpriteBatch spriteBatch, Vector2 vector)
        {
            if (direction.Equals("Down", StringComparison.Ordinal))
            {
                if (spriteBatch == null)
                {
                    throw new ArgumentNullException(nameof(spriteBatch));
                }
                if (Texture != null)
                {
                    Rectangle sourceRectangle = new Rectangle(sourceLocX, sourceLocY, width, height);     // determine which frame
                    Rectangle destinationRectangle = new Rectangle((int)vector.X, (int)vector.Y, width * 3, height * 3);    // determine location and demension of the current frame
                    Rectangle swordsourceRectangle = new Rectangle(152, 4, 7, 16);
                    Rectangle sworddestinationRectangle = new Rectangle((int)vector.X + 15, (int)vector.Y + 35, 7 * 3, 16 * 3);

                    spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
                    if (delay <= totalDelay / 2)
                    {

                        spriteBatch.Draw(sword, sworddestinationRectangle, swordsourceRectangle, Color.White);
                    }

                }
            }
            else if (direction.Equals("Left", StringComparison.Ordinal))
            {
                if (spriteBatch == null)
                {
                    throw new ArgumentNullException(nameof(spriteBatch));
                }
                if (Texture != null)
                {
                    Rectangle sourceRectangle = new Rectangle(sourceLocX, sourceLocY, width, height);     // determine which frame
                    Rectangle destinationRectangle = new Rectangle((int)vector.X, (int)vector.Y, width * 3, height * 3);    // determine location and demension of the current frame
                    Rectangle swordsourceRectangle = new Rectangle(389, 132, 16, 7);     // determine which frame
                    Rectangle sworddestinationRectangle = new Rectangle((int)vector.X - 43, (int)vector.Y + 16, 16 * 3, 7 * 3);    // determine location and demension of the current frame


                    spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
                    if (delay <= totalDelay / 2)
                    {
                        spriteBatch.Draw(Texture, sworddestinationRectangle, swordsourceRectangle, Color.White);
                    }

                }
            }
            else if (direction.Equals("Right", StringComparison.Ordinal))
            {
                if (spriteBatch == null)
                {
                    throw new ArgumentNullException(nameof(spriteBatch));
                }
                if (Texture != null)
                {
                    Rectangle sourceRectangle = new Rectangle(sourceLocX, sourceLocY, width, height);     // determine which frame
                    Rectangle destinationRectangle = new Rectangle((int)vector.X, (int)vector.Y, width * 3, height * 3);    // determine location and demension of the current frame
                    Rectangle swordsourceRectangle = new Rectangle(329, 132, 16, 7);     // determine which frame
                    Rectangle sworddestinationRectangle = new Rectangle((int)vector.X + 30, (int)vector.Y + 16, 16 * 3, 7 * 3);    // determine location and demension of the current frame

                    if (delay <= totalDelay / 2)
                    {
                        spriteBatch.Draw(Texture, sworddestinationRectangle, swordsourceRectangle, Color.White);
                    }

                    spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);

                }
            }
            else if (direction.Equals("Up", StringComparison.Ordinal)) {
                if (spriteBatch == null)
                {
                    throw new ArgumentNullException(nameof(spriteBatch));
                }
                if (Texture != null)
                {
                    Rectangle sourceRectangle = new Rectangle(sourceLocX, sourceLocY, width, height);     // determine which frame
                    Rectangle destinationRectangle = new Rectangle((int)vector.X, (int)vector.Y, width * 3, height * 3);    // determine location and demension of the current frame

                    Rectangle swordsourceRectangle = new Rectangle(152, 64, 7, 16);     // determine which frame
                    Rectangle sworddestinationRectangle = new Rectangle((int)vector.X + 10, (int)vector.Y - 35, 7 * 3, 16 * 3);    // determine location and demension of the current frame

                    if (delay <= totalDelay / 2)
                    {
                        spriteBatch.Draw(sword, sworddestinationRectangle, swordsourceRectangle, Color.White);
                    }
                    spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);

                }
            }
            
        }

    }
}
