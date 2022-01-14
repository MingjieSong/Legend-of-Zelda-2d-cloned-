using Microsoft.Xna.Framework.Graphics;
using System;
 
namespace Sprint2 
{
    public class EnemyWalkUpState: IEnemyState
    {
        private int number; 
        private IEnemy  enemy;
        public EnemyWalkUpState(IEnemy enemy, int number)
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
                    // trap maybe 
                    // fix later
                    // enemy.ChangeSprite(new BatSprite(texture1, "Up"));
                    enemy.ChangeSprite(EnemySpriteFactory.Instance.CreateBatSprite("Up", enemy));
                     break;
                case 1:
                    enemy.ChangeSprite(EnemySpriteFactory.Instance.CreateStalfoSprite("Up", enemy));
                    break;
                case 2:

                  enemy.ChangeSprite(EnemySpriteFactory.Instance.CreateRedGoriyaSprite("Up", enemy));
                  break;
                case 3:
                    enemy.ChangeSprite(EnemySpriteFactory.Instance.CreateZolSprite("Up", enemy));
                    break;
                case 4:
                    enemy.ChangeSprite(EnemySpriteFactory.Instance.CreateRopeSprite("Up", enemy));

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
            enemy.ChangeState(new EnemyWalkRightState(enemy, number));
        }

        public void ChangeToLeft()
        {
            enemy.ChangeState(new EnemyWalkLeftState(enemy, number));
        }

        public void ChangeToUp()
        {
            
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
