 

namespace Sprint2
{
    public class SwitchToPlayCommand : ICommand
    {
        private Game1 myGame;
        private IGameState play;
        public SwitchToPlayCommand(Game1 game, PlayState play)
        {
            myGame = game;
            this.play = play;
        }
        public SwitchToPlayCommand(Game1 game )
        {
            myGame = game;
        }

        public void Execute()
        {
            if (play != null)
            {
                myGame.gameState = play;
            }
            else
            {
                myGame.gameState = new PlayState(myGame);
            }
                
        }
    }
}
