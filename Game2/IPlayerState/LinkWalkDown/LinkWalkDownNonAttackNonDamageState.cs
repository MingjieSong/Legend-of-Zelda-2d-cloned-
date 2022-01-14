using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  Sprint2
{
    class LinkWalkDownNonAttackNonDamageState: IPlayerstate
    {
        private Link linkPlayer;
        //non damaged, non attack
        public LinkWalkDownNonAttackNonDamageState(Link link )
        {
            linkPlayer = link;
            link.linkSprite = LinkSpriteFactory.Instance.CreateLinkWalkSprite("Down", false);
            link.ChangeDirection(1);

        }

        public void Win()
        {
            linkPlayer.state = new LinkWinningState(linkPlayer);
        }
        public void ChangeToRight()
        {
            linkPlayer.state = new LinkWalkRightNonAttackNonDamageState(linkPlayer);
            
        }
        public void ChangeToLeft()
        {
            linkPlayer.state = new LinkWalkLeftNonAttackNonDamageState(linkPlayer);
             

        }
        public void ChangeToUp()
        {
            linkPlayer.state = new LinkWalkUpNonAttackNonDamageState(linkPlayer);
             

        }
        public void ChangeToDown()
        {
            // NO-OP
            // already down, do nothing

        }
        public void GetDamaged()
        {
           
            linkPlayer.state = new LinkWalkDownNonAttackDamageState(linkPlayer);
            

        }
        public void Attack()
        {
            
            

        }

        public void ChangeToWalk()
        {
            //already walk
        }
        public void ChangeToStand()
        {
            linkPlayer.state = new LinkStandDownNonAttackNonDamageState(linkPlayer);
        }

        public void LinkWithItemUp(int item)
        {
            linkPlayer.state = new LinkWithItemDownState(linkPlayer, item);
        }

        public void LinkWithItemDown(int item)
        {
             //do nothing
        }

        public void LinkWithItemLeft(int item)
        {
            linkPlayer.state = new LinkWithItemLeftState(linkPlayer, item);
        }

        public void LinkWithItemRight(int item)
        {
            linkPlayer.state = new LinkWithItemRightState(linkPlayer, item);
        }











    }
}
