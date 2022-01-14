using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class DamageArrow : IItem
    {
        public int Count { get; set; } = 0;
        public int TotalCount { get; set; } = 100;
        public bool Appear { get; set; } = false;
        private int itemNum = 7;
        private IItemState state;
        private ISprite arrowSprite;
        //initial position which closed to Link
        public int PosX { get; set; }
        public int PosY { get; set; }


        private int delay = 0;
        private int facingDirection;

        private int arrowWidth = 5;//sprite width
        private int arrowHeight = 16;//sprite height
        public Rectangle BoundingBox { get; set; }

        
        public DamageArrow(int posX, int posY, int direction)
        {
            
            facingDirection = direction;
    
                this.PosX = posX;
                this.PosY = posY;
 
        }
        public int GetItem()
        {
            return itemNum;
        }
      
        public void ChangeSprite(ISprite sprite)
        {
            this.arrowSprite = sprite;
        }

        public void Update()
        {
                
              delay++;
           
        if (delay >= 20)
        { 
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


            if (arrowSprite != null)
            {
                BoundingBox = new Rectangle(PosX, PosY, arrowWidth * 3, arrowHeight * 3);
                arrowSprite.Update();
            }
          }


        public void Draw(SpriteBatch spriteBatch)
        {
            if (arrowSprite != null)
            {
                arrowSprite.Draw(spriteBatch, new Vector2(PosX, PosY));
                 
            } 
        }


      
    }
}
