using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class LinkWalkUpNonAttackNonDamageState: IPlayerstate
    {
        private Link linkPlayer; 
//private Texture2D texture = Texture2DStorage.GetLinkSpriteSheet();
        //non damaged, non attack
        public LinkWalkUpNonAttackNonDamageState(Link link )
        {
            if(link == null)
            {
                throw new ArgumentNullException(nameof(link));
            }
            linkPlayer = link;
            link.linkSprite = LinkSpriteFactory.Instance.CreateLinkWalkSprite("Up", false);
            linkPlayer.ChangeDirection(0);
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
            // NO-OP
            // already up, do nothing

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
             
            linkPlayer.state = new LinkWalkUpNonAttackDamageState(linkPlayer);
            

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
            linkPlayer.state = new LinkStandUpNonAttackNonDamageState(linkPlayer);
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
