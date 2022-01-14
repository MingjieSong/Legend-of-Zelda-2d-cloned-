using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2 
{
    public class AttackCommand: ICommand
    {
        private PlayState play;
        public AttackCommand(PlayState play)
        {
            this.play = play;
        }
        public void Execute()
        {
            play.player. Attack();
        }
    }
}
