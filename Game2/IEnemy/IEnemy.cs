using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics; 
using System.Collections.Generic;
 
namespace Sprint2
{
    public interface IEnemy
    {
        int blood { get; set; }  
        Rectangle boundingBox { get; set; }
         int posX { get; set; }
        int posY { get; set; }
         int sparkTimer { get; set; }  
        void ChangeToLeft();
        void ChangeToRight();
        void ChangeToUp();
        void ChangeToDown();
        

        
        void Update();
        void Draw(SpriteBatch spriteBatch);

       void ChangeState(IEnemyState state);


        void ChangeSprite(ISprite sprite);
        List<Rectangle> getProjectileRec();
        void GetDamage();

        bool damage { get; set; }


    }
}
