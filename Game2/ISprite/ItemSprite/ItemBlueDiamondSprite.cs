using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class ItemBlueDiamondSprite : ISprite
    {
        private Texture2D Texture;
        private int sourceLocX = 204;
        private int sourceLocY = 120;
        private int width = 8;
        private int height = 16;


        public ItemBlueDiamondSprite(Texture2D texture)
        {
            Texture = texture;
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
                Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, width * 3, height * 3);
               
                spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
                
            }
        }

        public void Update()
        {
            //nothing to update
        }
    }
}
