using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2 
{
    public class LinkWinningState:IPlayerstate
    {
        private Link link;
        public LinkWinningState(Link link)
        {
            if (link == null)
            {
                throw new System.ArgumentNullException(nameof(link));
            }
            this.link = link;
            
            link.linkSprite = LinkSpriteFactory.Instance.CreateLinkWinningSprite();

        }

        public void Win()
        {
            //already win

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
        public void ChangeToDown()
        {
            link.state = new LinkStandDownNonAttackNonDamageState(link);
        }
        public void GetDamaged()
        {
            //link.state = new LinkStandDownNonAttackDamageState(link);

        }
        /*public static int getFaceDirection()
        {
            return 1;
        }*/
        public void Attack()
        {
            //link.state = new LinkStandDownAttackNonDamageState(link);
        }
        public void ChangeToWalk()
        {
           // link.state = new LinkWalkDownNonAttackNonDamageState(link);
        }
        public void ChangeToStand()
        {
            //already stand
        }
        public void LinkWithItemUp(int item)
        {
            //link.state = new LinkWithItemUpState(link, item);
        }

        public void LinkWithItemDown(int item)
        {
            //link.state = new LinkWithItemDownState(link, item);
        }

        public void LinkWithItemLeft(int item)
        {
            //link.state = new LinkWithItemLeftState(link, item);
        }

        public void LinkWithItemRight(int item)
        {
            //link.state = new LinkWithItemRightState(link, item);
        }
    }
}

