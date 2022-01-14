using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Xml;

namespace Sprint2
{

    public class ObjectLoader
    {
        private List<IEnemy> enemyList;
        private List<IItem> itemList;
        private List<INpc> npcList;
         
        public ObjectLoader()
        {

        }

        public void loadObject(IRoom room, String type, String name, Vector2 vector)
        {
            if (room == null)
            {
                throw new ArgumentNullException(nameof(room));
            }
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type));
            }
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (vector == null)
            {
                throw new ArgumentNullException(nameof(vector));
            }


            enemyList = room.enemies;
            itemList = room.pickUpItems;
            npcList = room.npcs;
             
           

            if (type == "Enemy")
            {
                if (name == "Dragon")
                {
                    enemyList.Add(new Dragon(vector));
                }
                if (name == "GreenDragon")
                {
                    enemyList.Add(new GreenDragon(vector));
                }
                if (name == "WallMaster")
                {

                    enemyList.Add(new WallMaster(vector));
                }
               
                if (name == "Flame")
                {
                    enemyList.Add(new Flame(vector));
                }
                if (name == "Trap")
                {
                    enemyList.Add(new Trap(vector));
                }
                if (name == "Goriya")
                {
                    enemyList.Add(new Goriya(vector));
                }
                if (name == "Keese")
                {
                    enemyList.Add(new Keese(vector));
                }
                if (name == "Rope")
                {
                    enemyList.Add(new Rope(vector));
                }
                if (name == "Stalfos")
                {
                    enemyList.Add(new Stalfos(vector));
                }
                if (name == "Zol")
                {
                    enemyList.Add(new Zol(vector));
                }
            }
            if (type == "Item")
            {
                if(name == "Cloud")
                {
                    itemList.Add(new Cloud(vector));
                }
                if (name == "BlueDiamond")
                {
                    itemList.Add(new YellowDiamond(vector));
                }
                if (name == "BluePotion")
                {
                    itemList.Add(new BluePotion(vector));
                }
                if (name == "BlueRing")
                {
                    itemList.Add(new BlueRing(vector));
                }
                if (name == "Clock")
                {
                    itemList.Add(new Clock(vector));
                }
                if (name == "Compass")
                {
                    itemList.Add(new Compass(vector));
                }
                if (name == "Fairy")
                {
                    itemList.Add(new Fairy(vector));
                }
                if (name == "Heart")
                {
                    itemList.Add(new Heart(vector));
                }
               
                if (name == "Key")
                {
                    itemList.Add(new Key(vector));
                }
                if (name == "Map")
                {
                    itemList.Add(new Map(vector));
                }
                if (name == "TriforcePiece")
                {
                    itemList.Add(new TriforcePiece(vector));
                }
                if (name == "StaticBomb")
                {
                    itemList.Add(new staticBomb(vector));
                }
                //"boomerang","bow","candle"
                if (name == "boomerang")
                {
                    itemList.Add(new staticWoodenBoomerang(vector));
                }
                if (name == "bow")
                {
                    itemList.Add(new staticBow(vector));
                }
                if (name == "candle")
                {
                    itemList.Add(new staticCandle(vector));
                }
                if(name=="Up"||name=="Down"||name=="Right"|| name == "Left")//LockedDoor  
                {
                    
                    itemList.Add(new LockedDoor(name,vector));
                }
            }
            else if (type == "NPC")
            {
                if (name == "Merchant")
                {

                    npcList.Add(new Merchant(vector));

                }
                if (name == "OldMan")
                {

                    npcList.Add(new OldMan(vector));
                }
                if (name == "Princess")
                {
                    npcList.Add(new Princess(vector));
                }
            }
            else if (type == "Wall")
            {
                if ((room.roomNumber == 8 || room.roomNumber == 9) && !Room.DoorOpen.Contains(8))
                {
                    itemList.Add(new Wall(name, vector));
                }
                else if ((room.roomNumber == 7 || room.roomNumber == 11) && !Room.DoorOpen.Contains(7))
                {
                    itemList.Add(new Wall(name, vector));
                }
                else if(room.roomNumber==19)
                {
                    itemList.Add(new Wall(name, vector));
                }

            }else if (type == "SmallBox")
            {
                itemList.Add(new Box( new Vector2(vector.X-5,vector.Y-2)));
            }

        }
    }
}
