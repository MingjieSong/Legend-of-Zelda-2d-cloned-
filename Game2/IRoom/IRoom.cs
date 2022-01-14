using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Sprint2
{
    public interface IRoom
    {
#pragma warning disable IDE1006 // Naming Styles
        int roomNumber { get; set; }
#pragma warning restore IDE1006 // Naming Styles
        int leftRoomNum { get; set; }
        int rightRoomNum { get; set; }
        int upRoomNum { get; set; }
        int downRoomNum { get; set; }
        Vector2 roomPos { get; set; }
         
        List<IEnemy> enemies { get; set; }
        List<IItem> pickUpItems { get; set; }
        List<INpc> npcs { get; set; }
        List<KeyValuePair<int, int>> blockLocation { get; set; }
        List<string> doorDirection { get; set; }
#pragma warning disable CA2227 // Collection properties should be read only
        List<LockedDoor> lockedDoor { get; set; }
#pragma warning restore CA2227 // Collection properties should be read only
#pragma warning disable CA2227 // Collection properties should be read only
        
#pragma warning restore CA2227 // Collection properties should be read only
#pragma warning disable IDE1006 // Naming Styles
        List<KeyValuePair<Vector2, Vector2>> stair { get; set; }
         
#pragma warning restore IDE1006 // Naming Styles

        List<Rectangle> boundingBox { get; set; }

        void setItemToNull(int itemNum);
        void setEnemyToNull(int enemyNum);
        void setLockedDoorToNull(int num);
        void Update();
        void Draw(SpriteBatch spriteBatch);
    }
}
