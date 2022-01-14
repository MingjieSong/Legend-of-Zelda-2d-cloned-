using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class LinkDamageStand : ISprite
    {
        private Texture2D Texture;
        private int sourceLocX = 77;
        private int sourceLocY = 1;
        private int width = 15;
        private int height = 16;
        private int blinkTimes = 0;
        private int totalBlink = 5;
        private string direction;

        public LinkDamageStand(Texture2D texture, String d)
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
                totalBlink = 5;

            }
            else if (direction.Equals("Left", StringComparison.Ordinal))
            {
                sourceLocX = 570;
                sourceLocY = 1;
                width = 15;
                height = 16;
                blinkTimes = 0;
                totalBlink = 5;
            }
            else if (direction.Equals("Right", StringComparison.Ordinal))
            {
                sourceLocX = 149;
                sourceLocY = 1;
                width = 15;
                height = 16;
                blinkTimes = 0;
                totalBlink = 5;
            }
            else if (direction.Equals("Up", StringComparison.Ordinal)) {
                sourceLocX = 607;
                sourceLocY = 1;
                width = 12;
                height = 16;
                blinkTimes = 0;
                totalBlink = 5;
            }
        }


        public void Update()
        {
            if (direction.Equals("Down", StringComparison.Ordinal))
            {
                if (blinkTimes == 0)
                {

                    sourceLocY = 1;
                }
                else if (blinkTimes == 1)
                {

                    sourceLocY = 145;
                }
                else if (blinkTimes == 2)
                {

                    sourceLocY = 109;
                }
                else if (blinkTimes == 3)
                {

                    sourceLocY = 127;
                }
                else if (blinkTimes == 4)
                {

                    sourceLocY = 145;
                }


                blinkTimes++;
                if (blinkTimes == totalBlink)
                {

                    blinkTimes = 0;
                }
            }
            else if (direction.Equals("Left", StringComparison.Ordinal))
            {
                if (blinkTimes == 0)
                {

                    sourceLocY = 1;
                }
                else if (blinkTimes == 1)
                {

                    sourceLocY = 145;
                }
                else if (blinkTimes == 2)
                {

                    sourceLocY = 109;
                }
                else if (blinkTimes == 3)
                {

                    sourceLocY = 127;
                }
                else if (blinkTimes == 4)
                {

                    sourceLocY = 145;
                }


                blinkTimes++;
                if (blinkTimes == totalBlink)
                {
                    blinkTimes = 0;
                }
            }
            else if (direction.Equals("Right", StringComparison.Ordinal))
            {
                if (blinkTimes == 0)
                {

                    sourceLocY = 1;
                }
                else if (blinkTimes == 1)
                {

                    sourceLocY = 145;
                }
                else if (blinkTimes == 2)
                {

                    sourceLocY = 109;
                }
                else if (blinkTimes == 3)
                {

                    sourceLocY = 127;
                }
                else if (blinkTimes == 4)
                {

                    sourceLocY = 145;
                }


                blinkTimes++;
                if (blinkTimes == totalBlink)
                {
                    blinkTimes = 0;
                }
            }
            else if (direction.Equals("Up", StringComparison.Ordinal)) {
                if (blinkTimes == 0)
                {

                    sourceLocY = 1;
                }
                else if (blinkTimes == 1)
                {

                    sourceLocY = 145;
                }
                else if (blinkTimes == 2)
                {

                    sourceLocY = 109;
                }
                else if (blinkTimes == 3)
                {

                    sourceLocY = 127;
                }
                else if (blinkTimes == 4)
                {

                    sourceLocY = 145;
                }


                blinkTimes++;
                if (blinkTimes == totalBlink)
                {
                    blinkTimes = 0;
                }
            }

            

        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            
                if (spriteBatch == null)
                {
                    throw new ArgumentNullException(nameof(spriteBatch));
                }
                Rectangle sourceRectangle = new Rectangle(sourceLocX, sourceLocY, width, height);
                Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, width * 3, height * 3);

                spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);

        }
    }
}
