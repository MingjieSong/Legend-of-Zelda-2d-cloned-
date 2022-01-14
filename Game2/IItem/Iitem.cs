using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace Sprint2
{
    public interface IItem
    {
        Rectangle BoundingBox { get; set; }
         int PosX { get; set; }
         int PosY { get; set; }
         int Count { get; set; }
         int TotalCount { get; set; }
        bool Appear { get; set; }

        void ChangeSprite(ISprite sprite);
      
        int GetItem();
        void Update();
        void Draw(SpriteBatch spriteBatch);
    }
}
