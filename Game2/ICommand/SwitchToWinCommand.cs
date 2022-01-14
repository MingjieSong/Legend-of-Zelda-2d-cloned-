namespace Sprint2
{
    public class SwitchToWinCommand : ICommand
    {
        private Game1 myGame;
        private PlayState play;
        public SwitchToWinCommand(Game1 game, PlayState play)
        {
            myGame = game;
            this.play = play;
        }

        public void Execute()
        { 
            myGame.gameState = new WinState(myGame,play);
        }
    }
}