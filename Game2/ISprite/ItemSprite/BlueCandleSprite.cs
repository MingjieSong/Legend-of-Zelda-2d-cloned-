using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;


namespace Sprint2
{
    public class BlueCandleSprite : ISprite
    {
        public Texture2D Texture { get; set; }
        private int posX = 300;
        private int posY = 0;
        private int width = 16;
        private int height = 16;
        private IItem candleFire;
        private int timer = 0;
        private string direction;
        public BlueCandleSprite(Texture2D texture, IItem candleFire, string d)
        {
            Texture = texture;
            this.candleFire = candleFire;
            this.direction = d;
        }

        public void Update()
        {

            timer++;
            if (timer <= 20)
            {
                if (direction.Equals("Down", StringComparison.Ordinal))
                {
                    candleFire.PosY += 7;
                }
                else if (direction.Equals("Up", StringComparison.Ordinal))
                {
                    candleFire.PosY -= 7;
                }
                else if (direction.Equals("Right", StringComparison.Ordinal))
                {
                    candleFire.PosX += 7;
                }
                else if (direction.Equals("Left", StringComparison.Ordinal))
                {
                    candleFire.PosX -= 7;
                }
            }
            else
            {
                if (timer % 5 == 0)
                {
                    posX = 300;
                    posY = 0;
                }
                else
                {
                    posX = 300;
                    posY = 30;
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
                Rectangle sourceRectangle = new Rectangle(posX, posY, width, height);
                Rectangle destinationRectangle = new Rectangle(candleFire.PosX, candleFire.PosY, width * 3, height * 3);    // determine location and demension of the current frame

                spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);

            }
        }

    }
}

