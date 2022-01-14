using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class BlueCandle : IItem
    {
        public int Count { get; set; } = 0;
        public int TotalCount { get; set; } = 100;
        public bool Appear { get; set; } = false;

        private int itemNum = 1;
        private IItemState state;
        private ISprite blueCandleSprite;
        //initial position which closed to Link
        public int PosX { get; set; }
        public int PosY { get; set; }


        
        private int facingDirection;

        private int bluecandleWidth = 8;//sprite width
        private int bluecandleHeight = 16;//sprite height
        public Rectangle BoundingBox { get; set; }

        public BlueCandle(int posX, int posY, int direction)
        {
            

            facingDirection = direction;
            this.PosX = posX;
            this.PosY = posY;

            switch (facingDirection)
            {
                case 0:
                    state = new AppearUpState(this);
                    break;
                case 1:
                    state = new AppearDownState(this);
                    break;
                case 2:
                    state = new AppearLeftState(this);
                    break;
                case 3:
                    state = new AppearRightState(this);
                    break;
                default:
#pragma warning disable CA1303 // Do not pass literals as localized parameters
                    Console.WriteLine("error: no such situation");
#pragma warning restore CA1303 // Do not pass literals as localized parameters
                    break;
            }



        }
        public int GetItem()
        {
            return itemNum;
        }
       
        public void ChangeSprite(ISprite sprite)
        {
            this.blueCandleSprite = sprite;
        }


        public void Update()
        {
          
                BoundingBox = new Rectangle(PosX, PosY, bluecandleWidth * 3, bluecandleHeight * 3);
                blueCandleSprite.Update();
         
           
        }


        public void Draw(SpriteBatch spriteBatch)
        {
           
                blueCandleSprite.Draw(spriteBatch, new Vector2(PosX, PosY));
           
        }

 
    }
}
