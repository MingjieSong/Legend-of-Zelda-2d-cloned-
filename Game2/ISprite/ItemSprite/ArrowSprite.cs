
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;

namespace Sprint2
{
    public class ArrowSprite : ISprite
    {
        public Texture2D Texture { get; set; }
        private int posX;
        private int posY;
        private int width;
        private int height;
        private IItem arrow;
        private string direction;

        public ArrowSprite(Texture2D texture, IItem arrow, string d)
        {
            Texture = texture;
            this.arrow = arrow;
            this.direction = d ?? throw new ArgumentNullException(nameof(d));
            if (direction.Equals("Down", StringComparison.Ordinal))
            {
                posX = 5;
                posY = 0;
                width = 5;
                height = 16;
    }
            else if (direction.Equals("Up", StringComparison.Ordinal))
            {
                posX = 45;
                posY = 40;
                width = 5;
                height = 16;
            }
            else if (direction.Equals("Right", StringComparison.Ordinal))
            {
                posX = 0;
                posY = 45;
                width = 16;
                height = 5;
            }
            else if (direction.Equals("Left", StringComparison.Ordinal))
            {
                posX = 40;
                posY = 5;
                width = 16;
                height = 5;
            }
        }


        public void Update()
        {
            if (direction.Equals("Down", StringComparison.Ordinal))
            {
                arrow.PosY += 4;
            }
            else if (direction.Equals("Up", StringComparison.Ordinal))
            {
                arrow.PosY -= 4;
            }
            else if (direction.Equals("Right", StringComparison.Ordinal))
            {
                arrow.PosX += 4;
            }
            else if (direction.Equals("Left", StringComparison.Ordinal))
            {
                arrow.PosX -= 4;
            }
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 vector)
        {
            if (spriteBatch == null)
            {
                throw new System.ArgumentNullException(nameof(spriteBatch));
            }
            if (Texture != null)
            {
                Rectangle sourceRectangle = new Rectangle(posX, posY, width, height);
                Rectangle destinationRectangle = new Rectangle(arrow.PosX, arrow.PosY, width * 3, height * 3);


                spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);

            }
        }

    }
}