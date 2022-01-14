using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2 
{
    public class DragonWalkLeftState: IEnemyState
    {
        private Dragon dragon;
        public DragonWalkLeftState(Dragon dragon)
        {
            if (dragon == null)
            {
                throw new ArgumentNullException(nameof(dragon));
            }
            this.dragon = dragon;
            dragon.DragonSprite = EnemySpriteFactory.Instance.CreateYellowDragonSprite("Left", this.dragon, false);
            dragon.fire = new Fire(dragon.posX-30, dragon.posY, 2);
            Dragon.hasFire = true;
        }
        public void ChangeToRight()
        {
            dragon.state = new DragonWalkRightState(dragon);
        }

        public void ChangeToLeft()
        {
            //already left 
        }

        public void ChangeToUp()
        {
            dragon.state = new DragonWalkUpState(dragon);
        }

        public void ChangeToDown()
        {
            dragon.state = new DragonWalkDownState(dragon);
        }
        public void GetDamaged()
        {
            dragon.state = new DragonWalkLeftDamageState(dragon);
        }

    }
}
