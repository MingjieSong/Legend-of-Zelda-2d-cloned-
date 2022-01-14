using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class RedGoriyaSprite : ISprite
    {
        private Texture2D Texture;
        private string Direction;
        private int sourceLocX;
        private int sourceLocY;
        private int width;
        private int height;
        private int delay = 0;
        private int totalDelay = 30;
        

        private IEnemy Goriya;
        public RedGoriyaSprite(Texture2D texture, string direction, IEnemy Goriya )
        {
            Texture = texture;
            Direction = direction;
            this.Goriya = Goriya;
        }
       

        public void Update()
        {
            delay++;
            switch (Direction)
            {
                case "Right":
                    if (delay > totalDelay / 2)
                    {

                        width = 15;
                        height = 15;
                        sourceLocX = 306;
                        sourceLocY = 31;
                        if (delay == totalDelay)
                        {
                            delay = 0;
                        }
                    }
                    else
                    {
                        width = 13;
                        height = 16;
                        sourceLocX = 283;
                        sourceLocY = 30;
                    }
                    
                        Goriya.posX++;
 
                    break;
                case "Left":
                    if (delay > totalDelay / 2)
                    {

                        width = 14;
                        height = 15;
                        sourceLocX = 213;
                        sourceLocY = 31;
                        if (delay == totalDelay)
                        {
                            delay = 0;
                        }
                    }
                    else
                    {
                        width = 13;
                        height = 16;
                        sourceLocX = 192;
                        sourceLocY = 30;
                    }
                  
                        Goriya.posX--;
                     
                    break;
                case "Down":
                    if (delay > totalDelay / 2)
                    {

                        width = 13;
                        height = 16;
                        sourceLocX = 260;
                        sourceLocY = 30;
                        if (delay == totalDelay)
                        {
                            delay = 0;
                        }
                    }
                    else
                    {
                        width = 13;
                        height = 16;
                        sourceLocX = 238;
                        sourceLocY = 30;
                    }
                  
                        Goriya.posY++;
 
                    break;
                case "Up":
                    if (delay > totalDelay / 2)
                    {

                        width = 13;
                        height = 16;
                        sourceLocX = 329;
                        sourceLocY = 30;
                        if (delay == totalDelay)
                        {
                            delay = 0;
                        }
                    }
                    else
                    {
                        width = 13;
                        height = 16;
                        sourceLocX = 351;
                        sourceLocY = 30;
                    }
                   
                        Goriya.posY--;
 
                    break;

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
                Rectangle sourceRectangle = new Rectangle(sourceLocX, sourceLocY, width, height);
                Rectangle destinationRectangle = new Rectangle(Goriya.posX, Goriya.posY, width * 3, height * 3);
                spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            }
        }
    }
}
