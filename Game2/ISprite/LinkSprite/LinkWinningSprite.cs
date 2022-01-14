using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class LinkWinningSprite : ISprite
    {
        private Texture2D Texture;
        private int sourceLocX = 31;
        private int sourceLocY = 150;
        private int width = 14;
        private int height = 16;

        public LinkWinningSprite(Texture2D texture)
        {
            Texture = texture;
        }


        public void Update()
        {
            //no code 
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            if (spriteBatch == null)
            {
                throw new ArgumentNullException(nameof(spriteBatch));
            }
            Rectangle sourceRectangle1 = new Rectangle(sourceLocX, sourceLocY, width, height);
            Rectangle destinationRectangle1 = new Rectangle((int)location.X, (int)location.Y, width * 3, height * 3);
            Rectangle sourceRectangle2 = new Rectangle(333,288,10,10);
            Rectangle destinationRectangle2 = new Rectangle((int)location.X+3, (int)location.Y-width*2 - 10, 10 * 4 - 5, 10 * 4-5);

            spriteBatch.Draw(Texture, destinationRectangle1, sourceRectangle1, Color.White);
            spriteBatch.Draw(Texture, destinationRectangle2, sourceRectangle2, Color.White);

        }
    }
}
