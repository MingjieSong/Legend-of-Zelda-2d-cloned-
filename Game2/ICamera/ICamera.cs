 using Microsoft.Xna.Framework.Graphics;
 

namespace Sprint2
{
    public interface ICamera
    {
        void Update();
        void Draw(SpriteBatch spriteBatch); 
       
        string direction { get; set; }
       // bool switchRoom { get; set; }
    }
}