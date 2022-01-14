using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Sprint2
{
    public class GreenDragon : IEnemy
    {
#pragma warning disable CA1051 // Do not declare visible instance fields
        public IEnemyState state;
#pragma warning restore CA1051 // Do not declare visible instance fields
#pragma warning disable CA1051 // Do not declare visible instance fields
        public ISprite GreenDragonSprite;
#pragma warning restore CA1051 // Do not declare visible instance fields

        public bool damage { get; set; } = false;
        private int updateDelay = 0;
        private int totalDelay = 100;
        private int step = 0;
        private int totalStep = 300;
#pragma warning disable CA1051 // Do not declare visible instance fields
        public IItem fire;
        public IItem fireSpreadUp;
        public IItem fireSpreadDown;
#pragma warning restore CA1051 // Do not declare visible instance fields
#pragma warning disable CA2211 // Non-constant fields should not be visible
        public static Boolean hasFire = false;
#pragma warning restore CA2211 // Non-constant fields should not be visible
        private int fireTimer = 0;
        private int damageTimer = 0;
        
        public int blood { get; set; } = 6;

        //the current position of the dragon
        public int posX { get; set; }
        public int posY { get; set; }
        

        public Rectangle boundingBox { get; set; } = new Rectangle();

        private int width = 24;
        private int height = 32;

        private StaticSprite cloudSprite = new StaticSprite(Texture2DStorage.GetCloudSpriteSheet(), 110, 9, 14, 14);
        private StaticSprite sparkSprite = new StaticSprite(Texture2DStorage.GetLinkSpriteSheet(), 209, 282, 17, 21);
        private int drawCloud = 0;
        public int sparkTimer { get; set; } = 0;
        private Vector2 initialPos;
       
        public GreenDragon(Vector2 vector)
        {
            posX = (int)vector.X;
            posY = (int)vector.Y;
            initialPos = new Vector2(posX, posY);
            state = new GreenDragonWalkLeftState(this);

            boundingBox = new Rectangle(posX, posY, width * 3, height * 3);
        }


        public void ChangeState(IEnemyState state)
        {
            //no op
        }

        public void ChangeSprite(ISprite sprite)
        {
            //no op
        }
        public void ChangeToRight()
        {
            state.ChangeToRight();
        }
        public void ChangeToLeft()
        {
            state.ChangeToLeft();
        }
        public void ChangeToUp()
        {
            //none
        }
        public void ChangeToDown()
        {
            //none
        }
        public void GetDamage()
        {
            if (!damage && Link.ifDamage)
            {
                blood--;
                state.GetDamaged();
            }
            else if(!damage)
            {
                blood -= 2;
                state.GetDamaged();

            }
             
        }




        public void Update()
        {
            drawCloud++;
            GreenDragonSprite.Update();
            if (Level1.roomUpdate)
            {
                boundingBox = new Rectangle(posX, posY, width * 3, height * 3);
              
                if (fire != null && fireSpreadDown !=null && fireSpreadUp!=null)
                {
                    fire.Update();
                    fireSpreadDown.Update();
                    fireSpreadUp.Update();
                }

                if (hasFire)
                {
                    fireTimer++;
                    if (fireTimer == 100)
                    {
                        hasFire = false;
                    }
                }
                else
                {
                    fireTimer = 0;
                    fire = null;
                    fireSpreadDown = null;
                    fireSpreadUp = null;
                }

                //random move dragon
                updateDelay++;
                step++;
                if(step == totalStep)
                {
                    step = 0;
                }
                if (updateDelay == totalDelay)
                {
                    updateDelay = 0;
                    if(step < 2*totalStep/3)
                    {
                        this.ChangeToRight();
                    }
                    else
                    {
                        this.ChangeToLeft();
                    }

                }
            }
           

                drawCloud++;
                if (damage)
            {
                damageTimer++;
                if (damageTimer >= 150)
                {
                    damage = false;
                }
            }
            else
            {
                damageTimer = 0;
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
                sparkSprite.Draw(spriteBatch, new Vector2(posX,posY));
            }
            else
            {
                if (drawCloud <= 20)
                {
                    cloudSprite.Draw(spriteBatch, initialPos);
                    posX = (int)initialPos.X;
                    posY = (int)initialPos.Y;
                }
                else
                {
                    GreenDragonSprite.Draw(spriteBatch, new Vector2(posX, posY));
                    if (fire != null && fireSpreadDown != null && fireSpreadUp != null)
                    {
                        fire.Draw(spriteBatch);
                        fireSpreadUp.Draw(spriteBatch);
                        fireSpreadDown.Draw(spriteBatch);
                    }
                }
            }
        }

        public List<Rectangle> getProjectileRec()
        {
            List<Rectangle> projectileRec = new List<Rectangle>();
            if (fire != null && fireSpreadDown != null && fireSpreadUp != null)
            {

                projectileRec.Add(fire.BoundingBox);
                projectileRec.Add(fireSpreadDown.BoundingBox);
                projectileRec.Add(fireSpreadUp.BoundingBox);

            }



            return projectileRec;
        }




    }
}
