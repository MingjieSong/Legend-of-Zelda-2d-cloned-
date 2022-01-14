using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Sprint2
{

    public class WinState : IGameState
    {

        //private Texture2D ButtonTexture = Texture2DStorage.GetButtonSpriteSheet();
        private Texture2D WinTriTexture = Texture2DStorage.GetTriForceSpriteSheet();
        private Texture2D BackgroundTexture = Texture2DStorage.GetBlackBackgroundSpriteSheet();
        private string sentence1 = "PRESS R TO RESTART";
        private string sentence2 = "PRESS ESCAPE TO QUIT";
        private string win = "YOU WIN";

        private Vector2 winLocation = new Vector2(310,350);
        private Vector2 sentence1Location = new Vector2(180, 390);
        private Vector2 sentence2Location = new Vector2(180, 430);
        private Vector2 fontSize = new Vector2(20,20);
        private int width = 140;
        private int height = 70;
        private int change = 0;
        private Vector2 triLoc = new Vector2(250, -70); 
        private PlayState play;

        public IInventory inventoryBar { get; set; }
        private IController winStateController;
        public WinState(Game1 game, PlayState play)
        {
            Sound.PlayWin();
            winStateController = new WinStateController(game);
            this.play = play;
        }

        public void Update()
        {
            winStateController.Update();
            if (change <= 400)
            {
                change++;
            }
            if (change >= 400)
            { 
                if (triLoc.Y < 180 && width < 290 && height < 220)
                {
                    triLoc.Y++;

                    width++;
                    height++;


                }
            }




        }
        public void Draw(SpriteBatch spriteBatch)
        {
            if (change<=400)
            {
                 play.Draw(spriteBatch);
            }
            
            //background
            Rectangle destinationBackRectangle1 = new Rectangle(-400 + change, (int)triLoc.Y, 400, 1000);
            Rectangle destinationBackRectangle2 = new Rectangle(800 - change, (int)triLoc.Y, 400, 1000);
#pragma warning disable CA1062 // Validate arguments of public methods
            spriteBatch.Draw(BackgroundTexture, destinationBackRectangle1, Color.Black);
#pragma warning restore CA1062 // Validate arguments of public methods
            spriteBatch.Draw(BackgroundTexture, destinationBackRectangle2, Color.Black);


            if (change >= 400)
            { 

                LetterGenerator.drawSentence(spriteBatch, win, winLocation, fontSize);
                LetterGenerator.drawSentence(spriteBatch, sentence1, sentence1Location, fontSize);
                LetterGenerator.drawSentence(spriteBatch, sentence2, sentence2Location, fontSize);


                //tri logo 
                Rectangle sourceTriRectangle = new Rectangle(30,40,800,501);
                Rectangle destinationTriRectangle = new Rectangle((int)triLoc.X, (int)triLoc.Y, width, height);
                spriteBatch.Draw(WinTriTexture, destinationTriRectangle, sourceTriRectangle, Color.White);

            }

        }
    }
}
