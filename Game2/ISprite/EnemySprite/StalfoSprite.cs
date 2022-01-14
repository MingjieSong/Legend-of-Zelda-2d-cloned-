using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class StalfoSprite : ISprite
    {
        private Texture2D Texture;
        private string Direction;
        private int width = 15;
        private int height = 16;
        private int sourceLocX = 473;
        private int sourceLocY = 7;

        private int delay = 0;
        private int totalDelay = 30;
       
        private IEnemy Stalfos;
        public StalfoSprite(Texture2D texture, string direction, IEnemy enemy)
        {
            Texture = texture;
            this.Direction = direction;
            Stalfos = enemy;
        }
        public StalfoSprite()
        {
            //do nothing
        }

        public void Update()
        {
            if (delay > totalDelay / 2)
            {

                sourceLocX = 495;
                if (delay == totalDelay)
                {
                    delay = 0;
                }
            }
            else
            {
                sourceLocX = 473;
            }
            delay++;

            switch (Direction)
            {
                case "Right":
                   
                        Stalfos.posX++;

                     
                    break;
                case "Left":
                    
                        Stalfos.posX--;

                      
                    break;
                case "Up":
                     
                        Stalfos.posY--;

                      
                    break;
                case "Down":
                    
                        Stalfos.posY++;

                     
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
                Rectangle destinationRectangle = new Rectangle(Stalfos.posX, Stalfos.posY, width * 3, height * 3);
                spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            }
        }
    }
}