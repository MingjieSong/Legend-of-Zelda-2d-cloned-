using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public interface IPlayerstate
    {
        void ChangeToRight();
        void ChangeToLeft();
        void ChangeToUp();
        void ChangeToDown();
        void GetDamaged();
        void Attack();
        void ChangeToWalk();
        void ChangeToStand();
        void Win();

        //delete
        // void LinkWithBomb();
        // void LinkWithSword();

        //add
        void LinkWithItemUp(int item);
        void LinkWithItemDown( int item);
        void LinkWithItemLeft(int  item);
        void LinkWithItemRight( int item);
        //end
    }
}
