using Microsoft.Xna.Framework.Input;
using System.Collections.Generic; 

namespace Sprint2
{
    public class InventoryScreenController : IController
    {
        private Dictionary<Keys, ICommand> map;

        private Game1 myGame;
        private IInventory inventory;
        private KeyboardState oldState;
        private KeyboardState newState;
         
        public InventoryScreenController(Game1 game, PlayState play )
        {
#pragma warning disable CA1062 // Validate arguments of public methods
            this.inventory = play.inventoryBar;
#pragma warning restore CA1062 // Validate arguments of public methods

            myGame = game;
            map = new Dictionary<Keys, ICommand>
            {
                { Keys.Escape, new QuitCommand(myGame) },
                { Keys.R, new SwitchToPlayCommand(myGame,play) },

                { Keys.Up, new UpLineCommand(inventory) },
                { Keys.Down, new DownLineCommand(inventory) },
                { Keys.Right, new NextItemCommand(inventory) },
                { Keys.Left, new PreviousItemCommand(inventory) },
                { Keys.Enter, new SelectInListCommand(inventory) }
            };



        }

        
        public void Update()
        {
            
            newState = Keyboard.GetState();
            Keys[] newPressedKeys = newState.GetPressedKeys();
#pragma warning disable IDE0059 // Unnecessary assignment of a value
            Keys[] oldPressedKeys = { };
#pragma warning restore IDE0059 // Unnecessary assignment of a value
            if (oldState != null)
            {
#pragma warning disable IDE0059 // Unnecessary assignment of a value
                oldPressedKeys = oldState.GetPressedKeys();
#pragma warning restore IDE0059 // Unnecessary assignment of a value
            }
            if (newState != oldState)
            {
                foreach (Keys key in newPressedKeys)
                {
                    if (map.ContainsKey(key))
                    {
                        map[key].Execute();
                    }
                }
            }
            oldState = newState;
        }
    }
}

