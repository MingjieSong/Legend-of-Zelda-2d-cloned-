 

namespace Sprint2
{
    public class SwitchToPauseCommand : ICommand
    {
        private Game1 myGame;
        private PlayState play;
        public SwitchToPauseCommand(Game1 game, PlayState play)
        {
            myGame = game;
            this.play = play;
        }

        public void Execute()
        {
            myGame.gameState = new PauseState(myGame, play);
        }
    }
}
