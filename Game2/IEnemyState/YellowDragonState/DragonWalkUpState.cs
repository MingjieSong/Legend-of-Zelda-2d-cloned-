using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2 
{
    public class DragonWalkUpState: IEnemyState
    {
        private Dragon dragon;
        public DragonWalkUpState(Dragon dragon)
        {
            if (dragon == null)
            {
                throw new ArgumentNullException(nameof(dragon));
            }
            this.dragon = dragon;
            dragon.DragonSprite = EnemySpriteFactory.Instance.CreateYellowDragonSprite("Up", this.dragon, false);
            dragon.fire = new Fire(dragon.posX, dragon.posY-40 , 0);
            Dragon.hasFire = true;
        }
        public void ChangeToRight()
        {
            dragon.state = new DragonWalkRightState(dragon);
        }

        public void ChangeToLeft()
        {
            dragon.state = new DragonWalkLeftState(dragon);
        }

        public void ChangeToUp()
        {
            //already up
        }

        public void ChangeToDown()
        {
            dragon.state = new DragonWalkDownState(dragon);
        }
        public void GetDamaged()
        {
            dragon.state = new DragonWalkUpDamageState(dragon);
        }

    }
}
