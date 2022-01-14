using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class AppearUpState : IItemState
    {

        private IItem linkItem;
        int num;



        public AppearUpState(IItem item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }
            this.linkItem = item;
            num = item.GetItem();

            if (num == 0)
            {
                linkItem.ChangeSprite(ItemSpriteFactory.Instance.CreateArrowSprite("Up", linkItem, false));
            }
              if (num == 1)
            {
                linkItem.ChangeSprite(ItemSpriteFactory.Instance.CreateBlueCandleSprite("Up", linkItem, false));
            }
              if (num == 2)
            {
                linkItem.ChangeSprite(ItemSpriteFactory.Instance.CreateBombSprite(false, false));
            }
             if (num == 3)
            {
                linkItem.ChangeSprite(ItemSpriteFactory.Instance.CreateBowSprite("Up", false));
            }
             if (num == 4)
            {
                linkItem.ChangeSprite(ItemSpriteFactory.Instance.CreateWoodSwordSprite("Up", linkItem, false));
            }
             if (num == 5)
            {
                linkItem.ChangeSprite(ItemSpriteFactory.Instance.CreateWoodBoomerangSprite("Up", linkItem, false));
            }
            if (num == 6)
            {
                linkItem.ChangeSprite(ItemSpriteFactory.Instance.CreateWoodSwordSprite("Up", linkItem, true));
            }
            if (num == 7)
            {
                linkItem.ChangeSprite(ItemSpriteFactory.Instance.CreateArrowSprite("Up", linkItem, true));
            }
            if (num == 8)
            {
                linkItem.ChangeSprite(ItemSpriteFactory.Instance.CreateBlueCandleSprite("Up", linkItem, true));
            }
            if (num == 9)
            {
                linkItem.ChangeSprite(ItemSpriteFactory.Instance.CreateBombSprite(false, true));
            }
            if (num == 10)
            {
                linkItem.ChangeSprite(ItemSpriteFactory.Instance.CreateWoodBoomerangSprite("Up", linkItem, true));
            }
            if (num == 11)
            {
                linkItem.ChangeSprite(ItemSpriteFactory.Instance.CreateBowSprite("Up", true));
            }
            if (num == 15)
            {
                linkItem.ChangeSprite(ItemSpriteFactory.Instance.CreateFireballSprite("Up", linkItem, false));
            }

        }

       


    }
}

