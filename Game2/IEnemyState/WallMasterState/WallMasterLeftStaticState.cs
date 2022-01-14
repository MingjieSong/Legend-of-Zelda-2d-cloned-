using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class WallMasterLeftStaticState: IEnemyState
    {
        private WallMaster wallMaster;
        public WallMasterLeftStaticState(WallMaster w)
        {
            if (w == null)
            {
                throw new System.ArgumentNullException(nameof(w));
            }
            this.wallMaster = w;
            wallMaster.WallMasterSprite = EnemySpriteFactory.Instance.CreateWallMasterSprite("Left", wallMaster, true);
        }
        public void ChangeToRight ()
        {
            wallMaster.state = new WallMasterRightDynamicState(wallMaster);
        }

        public void ChangeToLeft ()
        {
            
            wallMaster.state = new WallMasterLeftDynamicState(wallMaster);
        }

        
        public void ChangeToUp()
        {
        }

        public void ChangeToDown()
        {
        }
        public void GetDamaged()
        {
            //
        }
    }
}
