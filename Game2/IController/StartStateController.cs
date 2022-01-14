
using Microsoft.Xna.Framework.Input; 
using System.Collections.Generic;
using System.Linq;
 

namespace Sprint2
{
    public class StartStateController : IController
    {
        private Dictionary<Keys, ICommand> map;
        
        private Game1 myGame;
        public StartStateController(Game1 game )
        {
            
            myGame = game;
            map = new Dictionary<Keys, ICommand>();

            map.Add(Keys.Escape, new QuitCommand(myGame));
            map.Add(Keys.S, new  SwitchToPlayCommand(myGame));
             
        }
        public void Update()
        { 
            Keys[] pressedKeys = Keyboard.GetState().GetPressedKeys();
            foreach (Keys key in pressedKeys)
            {
                if (map.ContainsKey(key))
                {
                    map[key].Execute();
                }
            }

        }
    }
}




