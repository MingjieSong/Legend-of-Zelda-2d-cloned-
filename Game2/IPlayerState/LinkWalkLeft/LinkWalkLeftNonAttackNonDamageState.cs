using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    class LinkWalkLeftNonAttackNonDamageState: IPlayerstate
    {
        private Link linkPlayer; 
        //non damaged, non attack
        public LinkWalkLeftNonAttackNonDamageState(Link link )
        {
            linkPlayer = link;
            link.linkSprite = LinkSpriteFactory.Instance.CreateLinkWalkSprite("Left", false);
            link.ChangeDirection(2);
           

        }
       

        public void ChangeToRight()
        {
            linkPlayer.state = new LinkWalkRightNonAttackNonDamageState(linkPlayer);
        }
        public void ChangeToLeft()
        {
            
            // NO-OP
            // already left, do nothing

        }
        public void ChangeToUp()
        {
          linkPlayer.state = new LinkWalkUpNonAttackNonDamageState(linkPlayer);
             

        }
        public void ChangeToDown()
        {

          linkPlayer.state = new LinkWalkDownNonAttackNonDamageState(linkPlayer);
        }
        public void Win()
        {
            linkPlayer.state = new LinkWinningState(linkPlayer);
        }
        public void GetDamaged()
        {
             
            linkPlayer.state = new LinkWalkLeftNonAttackDamageState(linkPlayer);
            

        }
        public void Attack()
        {
            
            

        }

        public void ChangeToWalk()
        {
            
        }
        public void ChangeToStand()
        {
            linkPlayer.state = new LinkStandLeftNonAttackNonDamageState(linkPlayer);
        }


        public void LinkWithItemUp(int item)
        {
            linkPlayer.state = new LinkWithItemDownState(linkPlayer, item);
        }

        public void LinkWithItemDown(int item)
        {
            linkPlayer.state = new LinkWithItemDownState(linkPlayer, item);
        }

        public void LinkWithItemLeft(int item)
        {
            //linkPlayer.state = new LinkWithItemLeftState(linkPlayer, item);
        }

        public void LinkWithItemRight(int item)
        {
            linkPlayer.state = new LinkWithItemRightState(linkPlayer, item);
        }




    }
}
