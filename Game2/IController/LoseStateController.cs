using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using System.Linq;


namespace Sprint2
{
    public class LoseStateController : IController
    {
        private Dictionary<Keys, ICommand> map;

        private Game1 myGame;
        


        public LoseStateController(Game1 game)
        {

            myGame = game;
            map = new Dictionary<Keys, ICommand>();



            map.Add(Keys.Escape, new QuitCommand(myGame));
            map.Add(Keys.R, new SwitchToStartCommand(myGame));
          

        }
        public void Update() {

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




