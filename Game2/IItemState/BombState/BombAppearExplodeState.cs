using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class BombAppearExplodeState:IItemState
    {
        private Bomb bomb;

        public BombAppearExplodeState(Bomb bomb)
        {
            if (bomb == null)
            {
                throw new ArgumentNullException(nameof(bomb));
            }
            this.bomb = bomb;
            bomb.bombSprite = ItemSpriteFactory.Instance.CreateBombSprite(true, false);
        }
      

         
        public static void ChangeToExplode()
        {
            //already explode
           
        }
    }
}
