using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class BatSprite : ISprite
    {
        private Texture2D Texture;
        private string Direction;
        private int width = 16;
        private int height = 8;
        private int sourceLocX = 175;
        private int sourceLocY = 11;

        private int delay = 0;
        private int totalDelay = 30;
        private int i = 0;
       
        private IEnemy Keese;
        public BatSprite(Texture2D texture, string direction, IEnemy enemy)
        {
            Texture = texture;
            this.Direction = direction;
            Keese = enemy;
        }
        public BatSprite()
        {
            //do nothing
        }

        public void Update() {
            if (delay > totalDelay / 2)
            {

                width = 10;
                height = 10;
                sourceLocX = 201;
                i = 9;
                if (delay == totalDelay)
                {
                    delay = 0;
                }
            }
            else
            {
                width = 16;
                height = 18;
                sourceLocX = 175;
                i = 0;
            }
            delay++;

            switch (Direction)
            {
                case "Right":
                    
                        Keese.posX++;

                      
                    break;
                case "Left":
                  
                        Keese.posX--;

                     
                    break;
                case "Up":
                   
                        Keese.posY--;

                      
                    break;
                case "Down":
                    
                        Keese.posY++;

                       
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
                Rectangle destinationRectangle = new Rectangle(Keese.posX + i, Keese.posY, width * 3, height * 3);
                spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            }
        }
    }
}