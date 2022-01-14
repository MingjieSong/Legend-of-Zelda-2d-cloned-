using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Sprint2
{

#pragma warning disable CA1001 // Types that own disposable fields should be disposable
    public class PauseState : IGameState
#pragma warning restore CA1001 // Types that own disposable fields should be disposable
    {
     
      //  private Texture2D ButtonTexture = Texture2DStorage.GetButtonSpriteSheet();
      //  private Vector2 buttonLocation = new Vector2(300, 250);
        private string sentence1 = "PAUSED";
        private string sentence2 = "PRESS R TO RESUME THE GAME";
        private Vector2 sentence1Location = new Vector2(330, 390);
        private Vector2 sentence2Location = new Vector2(150, 430);
        private Vector2 fontSize1 = new Vector2(25, 25);
        private Vector2 fontSize2 = new Vector2(20, 20);
        Texture2D whiteRectangle;

        private IController pauseStateController;
        private IGameState play;
        public PauseState(Game1 game, PlayState play)
        {
            this.play = play;
            pauseStateController = new PauseStateController(game,play );
        }

        public void Update()
        {
            pauseStateController.Update();
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            play.Draw(spriteBatch);
            // draw black rectangle
#pragma warning disable CA1062 // Validate arguments of public methods
            whiteRectangle = new Texture2D(spriteBatch.GraphicsDevice, 1, 1);
#pragma warning restore CA1062 // Validate arguments of public methods
            whiteRectangle.SetData(new[] { Color.White });
            spriteBatch.Draw(whiteRectangle, new Rectangle(100, 350, 600, 150),
            Color.Black);
            // draw text
            LetterGenerator.drawSentence(spriteBatch, sentence1, sentence1Location, fontSize1);
            LetterGenerator.drawSentence(spriteBatch, sentence2, sentence2Location, fontSize2);
        }
    }
}
