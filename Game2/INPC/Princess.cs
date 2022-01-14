using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Sprint2
{
    public class Princess : INpc
    {


        private ISprite PrincessSprite;
        private Texture2D texture = Texture2DStorage.GetNpcSpriteSheet();

        private int posY;
        private int posX;
        private int princessWidth = 14;//sprite width
        private int princessHeight = 26;//sprite height
        private bool ifTalk=false;
        public Rectangle boundingBox { get; set; }
        public Princess(Vector2 vector)
        {
            posX = (int)vector.X;
            posY = (int)vector.Y;
            //initial sprite
            PrincessSprite = new StaticSprite(texture, 121, 5, 14, 26);
        }




        public void Update()
        {
            boundingBox = new Rectangle(posX, posY, princessWidth * 3, princessHeight * 3);
            PrincessSprite.Update();


        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (ifTalk != true)
            {
                PrincessSprite.Draw(spriteBatch, new Vector2(posX, posY));
            }
            else
            {
                PrincessSprite.Draw(spriteBatch, new Vector2(posX, posY));
                LetterGenerator.drawSentence(spriteBatch, "GO DOWN TO GET TRIFORCE PIECE", new Vector2(posX - 250, posY - 94), new Vector2(19, 19));
            }
           
        }
        public void Talk() {
            ifTalk = true;
        }

      


    }
}
