using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2 
{
    public interface IEnemyState
    {
        void ChangeToLeft();
        void ChangeToRight();
        void ChangeToUp();
        void ChangeToDown();
        void GetDamaged();

        // void ChangeToAppear();
        // void ChangeToDisappear();
    }
}
