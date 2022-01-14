using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2 
{
    public class DragonWalkRightState : IEnemyState
    {
        private Dragon dragon;
        public DragonWalkRightState(Dragon dragon)
        {
            if (dragon == null)
            {
                throw new ArgumentNullException(nameof(dragon));
            }
            this.dragon = dragon;
            dragon.DragonSprite = EnemySpriteFactory.Instance.CreateYellowDragonSprite("Right", this.dragon, false);
            dragon.fire = new Fire(dragon.posX+80, dragon.posY , 3);
            Dragon.hasFire = true;
        }
        public void ChangeToRight()
        {
            //already right
        }

        public void ChangeToLeft()
        {
            dragon.state = new DragonWalkLeftState(dragon);
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
            dragon.state = new DragonWalkRightDamageState(dragon);
        }
    }
}
