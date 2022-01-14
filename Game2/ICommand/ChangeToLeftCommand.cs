using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2 
{
    public class ChangeToLeftCommand : ICommand
    {
        private PlayState play;
        public ChangeToLeftCommand(PlayState play)
        {
            this.play = play;
        }
        public void Execute()
        {
            play.player.ChangeToLeft();
        }
    }
}
