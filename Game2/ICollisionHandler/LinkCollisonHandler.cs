using Microsoft.Xna.Framework;
using System;
 

namespace Sprint2
{
    class LinkCollisionHandler 
    {

        private IPlayer link;
        private IRoom room;
        private ILevel level;
        private IInventory inventory;

        
        
      public LinkCollisionHandler(IPlayer link, ILevel level, IInventory inventory)
        {
            this.link = link;
            this.room = level.room;
            this.level = level;
            this.inventory = inventory;
            
        }

        
        public void HandleLinkBlockCollsion(string direction)
        {
            
            switch (direction)
            {
                case "Left":
                    Link.posX -=2;
                    break;
                case "Right":
                    Link.posX +=2;
                    break;
                case "Up":
                    Link.posY +=2;

                    break;
                case "Down":
                    Link.posY -=2;
                    break;

                default:
                    Console.WriteLine("error: no such situation");
                    break;
            }
        }


        public void HandleLinkStairCollsion(Vector2 destRoomPos, String direction)
        {

            //switch room to destRoomPos
            
            switch (direction)
            {
                case "Left":
                    direction = "Right";
                    break;
                case "Right":
                    direction = "Left";
                    break;
                
            }
            level.switchUnderground(destRoomPos, direction);

        }

        public void HandleLinkDoorCollsion(string direction)
        {

            level.switchRoom(direction);
                 
            
        }
        public void HandleLinkCloudCollision(string direction)
        {
            if (direction == "Left")
            {
                direction = "Right";

            }
            else if (direction == "Right")
            {
                direction = "Left";
            }
            StayPosition(direction);
        }
        public void HandleLinkEnemyCollsion(string direction, int i)
        {
            Link.damageTimer = 0; 
            //link get damaged and being pushed to opposite direction
            if ( !(link.state is LinkWinningState))
            {
                Sound.PlayLinkDemage();
                
                    inventory.heartNum--;
                    link.GetDamaged();
                    Link.ifDamage = true;


                    if (room.enemies[i] is GreenDragon || room.enemies[i] is Dragon)
                    {
                        inventory.heartContainerNum--;
                    }
                    if(room.enemies[i] is WallMaster)
                    {
                    level.switchRoom("1");
                     }
                
            } 
            switch (direction)
            {
                case "Left":
                    Link.posX = Link.posX -30;
                    break;
                case "Right":
                    Link.posX= Link.posX + 30;
                    break;
                case "Up":
                    Link.posY =Link.posY+30;

                    break;
                case "Down":
                    Link.posY = Link.posY - 30;
                    break;

                default:
#pragma warning disable CA1303 // Do not pass literals as localized parameters
                    Console.WriteLine("error: no such situation");
#pragma warning restore CA1303 // Do not pass literals as localized parameters
                    break;
            }

        }

        public void HandleLinkProjectileCollsion()
        {
            //link just damage
            Link.damageTimer = 0; 
            if ( !(link.state is LinkWinningState))
            {
                Sound.PlayLinkDemage();
                inventory.heartNum--;
                link.GetDamaged();
                Link.ifDamage = true;
            }
          
           
        }

       public void HandleLinkWeaponEnemyCollsion(int enemyNum)
        {
            if (room.enemies[enemyNum] != null) { 
                //enemy damage 
                Sound.PlayLinkDemage(); 
               room.enemies[enemyNum].GetDamage(); 
            }
      
    }
        
 
        public void HandleLinkNpcCollsion(string direction,int npcNum)
        {
            
             if(direction == "Right") 
            {
                direction = "Left";
            }else if(direction == "Left"){
                direction = "Right";
            }
            StayPosition(direction);
            Sound.PlayItemCollision(); 
            room.npcs[npcNum].Talk();
           
            
        }

       public void HandleLinkBoxCollision(int itemNum, string direction)
        {
             
            if(direction == "Up")
            {
                if (room.pickUpItems[itemNum].PosY > room.roomPos.Y)
                {
                    room.pickUpItems[itemNum].PosY--;
                }
            }else if(direction == "Down")
            {
                if (room.pickUpItems[itemNum].PosY < room.roomPos.Y + (int)(600 * 0.55))
                {
                    room.pickUpItems[itemNum].PosY++;
                }
            }else if (direction =="Left")
            {
                if (room.pickUpItems[itemNum].PosX < room.roomPos.X + (int)(800 * 0.68))
                {
                    room.pickUpItems[itemNum].PosX++;
                }
            }else if (direction == "Right")
            {
                if (room.pickUpItems[itemNum].PosX > room.roomPos.X )
                {
                    room.pickUpItems[itemNum].PosX--;
                }
            }

        }

        public void HandleLinkItemCollsion(int itemNum)
        { 
            if (ItemManager(itemNum))
            {
                Sound.PlayItemCollision();
                room.setItemToNull(itemNum);
            }
            
            
        }

        public void HandleBombWallCollsion(int itemNum)
        {
              if(room.roomNumber==8 || room.roomNumber == 9)
            {
                Room.DoorOpen.Add(8);
                Room.DoorOpen.Add(9);

            }
            else if(room.roomNumber == 7 || room.roomNumber == 11)
            {
                Room.DoorOpen.Add(7);
                Room.DoorOpen.Add(11);

            }
            room.setItemToNull(itemNum);

        }

        public void HandleLinkWallHoleCollision(int itemNum, string direction)
        {
            if (direction == null)
            {
                throw new ArgumentNullException(nameof(direction));
            }
           
            if (direction == "Left")
                {
                    direction = "Right";

                }
                else if (direction == "Right")
                {
                    direction = "Left";
                }
                StayPosition(direction);
          

        }

        public void HandleLinkLockedDoorCollision(int itemNum, String direction)
        {
            if (inventory.keyNum > 0)
            {
                room.setItemToNull(itemNum);
                inventory.keyNum--;
            }
            else
            {
               if (direction == "Left")
                {
                    direction = "Right";
                    
                }
                else if(direction=="Right")
                {
                    direction = "Left";
                }
                StayPosition(direction);
            }

        }

        public void StayPosition(string direction)
        {
            
            switch(direction)
              
            {
                case "Left":
                    Link.posX+=2;
                    break;
                case "Right":
                    Link.posX-=2;
                    break;
                case "Up":
                    Link.posY+=2;
                  
                    break;
                case "Down":
                    Link.posY-=2;
                    break;
                
                default:
#pragma warning disable CA1303 // Do not pass literals as localized parameters
                    Console.WriteLine("error: no such situation");
#pragma warning restore CA1303 // Do not pass literals as localized parameters
                    break;
            }
        }

        public void LinkBlueCandleCloudHandler(int itemNum)
        {
            room.setItemToNull(itemNum);
        }
        public bool ItemManager(int itemNum)
        {
            bool successPickUp = true;

            if (room.pickUpItems[itemNum] is YellowDiamond)
            {
                inventory.diamondNum++;
                //max life 12
            }
            else if (room.pickUpItems[itemNum] is BluePotion)
            {
                if (inventory.heartContainerNum == 12)
                {
                    successPickUp = false;
                }
                else{ 
                inventory.heartContainerNum++;
                }
            }
            else if (room.pickUpItems[itemNum] is Cloud)
            {
                successPickUp = false;
            }
            else if (room.pickUpItems[itemNum] is Heart)
            {
                if (inventory.heartNum < inventory.heartContainerNum)
                {
                    inventory.heartNum++;
                }
                else
                {
                    successPickUp = false;
                }
            }
            else if (room.pickUpItems[itemNum] is staticBomb)
            {
                if (!inventory.itemList.Contains("bomb"))
                {
                    inventory.itemList.Add("bomb");
                }
                inventory.bombNum++;
            }
            else if (room.pickUpItems[itemNum] is Key)
            {
                inventory.keyNum++;
            }
            else if (room.pickUpItems[itemNum] is TriforcePiece)
            {
                inventory.triPieceNum++;
                link.Win();
            }
            else if (room.pickUpItems[itemNum] is staticBow)
            {
                if (!inventory.itemList.Contains("bow") && inventory.diamondNum >= 5)
                {
                    inventory.itemList.Add("bow");
                    inventory.diamondNum -= 5;
                }
                else
                {
                    successPickUp = false;
                }
            }
            else if (room.pickUpItems[itemNum] is staticCandle)
            {
                if (!inventory.itemList.Contains("candle") && inventory.diamondNum >= 10)
                {
                    inventory.itemList.Add("candle");
                    inventory.diamondNum -= 10;
                }
                else
                {
                    successPickUp = false;
                }
            }
            else if (room.pickUpItems[itemNum] is staticWoodenBoomerang)
            {
                if (!inventory.itemList.Contains("boomerang") && inventory.diamondNum >= 5)
                {
                    inventory.itemList.Add("boomerang");
                    inventory.diamondNum -= 5;
                }
                else
                {
                    successPickUp = false;
                }
            }
            else if (room.pickUpItems[itemNum] is Map)
            {
                inventory.showMap = true;
            }
            else if (room.pickUpItems[itemNum] is Compass)
            {
                inventory.showCompass = true;
            }
            else if (room.pickUpItems[itemNum] is Clock)
            {
                //room need to stop update
                Level1.roomUpdate = false;
            }else if(room.pickUpItems[itemNum] is BlueRing)
            {
                LinkCollisionDetection.BlueRing = true;
            }
 
            //if items  fairy? /heartContainer?(delete)
            return successPickUp;
        }




    }
}
