using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Sprint2
{
    public interface ILevel
    {
        
        IRoom room { get; set; }
#pragma warning disable IDE1006 // Naming Styles
        void switchRoom(string direction);
#pragma warning restore IDE1006 // Naming Styles
#pragma warning disable IDE1006 // Naming Styles
        void switchUnderground(Vector2 destRoomPos, string direction);
#pragma warning restore IDE1006 // Naming Styles
        void Update();
        void Draw(SpriteBatch spriteBatch);
        int getNextRoomNum(string direction);
#pragma warning disable CA2227 // Collection properties should be read only
        List<IRoom> existingRooms { get; set; }
#pragma warning restore CA2227 // Collection properties should be read only
        int currentRoomNum { get; set; }

    }
}
