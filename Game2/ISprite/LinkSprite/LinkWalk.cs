using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;

namespace Sprint2
{
    public class LinkWalk : ISprite
    {
        private Texture2D Texture;
        private int width;
        private int height;
        private int sourceLocX;
        private int sourceLocY;
        private int delay;
        private int totalDelay;
        private string direction;




        public LinkWalk(Texture2D texture, string d)
        {
            direction = d;
            Texture = texture;

            if (direction.Equals("Down", StringComparison.Ordinal))
            {
                width = 15;
                height = 16;
                sourceLocX = 0;
                sourceLocY = 0;
                delay = 0;
                totalDelay = 10;
            }
            else if (direction.Equals("Left", StringComparison.Ordinal))
            {
                width = 15;
                height = 16;
                sourceLocX = 30;
                sourceLocY = 31;
                delay = 0;
                totalDelay = 10;
            }
            else if (direction.Equals("Right", StringComparison.Ordinal))
            {
                width = 15;
                height = 16;
                sourceLocX = 90;
                sourceLocY = 0;
                delay = 0;
                totalDelay = 10;
            }
            else if (direction.Equals("Up", StringComparison.Ordinal)) {
                width = 15;
                height = 16;
                sourceLocX = 60;
                sourceLocY = 30;
                delay = 0;
                totalDelay = 10;
            }
        }


        public void Update()
        {
            if (direction.Equals("Down"))
            {
                if (delay > totalDelay / 2)
                {

                    sourceLocY = 0;
                    if (delay == totalDelay)
                    {
                        delay = 0;
                    }
                }
                else
                {

                    sourceLocY = 30;
                }
                delay++;



                Link.posY += 2;
            }
            else if (direction.Equals("Left"))
            {
                if (delay > totalDelay / 2)
                {

                    width = 15;
                    height = 16;
                    sourceLocX = 30;
                    sourceLocY = 0;
                    if (delay == totalDelay)
                    {
                        delay = 0;
                    }
                }
                else
                {

                    width = 14;
                    height = 15;
                    sourceLocX = 31;
                    sourceLocY = 30;
                }
                delay++;


                Link.posX -= 2;
            }
            else if (direction.Equals("Right"))
            {
                if (delay > totalDelay / 2)
                {

                    width = 15;
                    height = 16;
                    sourceLocX = 90;
                    sourceLocY = 30;
                    if (delay == totalDelay)
                    {
                        delay = 0;
                    }

                }
                else
                {
                    width = 14;
                    height = 15;
                    sourceLocX = 91;
                    sourceLocY = 0;
                }
                delay++;



                Link.posX += 2;
            }
            else if (direction.Equals("Up")) {
                if (delay > totalDelay / 2)
                {
                    sourceLocY = 0;
                    if (delay == totalDelay)
                    {
                        delay = 0;
                    }
                }
                else
                {
                    sourceLocY = 30;
                }
                delay++;


                Link.posY -= 2;
            }
            


        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            if (spriteBatch == null)
            {
                throw new System.ArgumentNullException(nameof(spriteBatch));
            }
            Rectangle sourceRectangle = new Rectangle(sourceLocX, sourceLocY, width, height);
            Rectangle destinationRectangle = new Rectangle(Link.posX, Link.posY, width * 3, height * 3);


            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);

        }
    }
}
