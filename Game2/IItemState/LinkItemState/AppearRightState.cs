using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class AppearRightState: IItemState
    {
       
            private IItem linkItem;
            private int num;



            public AppearRightState(IItem item)
            {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }
            this.linkItem = item;
                num = item.GetItem();
              
                if (num == 0)
                {
                linkItem.ChangeSprite(ItemSpriteFactory.Instance.CreateArrowSprite("Right", linkItem, false));
                }
               if (num == 1)
                {
                linkItem.ChangeSprite(ItemSpriteFactory.Instance.CreateBlueCandleSprite("Right", linkItem, false));
                }
                  if (num == 2)
                {
                linkItem.ChangeSprite(ItemSpriteFactory.Instance.CreateBombSprite(false, false));
                }
                 if (num == 3)
                {
                linkItem.ChangeSprite(ItemSpriteFactory.Instance.CreateBowSprite("Right", false));
                }
               if (num == 4)
                {
                linkItem.ChangeSprite(ItemSpriteFactory.Instance.CreateWoodSwordSprite("Right", linkItem, false));
                }
               if (num == 5)
                {
                linkItem.ChangeSprite(ItemSpriteFactory.Instance.CreateWoodBoomerangSprite("Right", linkItem, false));
                }
            if (num == 6)
            {
                linkItem.ChangeSprite(ItemSpriteFactory.Instance.CreateWoodSwordSprite("Right", linkItem, true));
            }
            if (num == 7)
            {
                linkItem.ChangeSprite(ItemSpriteFactory.Instance.CreateArrowSprite("Right", linkItem, true));
            }
            if (num == 8)
            {
                linkItem.ChangeSprite(ItemSpriteFactory.Instance.CreateBlueCandleSprite("Right", linkItem, true));
            }
            if (num == 9)
            {
                linkItem.ChangeSprite(ItemSpriteFactory.Instance.CreateBombSprite(false, true));
            }
            if (num == 10)
            {
                linkItem.ChangeSprite(ItemSpriteFactory.Instance.CreateWoodBoomerangSprite("Right", linkItem, true));
            }
            if (num == 11)
            {
                linkItem.ChangeSprite(ItemSpriteFactory.Instance.CreateBowSprite("Right", true));
            }
            
            if (num == 15)
            {
                linkItem.ChangeSprite(ItemSpriteFactory.Instance.CreateFireballSprite("Right", linkItem, false));
            }
        }
          
           

        }
    }
