using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{

 
    public interface IGameState
    {
        //string name { get; set; }
        
        void Update();
        void Draw(SpriteBatch spriteBatch);
       
    }
}
