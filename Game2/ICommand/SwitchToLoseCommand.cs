namespace Sprint2
{
    public class SwitchToLoseCommand : ICommand
    {
        private Game1 myGame;
        public SwitchToLoseCommand(Game1 game)
        {
            myGame = game;
        }

        public void Execute()
        { 
            myGame.gameState = new LoseState(myGame);
        }
    }
}