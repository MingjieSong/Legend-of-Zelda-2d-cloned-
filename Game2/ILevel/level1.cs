using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace Sprint2
{
    public class Level1: ILevel
    {
        
        public IRoom room { get; set; }
        private RoomLoader roomLoader;
        private ICamera camera;
        private bool load = false;
         private int roomNum; 
        private String direction;
        public int currentRoomNum { get; set; }

#pragma warning disable CA2227 // Collection properties should be read only
        public List<IRoom> existingRooms { get; set; } = new List<IRoom>();
#pragma warning restore CA2227 // Collection properties should be read only
                              //new add
        private bool visit = false;
        private bool undergoundSwitch = false;
        private int index = 0;
        private IPlayer link;
        public static bool roomUpdate = true;
        private int clockTimer = 0;
        public Level1(IPlayer player)
        {
            link = player;
            roomLoader = new RoomLoader("room1.xml");
            room = new Room(roomLoader);
            existingRooms.Add(room);
            camera = new Camera();
            currentRoomNum = room.roomNumber;


        }

        //switch room and camera 
        public void switchRoom(string direction)
        {
            if (direction == "1")
            {
                int roomNum = 1;
                if (roomNum != 0)
                {
                    camera = new Camera();
                    load = true;
                    room = new Room();
                    Link.posX = 648;
                    Link.posY = 577; 
                }  
                this.roomNum = 1;            
                for (int i = 0; i < existingRooms.Count; i++)
                {
                    if (existingRooms[i].roomNumber == roomNum)
                    {
                        visit = true;
                        index = i;
                    }
                }
            }
            else {  
            int roomNum = getNextRoomNum(direction);
            if (roomNum != 0)
            {
                camera.direction = direction;
                Camera.SwitchRoom = true;
                load = true;

                room = new Room();
                Link.posX = 3000;
                Link.posY = 3000; //cannot be seen when room switching 
            }
            this.direction = direction;
            this.roomNum = roomNum;
            //add
            for (int i = 0; i < existingRooms.Count; i++)
            {
                if (existingRooms[i].roomNumber == roomNum)
                {
                    visit = true;
                    index = i;
                }
            }
           } 

        }



        public void switchUnderground(Vector2 destRoomPos, string direction)
        {
            
            Camera.sourceLocX = (int)destRoomPos.X;
            Camera.sourceLocY = (int)destRoomPos.Y;
             roomNum = getNextRoomNum(direction);
            if (roomNum != 0)
            {
                load = true;
                 undergoundSwitch =true;
                if (roomNum == 13)
                {
                    Link.posX = 600;
                    Link.posY = 500;
                    
                    link.ChangeToLeft();
                }else if (roomNum == 15)
                { 
                    Link.posX = 170;
                    Link.posY = 280;
                    link.ChangeToDown();
                }
            }
            
            for (int i = 0; i < existingRooms.Count; i++)
            {
                if (existingRooms[i].roomNumber == roomNum)
                {
                    visit = true;
                    index = i;
                }
            }
            if (roomNum == 15)
            {
                Camera.width = 257;
                Camera.height = 160;
                
            }
            else
            {
                Camera.width = 257;
                Camera.height = 178;
            }
        }
             

        public int getNextRoomNum(string direction)
        {
            int num = 0 ;

            switch (direction)
            {
                case "Left":
                    num = room.leftRoomNum;
                    break;
                case "Right":
                    num = room.rightRoomNum;
                    break;
                case "Up":
                    num = room.upRoomNum;
                    break;
                case "Down":
                    num = room.downRoomNum;
                    break;

                default:
#pragma warning disable CA1303 // Do not pass literals as localized parameters
                    Console.WriteLine("error: no such situation");
#pragma warning restore CA1303 // Do not pass literals as localized parameters
                    break;
            }
            return num;
        }

        private void SetLinkPosInNewRoom(String direction)
        {
            if (!undergoundSwitch)
            {
                switch (direction)
                {
                    case "Up":
                        Link.posX = (int)(room.roomPos.X + Game1.WindowWidth * (0.30));
                        Link.posY = (int)(room.roomPos.Y + 600 * (0.5));
                        break;

                    case "Down":
                        Link.posX = (int)(room.roomPos.X + Game1.WindowWidth * (0.30));
                        Link.posY = (int)(room.roomPos.Y);
                        break;

                    case "Left":
                        Link.posX = (int)(room.roomPos.X + Game1.WindowWidth * (0.70));
                        Link.posY = (int)(room.roomPos.Y + 600 * (0.24));
                        break;

                    case "Right":
                        Link.posX = (int)(room.roomPos.X);
                        Link.posY = (int)(room.roomPos.Y + 600 * (0.24));
                        break;

                }
            }
            undergoundSwitch = false;

        }
        public void Update()
        {
            if (load && !Camera.SwitchRoom  )
            {
                if (visit)
                {
                    //already exist, no need to create a new room 
                    load = false;
                    room = existingRooms[index];
                    currentRoomNum = existingRooms[index].roomNumber;
                    SetLinkPosInNewRoom(direction);
                    visit = false;
                }
                else  
                {
                    load = false;
                    roomLoader = new RoomLoader("room" + roomNum + ".xml");
                    room = new Room(roomLoader);
                    currentRoomNum = roomNum;
                    SetLinkPosInNewRoom(direction);
                    existingRooms.Add(room);

                }
            }
            
            camera.Update();
            room.Update();

            //when using clock, update frozen time
            if (!roomUpdate)
            {
                clockTimer++;
                if (clockTimer >= 500)
                {
                    roomUpdate = true;
                    clockTimer = 0;

                }
            }
            
        }

        public void Draw(SpriteBatch spriteBatch)
        {
          
            camera.Draw(spriteBatch);
            room.Draw(spriteBatch);
             
        }
    }
}

