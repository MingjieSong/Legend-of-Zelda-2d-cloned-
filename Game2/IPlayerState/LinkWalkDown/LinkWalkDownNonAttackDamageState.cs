using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    class LinkWalkDownNonAttackDamageState : IPlayerstate
    {
        private Link linkPlayer;
        
        public LinkWalkDownNonAttackDamageState(Link link)
        {
            linkPlayer = link;
            linkPlayer.linkSprite = LinkSpriteFactory.Instance.CreateLinkWalkSprite("Down", true);
            //change link's current direction 
            link.ChangeDirection(1);
            Link.ifDamage = true;
          

        }
        public void Win()
        {
            linkPlayer.state = new LinkWinningState(linkPlayer);
        }

        public void ChangeToRight()
        {
            if (Link.ifDamage)
            {
                linkPlayer.state = new LinkWalkRightNonAttackDamageState(linkPlayer);
            }
            else
            {
                linkPlayer.state = new LinkWalkRightNonAttackNonDamageState(linkPlayer);
            }

        }
        public void ChangeToLeft()
        {
            if (Link.ifDamage)
            {
                linkPlayer.state = new LinkWalkLeftNonAttackDamageState(linkPlayer);
            }
            else
            {
                linkPlayer.state = new LinkWalkLeftNonAttackNonDamageState(linkPlayer);
            }


        }
        public void ChangeToUp()
        {
            if (Link.ifDamage)
            {
                linkPlayer.state = new LinkWalkUpNonAttackDamageState(linkPlayer);
            }
            else
            {
                linkPlayer.state = new LinkWalkUpNonAttackNonDamageState(linkPlayer);
            }
        }
        public void ChangeToDown()
        {
           


        }
        public void GetDamaged()
        {

        }
        public void Attack()
        {
            
             
        }

        public void ChangeToWalk()
        {
           if (!Link.ifDamage)
            {
                linkPlayer.state = new LinkWalkDownNonAttackNonDamageState(linkPlayer);
            }
        }
        public void ChangeToStand()
        {
    
            
            if (Link.ifDamage)
            {
                linkPlayer.state = new LinkStandDownNonAttackDamageState(linkPlayer);
            }
            else
            {
                linkPlayer.state = new LinkStandDownNonAttackNonDamageState(linkPlayer);
            } 
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
