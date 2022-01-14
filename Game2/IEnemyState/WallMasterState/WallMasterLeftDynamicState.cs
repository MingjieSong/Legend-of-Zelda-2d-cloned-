using Microsoft.Xna.Framework.Graphics;
 

namespace Sprint2
{
    public class WallMasterLeftDynamicState : IEnemyState
    {
        private WallMaster wallMaster;
        public WallMasterLeftDynamicState(WallMaster w)
        {
            if (w == null)
            {
                throw new System.ArgumentNullException(nameof(w));
            }
            this.wallMaster = w;
            wallMaster.WallMasterSprite = EnemySpriteFactory.Instance.CreateWallMasterSprite("Left", wallMaster, false);
        }
        public void ChangeToRight ()
        {
            wallMaster.state = new WallMasterRightStaticState(wallMaster);
        }

        public void ChangeToLeft ()
        {
            wallMaster.state = new WallMasterLeftStaticState(wallMaster);
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
