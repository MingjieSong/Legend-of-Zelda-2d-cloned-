using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Sprint2
{
    public class Merchant : INpc
    {


        private ISprite MerchantSprite;
        private Texture2D texture = Texture2DStorage.GetNpcSpriteSheet();

        //----for detection class --- start
        private int posY;
        private int posX;
        private int merchantWidth = 14;//sprite width
        private int merchantHeight = 16;//sprite height


        public Rectangle boundingBox { get; set; }
        // ---  end ---
        public Merchant(Vector2 vector)
        {
             
            posX = (int)vector.X;
            posY = (int)vector.Y;
            //initial sprite
            MerchantSprite = new StaticSprite(texture, 61, 5, 14, 16);//14= merchantWidth, 16=merchantHeight
        }




        public void Update()
        {
            boundingBox = new Rectangle(posX, posY, merchantWidth * 3, merchantHeight * 3);
            MerchantSprite.Update();


        }

        public void Draw(SpriteBatch spriteBatch)
        {
            MerchantSprite.Draw(spriteBatch, new Vector2(posX, posY));
            LetterGenerator.drawSentence(spriteBatch, "WOULD YOU LIKE TO PURCHASE", new Vector2(posX-200, posY-78), new Vector2(19, 19));
            LetterGenerator.drawSentence(spriteBatch, "PAY IN DIAMOND", new Vector2(posX - 150, posY - 55), new Vector2(19, 19));
            LetterGenerator.drawSentence(spriteBatch, "FIVE", new Vector2(posX-100, 550), new Vector2(19, 19));
            LetterGenerator.drawSentence(spriteBatch, "FIVE", new Vector2(posX, 550), new Vector2(19, 19));
            LetterGenerator.drawSentence(spriteBatch, "TEN", new Vector2(posX+100, 550), new Vector2(19, 19));
        }


        

        public void Talk() { 
        
        }

    }
}
