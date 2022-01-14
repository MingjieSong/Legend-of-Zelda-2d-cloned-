using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Xml;

namespace Sprint2
{

    public class Room : IRoom
    {
        private CultureInfo culture;
        private string type;
        private string name;
        private XmlNodeList nodeList;
        private XmlDocument doc;
        private int x;
        private int y;
        private int boxWidth;
        private int boxHeight;
        private Vector2 vector;
        public Vector2 roomPos { get; set; }
        public int roomNumber { get; set; } = 0;
        public int leftRoomNum { get; set; } = 0;
        public int rightRoomNum { get; set; } = 0;
        public int upRoomNum { get; set; } = 0;
        public int downRoomNum { get; set; } = 0;
        public List<IEnemy> enemies { get; set; }
#pragma warning disable CA2227 // Collection properties should be read only
        public List<IItem> pickUpItems { get; set; }
#pragma warning restore CA2227 // Collection properties should be read only
        public List<INpc> npcs { get; set; }

        public List<KeyValuePair<Vector2, Vector2>> stair { get; set; }
        public List<KeyValuePair<int, int>> blockLocation { get; set; }
        public List<string> doorDirection { get; set; } //store door direction Up, Down, Right, Left as string
#pragma warning disable CA2227 // Collection properties should be read only
        public List<LockedDoor> lockedDoor { get; set; }
        
#pragma warning restore CA2227 // Collection properties should be read only
#pragma warning disable CA2227 // Collection properties should be read only
        // public List<string> OpenedDoor { get; set; }
#pragma warning restore CA2227 // Collection properties should be read only

        public List<Rectangle> boundingBox { get; set; }
        public static List<int> DoorOpen { get; set; }= new List<int>();

        public Room()
        {
#pragma warning disable IDE0059 // Unnecessary assignment of a value
            int windowWidth = Game1.WindowWidth;
#pragma warning restore IDE0059 // Unnecessary assignment of a value
#pragma warning disable IDE0059 // Unnecessary assignment of a value
            int windowHeight = Game1.WindowHeight;
#pragma warning restore IDE0059 // Unnecessary assignment of a value
            enemies = new List<IEnemy>();
            pickUpItems = new List<IItem>();
            blockLocation = new List<KeyValuePair<int, int>>();
            doorDirection = new List<string>();
            lockedDoor = new List<LockedDoor>();
             

            stair = new List<KeyValuePair<Vector2, Vector2>>();
            boundingBox = new List<Rectangle>();
            npcs = new List<INpc>();
            



        }
        public Room(RoomLoader load)
        {
            if (load == null)
            {
                throw new ArgumentNullException(nameof(load));
            }
            doc = load.doc;
            nodeList = load.nodeList;


            ObjectLoader objects = new ObjectLoader();
            int windowWidth = 800;// Game1.WindowWidth;
            int windowHeight = 600;// Game1.WindowHeight;
            enemies = new List<IEnemy>();
            pickUpItems = new List<IItem>();
            blockLocation = new List<KeyValuePair<int, int>>();
            doorDirection = new List<string>();
            lockedDoor = new List<LockedDoor>();
            
            stair = new List<KeyValuePair<Vector2, Vector2>>();
            boundingBox = new List<Rectangle>();
            npcs = new List<INpc>();
            

            nodeList = doc.SelectNodes("//Item");

            foreach (XmlNode node in nodeList)
            {
                type = node.ChildNodes[0].InnerText;
                name = node.ChildNodes[1].InnerText;

                //culture = new CultureInfo(locale);
                culture = CultureInfo.CurrentCulture;
                x = Int32.Parse(node.ChildNodes[2].InnerText, culture.NumberFormat);
                y = Int32.Parse(node.ChildNodes[3].InnerText, culture.NumberFormat);

                vector.X = ((float)(x) / 100) * windowWidth;
                vector.Y = ((float)(y) / 100) * windowHeight + 200;

                if (type == "Room")
                {
                    if (name == "RoomNum")
                    {
                        roomNumber = x;
                    }
                    if (name == "Room")
                    {
                        roomPos = vector;
                    }

                    if (name == "Up")
                    {
                        upRoomNum = x;
                    }

                    if (name == "Down")
                    {
                        downRoomNum = x;
                    }

                    if (name == "Left")
                    {
                        leftRoomNum = x;
                    }

                    if (name == "Right")
                    {
                        rightRoomNum = x;
                    }
                }
                else if (type == "Enemy" || type == "Item" || type == "NPC")
                {
                    objects.loadObject(this, type, name, vector);
                }
                else if (type == "Block")
                {
                    blockLocation.Add(new KeyValuePair<int, int>((int)vector.X, (int)vector.Y));
                    
                }
                else if (type == "Door")
                {
                    doorDirection.Add(name); //door direction stores in name
                }
                else if (type == "Wall" || type =="SmallBox")
                {
                    objects.loadObject(this, type, name, vector);
                }
                else if (type == "Stair")
                {
                    int destPosX = Int32.Parse(node.ChildNodes[4].InnerText, culture.NumberFormat);
                    int destPosY = Int32.Parse(node.ChildNodes[5].InnerText, culture.NumberFormat);

                    Vector2 stairPos = vector;
                    Vector2 stairDestPos = new Vector2(destPosX, destPosY);

                    stair.Add(new KeyValuePair<Vector2, Vector2>(stairPos, stairDestPos));


                }
                //for bounding box in room15
                else if (type == "Box")
                {
                    int width = Int32.Parse(node.ChildNodes[4].InnerText, culture.NumberFormat);
                    int height = Int32.Parse(node.ChildNodes[5].InnerText, culture.NumberFormat);
                    float widthFloat = ((float)width / 100) * windowWidth;
                    float heightFloat = ((float)height / 100) * windowHeight;
                    boxWidth = (int)widthFloat;
                    boxHeight = (int)heightFloat;
                    boundingBox.Add(new Rectangle((int)vector.X, (int)vector.Y, (int)boxWidth, (int)boxHeight));

                }
            }

        }
        //index here would be for the list, not the actual item code for each item, other wise unable to locate several same items.
        public void setItemToNull(int itemNum)
        {
            pickUpItems[itemNum] = null;
        }
        public void setEnemyToNull(int enemyNum)
        {
            enemies[enemyNum] = null;

        }
        public void setLockedDoorToNull(int num)
        {
            lockedDoor[num] = null;
        }
        public void Update()
        {


            foreach (IEnemy enemy in enemies)
            {
                if (enemy != null)
                    enemy.Update();

            }
            foreach (IItem item in pickUpItems)
            {
                if (item != null)
                    item.Update();

            }
            foreach (INpc npc in npcs)
            {
                npc.Update();
            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            if(spriteBatch == null)
            {
                throw new ArgumentNullException(nameof(spriteBatch));
            }
            if(roomNumber == 5)
            {
                Rectangle sourceRectangle = new Rectangle(1163,734, 80, 80);
                Rectangle destinationRectangle = new Rectangle(149, 419, 51, 55);
                spriteBatch.Draw(Texture2DStorage.GetBlockSpriteSheet(), destinationRectangle, sourceRectangle, Color.White);
            }


            foreach (LockedDoor doorX in lockedDoor)
            {
                if (doorX != null)
                {
                    doorX.Draw(spriteBatch);
                }
            } 
            foreach (IEnemy enemy in enemies)
            {
                if (enemy != null)
                    enemy.Draw(spriteBatch);


            }
 
            foreach (IItem item in pickUpItems)
            {
                if (item != null)
                    item.Draw(spriteBatch);

            } 
            foreach (INpc npc in npcs)
            {
                npc.Draw(spriteBatch);
            }
        }
    }
}
