using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class WallMaster : IEnemy
    {
        private StaticSprite cloudSprite = new StaticSprite(Texture2DStorage.GetCloudSpriteSheet(), 110, 9, 14, 14);
        private StaticSprite sparkSprite = new StaticSprite(Texture2DStorage.GetLinkSpriteSheet(), 209, 282, 17, 21);
        private int drawCloud = 0;
        private Vector2 initialPos;
        public int sparkTimer { get; set; } = 0;
        public IEnemyState state;
        public ISprite WallMasterSprite;
        private int updateDelay = 0;
        private int totalDelay = 100;
        public bool damage { set; get; }
        private int damageTimer = 0;
        //for random event
        private bool show = false;


        //the current position of the dragon
        public int posX { get; set; }
        public int posY { get; set; }
        public Rectangle boundingBox { get; set; }
        private int width = 14;
        private int height = 15;
        public int blood { get; set; } = 2;

        public WallMaster(Vector2 vector)
        {
            
            posX = (int)vector.X;
            posY = (int)vector.Y;
            initialPos = new Vector2(posX, posY);
            
                state = new WallMasterRightStaticState(this);          
           
            boundingBox = new Rectangle(posX, posY, width * 3, height * 3);
        }

       
        public void ChangeToRight()
        {
            state.ChangeToRight ();
        }
        public void ChangeToLeft()
        {
            state.ChangeToLeft ();
        }
        
        public void ChangeToUp()
        {

        }
        public void ChangeToDown()
        {

        }

        public void ChangeState(IEnemyState state)
        {
            
        }

        public void ChangeSprite(ISprite sprite)
        {
             
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
            if (!Level1.roomUpdate)
            {
                state = new WallMasterRightStaticState(this);
                WallMasterSprite.Update();
            }
            else
            {
                boundingBox = new Rectangle(posX, posY, width * 3, height * 3);
                WallMasterSprite.Update();
                updateDelay++;
                if (updateDelay == 10)
                {

                    this.ChangeToRight();
                }
                else if (updateDelay == 40)
                {

                    state = new WallMasterRightStaticState(this);

                }
                else if (updateDelay > totalDelay)
                {
                    updateDelay = 0;
                }
            }

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
                    int distanceX = Math.Abs(Link.posX - posX);
                    int distanceY = Math.Abs(Link.posY - posY);
                    if (distanceX < 150 && distanceY < 150)
                    {
                        show = true;
                    }
                    if (show)
                    {
                        WallMasterSprite.Draw(spriteBatch, new Vector2(posX, posY));
                    }
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
