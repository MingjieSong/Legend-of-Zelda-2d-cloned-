using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace Sprint2 { 
   public  class LinkStandDownAttackNonDamageState: IPlayerstate
    {
        private Link link;
        public LinkStandDownAttackNonDamageState(Link link)
        {
            if (link == null)
            {
                throw new ArgumentNullException(nameof(link));
            }
            link.linkSprite = LinkSpriteFactory.Instance.CreateLinkAttackSprite("Down", false);
            this.link = link;
            this.link.ChangeDirection(1);
            link.simpleAttackBox = new Rectangle(Link.posX+10, Link.posY + 45, 25,  45);



        }
        public void Win()
        {
            link.state = new LinkWinningState(link);

        }
        public void ChangeToRight()
        {
            
            link.state = new LinkStandRightNonAttackNonDamageState(link);
            
        }
        public void ChangeToLeft()
        {
            link.state = new LinkStandLeftNonAttackNonDamageState(link);
           
        }
        public void ChangeToUp()
        {
            link.state = new LinkStandUpNonAttackNonDamageState(link);
          
        }
        public void ChangeToDown(){
            link.state = new LinkStandDownNonAttackNonDamageState(link);
           
        }
        public void GetDamaged()
        {
            link.state =new LinkStandDownNonAttackDamageState(link);
        }
        public void Attack() {
            
                link.state = new LinkStandDownAttackNonDamageState(link);
            
        }
        public void ChangeToWalk()
        {
            // cannot walk when attack
        }
        public void ChangeToStand()
        {
            //already stand
        }

      //  public void LinkWithBomb()
        //{
          //  link.state = new LinkDownWithBombState(link);
        //}

        //public void LinkWithSword()
        //{
          //  link.state = new LinkDownWithSwordState(link);
        //}
       

        public void LinkWithItemUp( int item)
        {
            link.state = new LinkWithItemUpState(link, item);
           
        }

        public void LinkWithItemDown(int item)
        {
            link.state = new LinkWithItemDownState(link, item);
        }

        public void LinkWithItemLeft(int item)
        {
            link.state = new LinkWithItemLeftState(link, item);
           
        }

        public void LinkWithItemRight(int item)
        {
            link.state = new LinkWithItemRightState(link, item);
           
        }
    }
}
