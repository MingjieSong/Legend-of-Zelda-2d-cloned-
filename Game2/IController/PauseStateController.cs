
using Microsoft.Xna.Framework.Input; 
using System.Collections.Generic;
using System.Linq;
 

namespace Sprint2
{
    public class PauseStateController : IController
    {
        private Dictionary<Keys, ICommand> map;
        
        private Game1 myGame;
        public PauseStateController(Game1 game, PlayState play )  {
            
            myGame = game;
            map = new Dictionary<Keys, ICommand>();

            map.Add(Keys.Escape, new QuitCommand(myGame));
            map.Add(Keys.R, new  SwitchToPlayCommand(myGame, play));
             
        }
        public void Update()
        {
            Keys[] pressedKeys= Keyboard.GetState().GetPressedKeys();
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




