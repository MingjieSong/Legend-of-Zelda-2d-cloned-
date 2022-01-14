using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;


namespace Sprint2
{
    public class LockedDoor: IItem
    {
        //this part only needed for link item
        public int Count { get; set; } = 0;
        public int TotalCount { get; set; } = 100;
        public bool Appear { get; set; } = false; 
        private int p = 100;
        //Sprite parameters
        private Texture2D texture = Texture2DStorage.GetDoorSpriteSheet();
        private int sourceLocX  ;
        private int sourceLocY ;
        private int width  ;
        private int height  ;
 
        private int desWidth;
        private int desHeight;
        private string Direction { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }
        public Rectangle BoundingBox { get; set; }
        
        public LockedDoor(string direction, Vector2 desLoc)
        {
            this.Direction = direction;
            PosX = (int)desLoc.X;
            PosY = (int)desLoc.Y;
           
        }

        public void Update()
        {
            //static item no need to update
        }

        public void Draw(SpriteBatch spriteBatch)
        {
#pragma warning disable CA1307 // Specify StringComparison
            if (Direction.Equals("Up"))
#pragma warning restore CA1307 // Specify StringComparison
            {
                sourceLocX = 1217;
                sourceLocY = 459;
                width = 153;
                height = 94;
                //desLocX = 351;
                //desLocY = 248;
                desWidth = 95;
                desHeight = 63;
                BoundingBox = new Rectangle(  PosX, PosY - 5,  desWidth,  desHeight + 5);

            }
#pragma warning disable CA1307 // Specify StringComparison
            else if (Direction.Equals("Down"))
#pragma warning restore CA1307 // Specify StringComparison
            {
                sourceLocX = 1398;
                sourceLocY = 451;
                width = 153;
                height = 94;
                //desLocX = 351;
               // desLocY = 690;
                desWidth = 95;
                desHeight = 63;
                BoundingBox = new Rectangle(PosX, PosY, desWidth, desHeight + 5);
            }
#pragma warning disable CA1307 // Specify StringComparison
            else if (Direction.Equals("Left"))
#pragma warning restore CA1307 // Specify StringComparison
            {
                sourceLocX = 1692;
                sourceLocY = 396;
                width = 87;
                height = 154;
                //desLocX = 42;
                //desLocY = 449;
                desWidth = 57;
                desHeight = 105;
                 BoundingBox = new Rectangle(  PosX-5, PosY ,  desWidth+5,  desHeight  );
            }
#pragma warning disable CA1307 // Specify StringComparison
            else if (Direction.Equals("Right"))
#pragma warning restore CA1307 // Specify StringComparison
            {
                sourceLocX = 1573;
                sourceLocY = 396;
                width = 87;
                height = 154;
                //desLocX = 696;
                //desLocY = 449;
                desWidth = 57;
                desHeight = 105;
                BoundingBox = new Rectangle(PosX, PosY, desWidth + 5, desHeight);
            }
            Rectangle sourceRectangle = new Rectangle(sourceLocX, sourceLocY, width, height);
            Rectangle destinationRectangle = new Rectangle( PosX, PosY, desWidth, desHeight);
#pragma warning disable CA1062 // Validate arguments of public methods
            spriteBatch.Draw(texture, destinationRectangle, sourceRectangle, Color.White);
#pragma warning restore CA1062 // Validate arguments of public methods
        }

        //method needed for non static item
        //here to implement the interface
        public int GetItem()
        {
            return p;
        }
        public static void changeState()
        {
            //do nothing
        }

        public void ChangeSprite(ISprite sprite)
        {
            //do nothing
        }
         
    }
}
