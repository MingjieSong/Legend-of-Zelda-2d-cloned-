using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    class LinkWalkUpNonAttackDamageState : IPlayerstate
    {
        private Link linkPlayer;
        
        public LinkWalkUpNonAttackDamageState(Link link)
        {
            linkPlayer = link;
            linkPlayer.ChangeDirection(0);
            linkPlayer.linkSprite = LinkSpriteFactory.Instance.CreateLinkWalkSprite("Up", true);
            Link.ifDamage = true;
             

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

        }
        public void ChangeToDown()
        {
            if (Link.ifDamage)
            {
                linkPlayer.state = new LinkWalkDownNonAttackDamageState(linkPlayer);
            }
            else
            {
                linkPlayer.state = new LinkWalkDownNonAttackNonDamageState(linkPlayer);
            }


        }
        public void GetDamaged()
        {
            // NO-OP
            // already damage, do nothing

        }
        public void Attack()
        {
            
             
        }

        public void ChangeToWalk()
        {
            if (!Link.ifDamage)
            {
                linkPlayer.state = new LinkWalkUpNonAttackNonDamageState(linkPlayer);
            }
        }
        public void ChangeToStand()
        {
            if (Link.ifDamage)
            {
                linkPlayer.state = new LinkStandUpNonAttackDamageState(linkPlayer);
            }
            else
            {
                linkPlayer.state = new LinkStandUpNonAttackNonDamageState(linkPlayer);
            }
        }
        public void Win()
        {
            linkPlayer.state = new LinkWinningState(linkPlayer);
        }
        public void LinkWithItemUp(int item)
        {
           // linkPlayer.state = new LinkWithItemDownState(linkPlayer, item);
        }

        public void LinkWithItemDown(int item)
        {
            linkPlayer.state = new LinkWithItemDownState(linkPlayer, item);
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
