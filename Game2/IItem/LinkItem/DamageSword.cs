using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class DamageSword : IItem
    {
        public int Count { get; set; } = 0;
        public int TotalCount { get; set; } = 100;
        public bool Appear { get; set; } = false;

        private int itemNum = 6;
        private IItemState state;
        private ISprite swordSprite;
        //initial position which closed to Link
        public int PosX { get; set; }
        public int PosY { get; set; }


        private int swordWidth = 7;//sprite width
        private int swordHeight = 16;//sprite height
        public Rectangle BoundingBox { get; set; }

        private int delay = 0;
        private int facingDirection;
        public DamageSword(int posX, int posY, int direction)
        {
           
            facingDirection = direction;
            this.PosX = posX;
            this.PosY = posY;


        }


        public void Update()
        {
            if (swordSprite != null)
            {
                BoundingBox = new Rectangle(PosX, PosY, swordWidth * 3, swordHeight * 3);
                swordSprite.Update();
            }
            
            delay++;
            if (delay == 40)
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
           
        }


        public void Draw(SpriteBatch spriteBatch)
        {
            if (swordSprite != null)
            {
                swordSprite.Draw(spriteBatch, new Vector2(PosX, PosY));
            }
        }

 
 
        public void ChangeSprite(ISprite sprite)
        {
            this.swordSprite = sprite;
        }

        public int GetItem()
        {
            return itemNum;
        }
    }
}
