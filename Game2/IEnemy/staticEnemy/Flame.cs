using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Sprint2
{
    public class Flame : IEnemy
    {
        private StaticSprite cloudSprite = new StaticSprite(Texture2DStorage.GetCloudSpriteSheet(), 110, 9, 14, 14);
        private StaticSprite sparkSprite = new StaticSprite(Texture2DStorage.GetLinkSpriteSheet(), 209, 282, 17, 21);
        private int drawCloud = 0; 
        private Vector2 initialPos;
        public int sparkTimer { get; set; } = 0;
        public int blood { get; set; } = 2;
        public bool damage { set; get; }
        private ISprite flameSprite;


        //the current position of the trap
        public int posX { get; set; }
        public int posY { get; set; }

        private int width =16;
        private int height =16;
        public Rectangle boundingBox { get; set; }
        private int damageTimer = 0;

        public Flame(Vector2 vector)
        {
           
            posX = (int)vector.X;
            posY = (int)vector.Y;
            initialPos = new Vector2(posX, posY);
            flameSprite = EnemySpriteFactory.Instance.CreateFlameSprite();
        }



        public void ChangeToRight()
        {
            //have no state
        }
        public void ChangeToLeft()
        {
            //have no state
        }
        public void ChangeToUp()
        {
            //have no state
        }
        public void ChangeToDown()
        {
            //have no state
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
                damage = true;
                blood--;
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
            flameSprite.Update();
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
                    flameSprite.Draw(spriteBatch, new Vector2(posX, posY));
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
