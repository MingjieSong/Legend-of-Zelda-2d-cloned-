using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
 

namespace Sprint2 
{
   public class GetDamagedCommand: ICommand
    {
        private PlayState play;
        public GetDamagedCommand(  PlayState play )
        {
            this.play = play;
        }
        public void Execute()
        {
             play.player.GetDamaged(); 
        }
    }
}
