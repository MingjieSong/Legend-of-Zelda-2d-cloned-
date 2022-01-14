namespace Sprint2
{
    public class SwitchToInventoryCommand : ICommand
    {
        private Game1 myGame;
        private PlayState play;
        public SwitchToInventoryCommand(Game1 game, PlayState play)
        {
            myGame = game;
            this.play = play;
        }

        public void Execute()
        {
            myGame.gameState = new InventoryScreen(myGame, play);
        }
    }
}