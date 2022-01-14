 
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;


namespace Sprint2
{
    public class Bomb : IItem
    {
        
        public int Count { get; set; } = 0;
        public int TotalCount { get; set; } = 100;
        public bool Appear { get; set; } = false;

        private int itemNum = 2;
        public IItemState state;
        public ISprite bombSprite;
        private int delay = 0;
        //initial position closed to link
        public int PosX { get; set; }
        public int PosY { get; set; }


        private int bombWidth = 8;//sprite width
        private int bombHeight = 14;//sprite height
        public Rectangle BoundingBox { get; set; }

        public Bomb(int posX, int posY)
        {

            state = new BombAppearUnExplodeState(this);
            this.PosX = posX;
            this.PosY = posY;
        }


        public int GetItem()
        {
            return itemNum;
        }


        public void Draw(SpriteBatch spriteBatch)
        {
            bombSprite.Draw(spriteBatch, new Vector2(PosX, PosY));
        }


        public void Update()
        {
             
            bombSprite.Update();

          
            delay++;
            if (delay > 80  )
            {
                bombWidth = 17;
                bombHeight = 21;
                //state.ChangeToExplode();
                state = new BombAppearExplodeState(this);
                BoundingBox = new Rectangle(PosX, PosY, bombWidth * 5, bombHeight * 5);
                

            }
           


        }
 
        public void changeState(IItemState state)
        {
            this.state = state;
        }

        public void ChangeSprite(ISprite sprite)
        {
            this.bombSprite = sprite;
        }
    }
}
