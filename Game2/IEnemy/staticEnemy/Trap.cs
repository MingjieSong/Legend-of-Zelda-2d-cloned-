using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class Trap : IEnemy
    {
        private StaticSprite cloudSprite = new StaticSprite(Texture2DStorage.GetCloudSpriteSheet(), 110, 9, 14, 14);
        private StaticSprite sparkSprite = new StaticSprite(Texture2DStorage.GetLinkSpriteSheet(), 209, 282, 17, 21);
        private int drawCloud = 0;
        private Vector2 initialPos;
        public int sparkTimer { get; set; } = 0;
        private ISprite trapSprite;
        public bool damage { set; get; }
        public int blood { get; set; } = 2;

        //the current position of the trap
        public int posX { get; set; }
        public int posY { get; set; }

        public Rectangle boundingBox { get; set; }
        private int width =8;
        private int height =14;
        private int damageTimer = 0;
        public Trap(Vector2 vector)
        {
            
            posX = (int)vector.X;
            posY = (int)vector.Y;
            initialPos = new Vector2(posX, posY);
            trapSprite = EnemySpriteFactory.Instance.CreateTrapSprite(this);
        }



        public void ChangeToRight()
        {
        }
        public void ChangeToLeft()
        {
        }
        public void ChangeToUp()
        {
        }
        public void ChangeToDown()
        {
        }
        public void ChangeState(IEnemyState state)
        {
            //have no state

        }

        public void ChangeSprite(ISprite sprite)
        {
            //only one sprite

        }

        public void GetDamage()
        {
            
            if (Link.ifDamage && !damage)
            {
                blood--;
                damage = true;
            }
            else if (!damage)
            {
                blood -= 2;
                damage = true;
            }
        }




        public void Update()
        {
            if (damage)
            {
                damageTimer++;
                if (damageTimer >= 50)
                {
                    damage = false;
                }
            }
            else
            {
                damageTimer = 0;
            }
            drawCloud++;
            boundingBox = new Rectangle(posX, posY, width * 3, height * 3);
            trapSprite.Update();
            if (blood <= 0)
            {
                sparkTimer++;
            }

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (blood <= 0)
            {
                sparkSprite.Draw(spriteBatch, new Vector2(posX, posY));
            }
            else
            {
                if (drawCloud <= 20)
                {
                    cloudSprite.Draw(spriteBatch, initialPos);
                }
                else
                {
                    trapSprite.Draw(spriteBatch, new Vector2(posX, posY));
                }
            }
        }

        public List<Rectangle> getProjectileRec()
        {
            List<Rectangle> projectile = new List<Rectangle>();
            return projectile;
        }


    }
}
