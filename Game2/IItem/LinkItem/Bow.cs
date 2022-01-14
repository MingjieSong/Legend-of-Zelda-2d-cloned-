using System; 
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class Bow : IItem
    {
        public int Count { get; set; } = 0;
        public int TotalCount { get; set; } = 30;
        public bool Appear { get; set; } = false;
        private int itemNum = 3;
        private IItemState state;
        private ISprite bowSprite;
        //initial position which closed to Link
        public int PosX { get; set; }
        public int PosY { get; set; }

 
        private int facingDirection;

        private int bowWidth = 16;//sprite width
        private int bowHeight = 8;//sprite height
        public Rectangle BoundingBox { get; set; }
        public Bow(int posX, int posY, int direction)
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
            this.bowSprite = sprite;
        }

        public void Update()
        {
            if (bowSprite != null)
            {
                BoundingBox = new Rectangle(PosX, PosY, bowWidth * 3, bowHeight * 3);

                bowSprite.Update();
            }
           
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


        public void Draw(SpriteBatch spriteBatch)
        {
            if (bowSprite != null)
            {
                bowSprite.Draw(spriteBatch, new Vector2(PosX, PosY));
            }
            
        }


     
    }
}
