using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class WoodSwordDamageSprite : ISprite
    {
        public Texture2D Texture { get; set; }
        private int posX;
        private int posY;
        private int width;
        private int height;
        private IItem sword;
        private string direction;

        public WoodSwordDamageSprite(Texture2D texture, IItem sword, string d)
        {
            Texture = texture;
            this.sword = sword;
            this.direction = d ?? throw new ArgumentNullException(nameof(d));
            if (direction.Equals("Down", StringComparison.Ordinal))
            {
                posX = 152;
                posY = 4;
                width = 7;
                height = 16;
            }
            else if (direction.Equals("Up", StringComparison.Ordinal))
            {
                posX = 152;
                posY = 64;
                width = 7;
                height = 16;
            }
            else if (direction.Equals("Right", StringComparison.Ordinal))
            {
                posX = 329;
                posY = 132;
                width = 16;
                height = 7;
            }
            else if (direction.Equals("Left", StringComparison.Ordinal))
            {
                posX = 389;
                posY = 132;
                width = 16;
                height = 7;
            }
        }

        public void Update()
        {
            if (direction.Equals("Down", StringComparison.Ordinal))
            {
                sword.PosY += 7;
            }
            else if (direction.Equals("Up", StringComparison.Ordinal))
            {
                sword.PosY -= 7;
            }
            else if (direction.Equals("Right", StringComparison.Ordinal))
            {
                sword.PosX += 7;
            }
            else if (direction.Equals("Left", StringComparison.Ordinal))
            {
                sword.PosX -= 7;
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
                Rectangle destinationRectangle = new Rectangle(sword.PosX, sword.PosY, width * 3, height * 3);    // determine location and demension of the current frame

                spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);

            }
        }

    }
}
