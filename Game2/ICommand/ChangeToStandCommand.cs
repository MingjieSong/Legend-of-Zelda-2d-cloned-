using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2 
{
    public  class ChangeToStandCommand : ICommand
    {
        private PlayState play;
        public ChangeToStandCommand(PlayState play)
        {
            this.play = play;
        }
        public void Execute()
        {
            play.player.ChangeToStand();
        }
    }
}
