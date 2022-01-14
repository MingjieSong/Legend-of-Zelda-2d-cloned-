using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class DamageBombAppearUnExplodeState  : IItemState
    {
        private DamageBomb bomb;
       // private Texture2D texture = Texture2DStorage.GetHurtBoomSpriteSheet();

        public DamageBombAppearUnExplodeState(DamageBomb bomb)
        {
            if (bomb == null)
            {
                throw new ArgumentNullException(nameof(bomb));
            }
            this.bomb = bomb;

            bomb.bombSprite = ItemSpriteFactory.Instance.CreateBombSprite(false, true);
        }
     

       

        public void ChangeToExplode()
        {
            bomb.state = new DamageBombAppearExplodeState(bomb);
        }
    }
}
