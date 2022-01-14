using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2 
{
    public class ChangeToWalkCommand : ICommand
    {
        private PlayState play;
        public ChangeToWalkCommand(PlayState play)
        {
            this.play = play;
        }
        public void Execute()
        {
             play.player.ChangeToWalk(); 
        }
    }
}
