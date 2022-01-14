using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    class LinkWalkLeftNonAttackDamageState : IPlayerstate
    {
        private Link linkPlayer;

        //private Texture2D texture = Texture2DStorage.GetLinkSpriteSheet2();
        public LinkWalkLeftNonAttackDamageState(Link link)
        {
            linkPlayer = link;

            linkPlayer.linkSprite = LinkSpriteFactory.Instance.CreateLinkWalkSprite("Left", true);
            link.ChangeDirection(2);
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

            if (Link.ifDamage)
            {
                linkPlayer.state = new LinkWalkDownNonAttackDamageState(linkPlayer);
            }
            else
            {
                linkPlayer.state = new LinkWalkDownNonAttackNonDamageState(linkPlayer);
            }

        }
        public void Win()
        {
            linkPlayer.state = new LinkWinningState(linkPlayer);
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
                  linkPlayer.state = new LinkWalkLeftNonAttackNonDamageState(linkPlayer);
              }

        }
        public void ChangeToStand()
        {
            if (Link.ifDamage)
            {
                linkPlayer.state = new LinkStandLeftNonAttackDamageState(linkPlayer);
            }
            else
            {
                linkPlayer.state = new LinkStandLeftNonAttackNonDamageState(linkPlayer);
            }
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
