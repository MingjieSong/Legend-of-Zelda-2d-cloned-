using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class GreenDragonWalkLeftDamageState : IEnemyState
    {

        private GreenDragon greenDragon;
        public GreenDragonWalkLeftDamageState(GreenDragon dragon)
        {
            if (dragon == null)
            {
                throw new ArgumentNullException(nameof(dragon));
            }
            this.greenDragon = dragon;
            greenDragon.GreenDragonSprite = EnemySpriteFactory.Instance.CreateGreenDragonSprite("Left", greenDragon, true);

            greenDragon.fire = new FireSpreadMiddle(greenDragon.posX - 30, greenDragon.posY + 30, 2);
            greenDragon.fireSpreadDown = new FireSpreadDown(greenDragon.posX - 30, greenDragon.posY + 40, 2);
            greenDragon.fireSpreadUp = new FireSpreadUp(greenDragon.posX - 30, greenDragon.posY + 10, 2);
            GreenDragon.hasFire = true;
            greenDragon.damage = true;
        }
        public void ChangeToRight()
        {
            if (greenDragon.damage)
            {
                greenDragon.state = new GreenDragonWalkRightDamageState(greenDragon);
            }
            else
            {
                greenDragon.state = new GreenDragonWalkRightState(greenDragon);
            }

        }

        public void ChangeToLeft()
        {
            //already left 
        }

        public void ChangeToUp()
        {
            //none
        }

        public void ChangeToDown()
        {
            //none
        }
        public void GetDamaged()
        {
            //already damaged
        }
    }
}
