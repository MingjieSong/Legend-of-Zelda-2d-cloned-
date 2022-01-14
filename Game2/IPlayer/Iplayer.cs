using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    
     public interface IPlayer
    {
          List<IItem> Items { get; set; }  
        Rectangle boundingBox { get; set; }
          Rectangle simpleAttackBox { get; set; }
        IPlayerstate state { get; set; }
        void ChangeToRight();
        void ChangeToLeft();
        void ChangeToUp();
        void ChangeToDown();
        
        void ChangeToStand();
        void ChangeToWalk();
        void Win();
        int GetDirection();
      

        void GetDamaged();
        void Attack();
        
         
        void SetLinkWithItemLeftState(int itemNum);
        void SetLinkWithItemRightState(int itemNum);
        void SetLinkWithItemUpState(int itemNum);
        void SetLinkWithItemDownState(int itemNum);
       
        void Update();
        void Draw(SpriteBatch spriteBatch);
        //for detection class 
        List<Rectangle> getUsingItemRec();
        void manageLinkItem();

    }
}
