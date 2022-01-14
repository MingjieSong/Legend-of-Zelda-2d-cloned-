using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class DamageWoodenBoomerang : IItem
    {
        public int Count { get; set; } = 0;
        public int TotalCount { get; set; } = 48;
        public bool Appear { get; set; } = false;

        private const string Value = "error: no such situation";
        private int itemNum = 10;
        private IItemState state;
        private ISprite woodenBoomerangSprite;
        //initial position which closed to Link
        public int PosX { get; set; }
        public int PosY { get; set; }


        private int delay = 0;
        private int facingDirection;

        private int boomerWidth = 9;//sprite width
        private int boomerHeight = 9;//sprite height
        public Rectangle BoundingBox { get; set; }

        public DamageWoodenBoomerang(int posX, int posY, int direction)
        {
            BoundingBox = new Rectangle(0, 0, 0, 0);
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
            this.woodenBoomerangSprite = sprite;
        }

        public void Update()
        {
            if (woodenBoomerangSprite != null)
            {
                BoundingBox = new Rectangle(PosX, PosY, boomerWidth * 3, boomerHeight * 3);
                woodenBoomerangSprite.Update();
            }
            
            delay++;
            if (delay == 10)
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
                        Console.WriteLine(Value);
                        break;
                }


            }
            

        }


        public void Draw(SpriteBatch spriteBatch)
        {
            if (woodenBoomerangSprite != null)
            {
                woodenBoomerangSprite.Draw(spriteBatch, new Vector2(PosX, PosY));
            }
        }

 
    }
}
