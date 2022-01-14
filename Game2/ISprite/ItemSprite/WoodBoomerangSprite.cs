using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class WoodBoomerangSprite : ISprite
    {
        public Texture2D Texture { get; set; }
        private int posX;
        private int posY;
        private int width;
        private int height;

        private int boom = 0;
        private int totalBoom = 24;
        private IItem boomerang;
        private string direction;

        public WoodBoomerangSprite(Texture2D texture, IItem boomerang, string d)
        {
            Texture = texture;
            this.boomerang = boomerang;
            this.direction = d ?? throw new ArgumentNullException(nameof(d));
        }

        public void Update()
        {

            if (direction.Equals("Down", StringComparison.Ordinal))
            {
                if (boom == 0)
                {
                    posX = 37;
                    posY = 4;
                    width = 8;
                    height = 5;

                }

                else if (boom == 2 * 2) //4
                {
                    posX = 53;
                    posY = 6;
                    width = 9;
                    height = 9;
                    boomerang.PosY += 12;
                }
                else if (boom == 4 * 2) //5
                {
                    posX = 73;
                    posY = 3;
                    width = 5;
                    height = 8;
                    boomerang.PosY += 12;
                }
                else if (boom == 6 * 2) //6
                {
                    posX = 87;
                    posY = 5;
                    width = 9;
                    height = 9;
                    boomerang.PosY += 12;
                }
                else if (boom == 8 * 2) //7
                {
                    posX = 105;
                    posY = 5;
                    width = 8;
                    height = 5;
                    boomerang.PosY += 12;
                }
                else if (boom == 10 * 2) //8
                {
                    posX = 122;
                    posY = 5;
                    width = 9;
                    height = 9;
                    boomerang.PosY -= 12;
                }
                else if (boom == 12 * 2) //9
                {
                    posX = 4;
                    posY = 3;
                    width = 5;
                    height = 8;
                    boomerang.PosY -= 12;
                }
                else if (boom == 14 * 2) //2
                {
                    posX = 20;
                    posY = 6;
                    width = 9;
                    height = 9;
                    boomerang.PosY -= 12;

                }
                else if (boom == 16 * 2) //3
                {
                    posX = 37;
                    posY = 4;
                    width = 8;
                    height = 5;
                    boomerang.PosY -= 12;

                }
                else if (boom == 18 * 2) //4
                {
                    posX = 53;
                    posY = 6;
                    width = 9;
                    height = 9;
                    boomerang.PosY -= 12;

                }
                else if (boom == 20 * 2) //5
                {
                    posX = 73;
                    posY = 3;
                    width = 5;
                    height = 8;
                    boomerang.PosY -= 12;

                }
                else if (boom == 22 * 2) //6
                {
                    posX = 87;
                    posY = 5;
                    width = 9;
                    height = 9;
                    boomerang.PosY -= 12;

                }

                else if (boom == totalBoom * 2) //7 return boom
                {
                    posX = 105;
                    posY = 5;
                    width = 8;
                    height = 5;

                }
            }
            else if (direction.Equals("Up", StringComparison.Ordinal))
            {
                if (boom == 0)
                {
                    posX = 37;
                    posY = 4;
                    width = 8;
                    height = 5;

                }
                else if (boom == 2 * 2) //4
                {
                    posX = 53;
                    posY = 6;
                    width = 9;
                    height = 9;
                    boomerang.PosY -= 12;
                }
                else if (boom == 4 * 2) //5
                {
                    posX = 73;
                    posY = 3;
                    width = 5;
                    height = 8;
                    boomerang.PosY -= 12;
                }
                else if (boom == 6 * 2) //6
                {
                    posX = 87;
                    posY = 5;
                    width = 9;
                    height = 9;
                    boomerang.PosY -= 12;
                }
                else if (boom == 8 * 2) //7
                {
                    posX = 105;
                    posY = 5;
                    width = 8;
                    height = 5;
                    boomerang.PosY -= 12;
                }
                else if (boom == 10 * 2) //8
                {
                    posX = 122;
                    posY = 5;
                    width = 9;
                    height = 9;
                    boomerang.PosY -= 12;
                }
                else if (boom == 12 * 2) //9
                {
                    posX = 4;
                    posY = 3;
                    width = 5;
                    height = 8;
                    boomerang.PosY -= 12;
                }
                else if (boom == 14 * 2) //2
                {
                    posX = 20;
                    posY = 6;
                    width = 9;
                    height = 9;
                    boomerang.PosY += 12;

                }
                else if (boom == 16 * 2) //3
                {
                    posX = 37;
                    posY = 4;
                    width = 8;
                    height = 5;
                    boomerang.PosY += 12;
                }
                else if (boom == 18 * 2) //4
                {
                    posX = 53;
                    posY = 6;
                    width = 9;
                    height = 9;
                    boomerang.PosY += 12;
                }
                else if (boom == 20 * 2) //5
                {
                    posX = 73;
                    posY = 3;
                    width = 5;
                    height = 8;
                    boomerang.PosY += 12;
                }
                else if (boom == 22 * 2) //6
                {
                    posX = 87;
                    posY = 5;
                    width = 9;
                    height = 9;
                    boomerang.PosY += 12;
                }

                else if (boom == totalBoom * 2) //7 return boom
                {
                    posX = 105;
                    posY = 5;
                    width = 8;
                    height = 5;

                }
            }
            else if (direction.Equals("Right", StringComparison.Ordinal))
            {
                if (boom == 0) //5
                {
                    posX = 73;
                    posY = 3;
                    width = 5;
                    height = 8;

                }
                else if (boom == 2 * 2) //6
                {
                    posX = 87;
                    posY = 5;
                    width = 9;
                    height = 9;
                    boomerang.PosX += 12;
                }
                else if (boom == 4 * 2) //7
                {
                    posX = 105;
                    posY = 5;
                    width = 8;
                    height = 5;
                    boomerang.PosX += 12;
                }
                else if (boom == 6 * 2) //8
                {
                    posX = 122;
                    posY = 5;
                    width = 9;
                    height = 9;
                    boomerang.PosX += 12;
                }
                else if (boom == 8 * 2) //1
                {
                    posX = 4;
                    posY = 3;
                    width = 5;
                    height = 8;
                    boomerang.PosX += 12;
                }
                else if (boom == 10 * 2) //2
                {
                    posX = 20;
                    posY = 6;
                    width = 9;
                    height = 9;
                    boomerang.PosX += 12;
                }
                else if (boom == 12 * 2) //3
                {
                    posX = 37;
                    posY = 4;
                    width = 8;
                    height = 5;
                    boomerang.PosX += 12;
                }
                else if (boom == 14 * 2) //4
                {
                    posX = 53;
                    posY = 6;
                    width = 9;
                    height = 9;
                    boomerang.PosX -= 12;
                }
                else if (boom == 16 * 2) //5
                {
                    posX = 73;
                    posY = 3;
                    width = 5;
                    height = 8;
                    boomerang.PosX -= 12;
                }
                else if (boom == 18 * 2) //6
                {
                    posX = 87;
                    posY = 5;
                    width = 9;
                    height = 9;
                    boomerang.PosX -= 12;

                }
                else if (boom == 20 * 2) //7
                {
                    posX = 105;
                    posY = 5;
                    width = 8;
                    height = 5;
                    boomerang.PosX -= 12;
                }
                else if (boom == 22 * 2) //8
                {
                    posX = 122;
                    posY = 5;
                    width = 9;
                    height = 9;
                    boomerang.PosX -= 12;
                }

                else if (boom == totalBoom * 2) //1 return boom
                {
                    posX = 4;
                    posY = 3;
                    width = 5;
                    height = 8;

                }
            }
            else if (direction.Equals("Left", StringComparison.Ordinal))
            {
                if (boom == 0)
                {
                    posX = 4;
                    posY = 3;
                    width = 5;
                    height = 8;

                }
                else if (boom == 2 * 2) //2
                {
                    posX = 20;
                    posY = 6;
                    width = 9;
                    height = 9;
                    boomerang.PosX -= 12;

                }
                else if (boom == 4 * 2) //3
                {
                    posX = 37;
                    posY = 4;
                    width = 8;
                    height = 5;
                    boomerang.PosX -= 12;
                }
                else if (boom == 6 * 2) //4
                {
                    posX = 53;
                    posY = 6;
                    width = 9;
                    height = 9;
                    boomerang.PosX -= 12;
                }
                else if (boom == 8 * 2) //5
                {
                    posX = 73;
                    posY = 3;
                    width = 5;
                    height = 8;
                    boomerang.PosX -= 12;
                }
                else if (boom == 10 * 2) //6
                {
                    posX = 87;
                    posY = 5;
                    width = 9;
                    height = 9;
                    boomerang.PosX -= 12;
                }
                else if (boom == 12 * 2) //7
                {
                    posX = 105;
                    posY = 5;
                    width = 8;
                    height = 5;
                    boomerang.PosX -= 12;
                }
                else if (boom == 14 * 2) //8
                {
                    posX = 122;
                    posY = 5;
                    width = 9;
                    height = 9;
                    boomerang.PosX += 12;
                }
                else if (boom == 16 * 2) //1
                {
                    posX = 4;
                    posY = 3;
                    width = 5;
                    height = 8;
                    boomerang.PosX += 12;
                }
                else if (boom == 18 * 2) //2
                {
                    posX = 20;
                    posY = 6;
                    width = 9;
                    height = 9;
                    boomerang.PosX += 12;

                }
                else if (boom == 20 * 2) //3
                {
                    posX = 37;
                    posY = 4;
                    width = 8;
                    height = 5;
                    boomerang.PosX += 12;
                }
                else if (boom == 22 * 2) //4
                {
                    posX = 53;
                    posY = 6;
                    width = 9;
                    height = 9;
                    boomerang.PosX += 12;
                }

                else if (boom == totalBoom * 2) //9 return boom
                {
                    posX = 4;
                    posY = 3;
                    width = 5;
                    height = 8;

                }
            }

            boom++;
        }
        public void Draw(SpriteBatch spriteBatch, Vector2 vector)
        {
            if (spriteBatch == null)
            {
                throw new ArgumentNullException(nameof(spriteBatch));
            }
            if (Texture != null)
            {
                Rectangle sourceRectangle = new Rectangle(posX, posY, width, height);
                Rectangle destinationRectangle = new Rectangle(boomerang.PosX, boomerang.PosY, width * 4, height * 4);


                spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);

            }
        }

    }
}