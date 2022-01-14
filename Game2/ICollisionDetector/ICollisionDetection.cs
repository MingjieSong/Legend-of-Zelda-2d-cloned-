using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public interface ICollisionDetection
    {
        //maybe need to add a another helping method to detect direction, 
        //return a string
        void Update();
        string detectCollisionDirection(Rectangle overlapRec,Rectangle testRec, Rectangle objectRec);
        
    }
}
