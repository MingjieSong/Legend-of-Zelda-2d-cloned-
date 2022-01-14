using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace Sprint2 
{
    public class LinkStandUpAttackDamageState: IPlayerstate
    {
        private Link link;
       // private Texture2D texture = Texture2DStorage.GetLinkSpriteSheet2();
        public LinkStandUpAttackDamageState(Link link)
        {
            if (link == null)
            {
                throw new ArgumentNullException(nameof(link));
            }
            link.linkSprite = LinkSpriteFactory.Instance.CreateLinkAttackSprite("Up", true);
            this.link = link;
            this.link.ChangeDirection(0);
            Link.ifDamage = true;

            link.simpleAttackBox = new Rectangle(Link.posX + 10, Link.posY - 45, 25, 45);
            
        }
       
        public void ChangeToRight()
        {
            if (Link.ifDamage)
            {
                link.state = new LinkStandRightNonAttackDamageState(link);
               
            }
            else
            {
                link.state = new LinkStandRightNonAttackNonDamageState(link);
            }
        }
        public void Win()
        {
            link.state = new LinkWinningState(link);
        }
        public void ChangeToLeft()
        {
            if (Link.ifDamage)
            {
                link.state = new LinkStandLeftNonAttackDamageState(link);
            }
            else
            {
                link.state = new LinkStandLeftNonAttackNonDamageState(link);
            }
        }
        public void ChangeToUp()
        {
            if (Link.ifDamage)
            {
                link.state = new LinkStandUpNonAttackDamageState(link);
            }
            else
            {
                link.state = new LinkStandUpNonAttackNonDamageState(link);
            }
        }
        public void ChangeToDown()
        {
            if (Link.ifDamage)
            {
                link.state = new LinkStandDownNonAttackDamageState(link);
            }
            else
            {
                link.state = new LinkStandDownNonAttackNonDamageState(link);
            }
        }
        public void GetDamaged()
        {
            link.state = new LinkStandUpNonAttackDamageState(link);
        }
        public void Attack()
        {
            link.state = new LinkStandUpAttackDamageState(link);
            
        }
        public void ChangeToWalk()
        {
            if (Link.ifDamage)
            {
                link.state = new LinkWalkUpNonAttackDamageState(link);
            }
            else
            {
                link.state = new LinkWalkUpNonAttackNonDamageState(link);
            }
        }
        public void ChangeToStand()
        {
            if(!Link.ifDamage)
            {
                link.state = new LinkStandUpNonAttackNonDamageState(link);
            } 
        }

        public void LinkWithItemUp(int item)
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
