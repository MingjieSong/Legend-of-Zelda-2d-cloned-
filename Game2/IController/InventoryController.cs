
using Microsoft.Xna.Framework.Input; 
using System.Collections.Generic;
 

namespace Sprint2
{
    public class InventoryController : IController
    {
#pragma warning disable IDE0044 // Add readonly modifier
      //  private Dictionary<Keys, ICommand> map;
#pragma warning restore IDE0044 // Add readonly modifier

        private Game1 myGame;

        private ICommand command;
        private PlayState play;
        public InventoryController(Game1 game, PlayState play )
        {
            this.play = play;
            myGame = game;
            
        }
        public void Update()
        {    
                IInventory inventory = play.inventoryBar;
                InventoryDetector(inventory);

                if (command != null)
                {
                    command.Execute();
                }
            

        }

        public void InventoryDetector(IInventory inventory)
        {

#pragma warning disable CA1062 // Validate arguments of public methods
            if (inventory.heartNum <= 0)
#pragma warning restore CA1062 // Validate arguments of public methods
            {
                command = new SwitchToLoseCommand(myGame);
            }
            else if (inventory.triPieceNum >= 3)
            {
                command = new SwitchToWinCommand(myGame, play);
            }
        }
    }
}




