using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BowSprite : ISprite
    {
        private Texture2D Texture;
        private int posX;
        private int posY;
        private int width;
        private int height;
        private string direction;


        public BowSprite(Texture2D texture, string d)
        {
            Texture = texture;
            this.direction = d ?? throw new ArgumentNullException(nameof(d));
            if (direction.Equals("Down", StringComparison.Ordinal))
            {
                posX = 12;
                posY = 12;
                width = 16;
                height = 8;
    }
            else if (direction.Equals("Up", StringComparison.Ordinal))
            {
                posX = 90;
                posY = 9;
                width = 16;
                height = 8;
            }
            else if (direction.Equals("Right", StringComparison.Ordinal))
            {
                posX = 71;
                posY = 2;
                width = 8;
                height = 16;
            }
            else if (direction.Equals("Left", StringComparison.Ordinal))
            {
                posX = 39;
                posY = 12;
                width = 8;
                height = 16;
            }
        }

        public void Update()
        {
            //static bow



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
                Rectangle destinationRectangle = new Rectangle((int)vector.X, (int)vector.Y, width * 3, height * 3);    // determine location and demension of the current frame


                spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);

            }
        }

    }
}