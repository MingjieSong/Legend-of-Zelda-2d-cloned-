using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class FireSpreadDown : IItem
    {
        public int Count { get; set; } = 0;
        public int TotalCount { get; set; } = 100;
        public bool Appear { get; set; } = false;
        private int itemNum = 17;
        private IItemState state;
        private static ISprite fireSprite;
        //initial position which closed to Link
        public int PosX { get; set; }
        public int PosY { get; set; }

        private int fireWidth = 8;//sprite width
        private int fireHeight = 10;//sprite height
        public Rectangle BoundingBox { get; set; }

        
        public FireSpreadDown(int posX, int posY, int direction)
        {

            switch (direction)
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



            this.PosX = posX;
            this.PosY = posY;


        }
        public int GetItem()
        {
            return itemNum;
        }
       
        public void ChangeSprite(ISprite sprite)
        {
            fireSprite = sprite;
        }

        public void Update()
        {

            if (fireSprite != null)
            {
                BoundingBox = new Rectangle(PosX, PosY, fireWidth * 3, fireHeight * 3);
                fireSprite.Update();

            }
    
        }


        public void Draw(SpriteBatch spriteBatch)
        {
            if (fireSprite != null)
            {
                fireSprite.Draw(spriteBatch, new Vector2(PosX, PosY));
            }

        }
 
    }
}
