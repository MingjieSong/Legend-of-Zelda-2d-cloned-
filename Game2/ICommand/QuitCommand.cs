﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
 
namespace Sprint2 { 
   public class QuitCommand : ICommand
    {
        private Game1 myGame;
        public QuitCommand(Game1 game)
        {
            myGame = game;
        }

        public void Execute() {
            myGame.Exit();
        }
    }
}
