using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class DamageBombAppearExplodeState:IItemState
    {
        private DamageBomb bomb;

        public DamageBombAppearExplodeState(DamageBomb bomb)
        {
            if (bomb == null)
            {
                throw new ArgumentNullException(nameof(bomb));
            }
            this.bomb = bomb;
            bomb.bombSprite = ItemSpriteFactory.Instance.CreateBombSprite(true, true);
        }
      

         
        public static void ChangeToExplode()
        {
            //already explode
           
        }
    }
}
