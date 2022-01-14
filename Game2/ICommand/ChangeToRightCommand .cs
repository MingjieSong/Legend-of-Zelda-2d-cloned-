using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2 
{
    public class ChangeToRightCommand : ICommand
    {
        private PlayState play;
        public ChangeToRightCommand(PlayState play)
        {
            this.play = play;
        }
        public void Execute()
        {
            play.player.ChangeToRight();
        }
    }
}
