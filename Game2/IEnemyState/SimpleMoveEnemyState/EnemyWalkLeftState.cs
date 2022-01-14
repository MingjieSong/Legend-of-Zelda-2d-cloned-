using Microsoft.Xna.Framework.Graphics;
using System;
 
namespace Sprint2 
{
    public class EnemyWalkLeftState: IEnemyState
    {
        private int number; 
        private IEnemy  enemy;
        public EnemyWalkLeftState(IEnemy enemy, int number)
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

                    enemy.ChangeSprite(EnemySpriteFactory.Instance.CreateBatSprite("Left", enemy));
                    break;
                case 1:
                    enemy.ChangeSprite(EnemySpriteFactory.Instance.CreateStalfoSprite("Left", enemy));
                    break;
                case 2:

                    enemy.ChangeSprite(EnemySpriteFactory.Instance.CreateRedGoriyaSprite("Left", enemy));
                    break;
                case 3:
                    enemy.ChangeSprite(EnemySpriteFactory.Instance.CreateZolSprite("Left", enemy));
                    break;
                case 4:
                    enemy.ChangeSprite(EnemySpriteFactory.Instance.CreateRopeSprite("Left", enemy));

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
           //nothing
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
