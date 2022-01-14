using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
 
 

namespace Sprint2 
{
    public class LinkStandUpAttackNonDamageState:IPlayerstate
    {
        private Link link;
        public LinkStandUpAttackNonDamageState(Link link)
        {
            if (link == null)
            {
                throw new System.ArgumentNullException(nameof(link));
            }
            link.linkSprite = LinkSpriteFactory.Instance.CreateLinkAttackSprite("Up", false);
            this.link = link;
            this.link.ChangeDirection(0);
            link.simpleAttackBox = new Rectangle(Link.posX+10, Link.posY - 45, 25,45);

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
        public void ChangeToDown()
        {
            link.state = new LinkStandDownNonAttackNonDamageState(link);
        }
        public void GetDamaged()
        {
            link.state = new LinkStandUpNonAttackDamageState(link);
        }
        public void Attack()
        {
            
                link.state = new LinkStandUpAttackNonDamageState(link);
             
        }
        public void ChangeToWalk()
        {
            
        }
        public void ChangeToStand()
        {
            //already stand
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
