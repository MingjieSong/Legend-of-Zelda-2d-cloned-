using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    class BombDamageSprite : ISprite
    {
        public Texture2D Texture;
        private int sourceLocX;
        private int sourceLocY;
        private int width;
        private int height;
        private bool explode;
        private int i;


        public BombDamageSprite(Texture2D texture, bool ifExplode)
        {
            Texture = texture;
            this.explode = ifExplode;
            if (explode)
            {
                sourceLocX = 179;
                sourceLocY = 282;
                width = 17;
                height = 21;
                i = 4;
            }
            else
            {
                sourceLocX = 364;
                sourceLocY = 226;
                width = 8;
                height = 14;
                i = 3;
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
                Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, width * i, height * i);


                spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);

            }
        }

        public void Update()
        {
            //nothing to update
        }
    }
}
