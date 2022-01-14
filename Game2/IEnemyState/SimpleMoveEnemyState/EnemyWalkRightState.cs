using Microsoft.Xna.Framework.Graphics;
using System;
 
namespace Sprint2 
{
    public class EnemyWalkRightState: IEnemyState
    {
        private int number; 
        private IEnemy  enemy;
        public EnemyWalkRightState(IEnemy enemy, int number)
        {
            if (enemy == null)
            {
                throw new ArgumentNullException(nameof(enemy));
            }
            this.number = number;
            this.enemy = enemy;
            switch (number)
            {
                
                case 0:
                  enemy.ChangeSprite(EnemySpriteFactory.Instance.CreateBatSprite("Right", enemy));
                   break;
                case 1:
                    enemy.ChangeSprite(EnemySpriteFactory.Instance.CreateStalfoSprite("Right", enemy));
                    break;
                case 2:

                   enemy.ChangeSprite(EnemySpriteFactory.Instance.CreateRedGoriyaSprite("Right", enemy));
                   break;
                case 3:
                    enemy.ChangeSprite(EnemySpriteFactory.Instance.CreateZolSprite("Right", enemy));
                    break;
                case 4:
                    enemy.ChangeSprite(EnemySpriteFactory.Instance.CreateRopeSprite("Right", enemy));

                    break;
                default:
#pragma warning disable CA1303 // Do not pass literals as localized parameters
                    Console.WriteLine("error: no such situation");
#pragma warning restore CA1303 // Do not pass literals as localized parameters
                    break;
            }
        }
        public void ChangeToRight()
        {
             //already right
        }

        public void ChangeToLeft()
        {
            enemy.ChangeState(new EnemyWalkLeftState(enemy, number));
        }

        public void ChangeToUp()
        {
            enemy.ChangeState(new EnemyWalkUpState(enemy, number));
        }

        public void ChangeToDown()
        {
            enemy.ChangeState(new EnemyWalkDownState(enemy, number));
        }
        public void GetDamaged()
        {
            //
        }

    }
}
