using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace Sprint2
{
    public class InventoryDraw


    {
        public void DrawItem(SpriteBatch spriteBatch, List<String> itemList, Dictionary<string, Vector2> itemMap, Texture2D inventoryTexture)
        {
            if (itemList == null)
            {
                throw new ArgumentNullException(nameof(itemList));
            }
            if (spriteBatch == null)
            {
                throw new ArgumentNullException(nameof(spriteBatch));
            }
            if (itemMap == null)
            {
                throw new ArgumentNullException(nameof(itemMap));
            }
            int i = 0;
            foreach (string item in itemList)
            {
                Rectangle sourceRectangle1 = new Rectangle((int)itemMap[item].X, (int)itemMap[item].Y, 13, 27);
                if (i < 4)
                {
                    Rectangle destinationRectangle = new Rectangle(411 + i * 60, 206, 24, 48);
                    spriteBatch.Draw(inventoryTexture, destinationRectangle, sourceRectangle1, Color.White);
                }
                else
                {
                    Rectangle destinationRectangle = new Rectangle(411 + (i - 4) * 60, 206 + 52, 24, 48);
                    spriteBatch.Draw(inventoryTexture, destinationRectangle, sourceRectangle1, Color.White);
                }
                i++;
            }
        }

        public void DrawSelector(SpriteBatch spriteBatch,List<String> itemList, Dictionary<string, Vector2> itemMap, Texture2D inventoryTexture, int currentIndex)
        {
            Rectangle sourceRectangle = new Rectangle(4, 54, 26, 26);
            if(itemList == null)
            {
                throw new ArgumentNullException(nameof(itemList));
            }
            if (spriteBatch == null)
            {
                throw new ArgumentNullException(nameof(spriteBatch));
            }

            if (itemList.Count > 0)
            {
                int i = currentIndex;
                if (i < 4)
                {
                    Rectangle destinationRectangle = new Rectangle(411 + i * 60 - 3, 206 - 3, 30, 54);
                    spriteBatch.Draw(inventoryTexture, destinationRectangle, sourceRectangle, Color.White);
                }
                else
                {
                    Rectangle destinationRectangle = new Rectangle(411 + (i - 4) * 60 - 3, 206 + 52 - 3, 30, 54);
                    spriteBatch.Draw(inventoryTexture, destinationRectangle, sourceRectangle, Color.White);
                }
            }


        }

        //for item selector view box
        public void DrawSelectBox(SpriteBatch spriteBatch, string itemB, Dictionary<string, Vector2> itemMap, Texture2D inventoryTexture)
        {
            if (itemMap == null)
            {
                throw new ArgumentNullException(nameof(itemMap));
            }
            if (spriteBatch == null)
            {
                throw new ArgumentNullException(nameof(spriteBatch));
            }
            if (itemB != null)
            {
                Rectangle sourceRectangle1 = new Rectangle((int)itemMap[itemB].X, (int)itemMap[itemB].Y, 13, 27);
                Rectangle destinationRectangle = new Rectangle(187, 257 - 71, 36, 58);
                spriteBatch.Draw(inventoryTexture, destinationRectangle, sourceRectangle1, Color.White);
            }
        }




        //how many new number objects are layered, and is it updated in playstate, when updating inventoryBar
        public void DrawNumber(SpriteBatch spriteBatch, bool barOnly,int width,int height,int diamondNum,int keyNum,int bombNum)
        {


            NumberGenerator.DrawSingleNumber(spriteBatch, barOnly, new Vector2(width - 483, height - 132), diamondNum);
            NumberGenerator.DrawSingleNumber(spriteBatch, barOnly, new Vector2(width - 482, height - 80), keyNum);
            NumberGenerator.DrawSingleNumber(spriteBatch, barOnly, new Vector2(width - 482, height - 48), bombNum);

        }

        public void DrawItemA(SpriteBatch spriteBatch, Texture2D inventoryTexture, int width, int height,int y)
        {
            if(spriteBatch == null)
            {
                throw new ArgumentNullException(nameof(spriteBatch));
            }
            Rectangle sourceRectangle1 = new Rectangle(66, 53, 11, 25);
            Rectangle destinationRectangle = new Rectangle(width - 330, height - 101 + y, 36, 58);
            spriteBatch.Draw(inventoryTexture, destinationRectangle, sourceRectangle1, Color.White);
        }

        //for final selected item
        public void DrawItemB(SpriteBatch spriteBatch, string itemSelect, Dictionary<string, Vector2> itemMap,int width, int height, Texture2D inventoryTexture,int y)
        {
            if (spriteBatch == null)
            {
                throw new ArgumentNullException(nameof(spriteBatch));
            }
            if (itemMap == null)
            {
                throw new ArgumentNullException(nameof(itemMap));
            }
            if (itemSelect != null)
            {
                Rectangle sourceRectangle1 = new Rectangle((int)itemMap[itemSelect].X, (int)itemMap[itemSelect].Y, 13, 27);
                Rectangle destinationRectangle = new Rectangle(width - 410, height - 101 + y, 36, 58);
                spriteBatch.Draw(inventoryTexture, destinationRectangle, sourceRectangle1, Color.White);
            }

        }

        //maximum 14 hearts
        public void DrawHeart(SpriteBatch spriteBatch, int heartContainerNum, Vector2 heartPos, Texture2D containerTexture,int heartNum,int y, Texture2D heartTexture)
        {
            if (spriteBatch == null)
            {
                throw new ArgumentNullException(nameof(spriteBatch));
            }
           
            //heart container
            for (int i = 0; i < heartContainerNum; i++)
            {
                Rectangle sourceRectangle1 = new Rectangle(0, 0, 320, 320);
                if (i < 7)
                {
                    Rectangle destinationRectangle = new Rectangle((int)heartPos.X + i * 35 - 10, (int)heartPos.Y + y - 10, 40, 40);
                    spriteBatch.Draw(containerTexture, destinationRectangle, sourceRectangle1, Color.White);
                }
                else
                {
                    Rectangle destinationRectangle2 = new Rectangle((int)heartPos.X + (i - 7) * 35 - 10, (int)heartPos.Y + 32 + y - 10, 40, 40);
                    spriteBatch.Draw(containerTexture, destinationRectangle2, sourceRectangle1, Color.White);
                }
            }
            //heart
            for (int i = 0; i < heartNum; i++)
            {
                Rectangle sourceRectangle1 = new Rectangle(244, 199, 7, 8);
                if (i < 7)
                {
                    Rectangle destinationRectangle = new Rectangle((int)heartPos.X + i * 35 - 4, (int)heartPos.Y + y - 2, 27, 23);
                    spriteBatch.Draw(heartTexture, destinationRectangle, sourceRectangle1, Color.White);
                }
                else
                {
                    Rectangle destinationRectangle2 = new Rectangle((int)heartPos.X + (i - 7) * 35 - 4, (int)heartPos.Y + 30 + y, 27, 23);
                    spriteBatch.Draw(heartTexture, destinationRectangle2, sourceRectangle1, Color.White);
                }
            }


        }

        //width=height=19
        public void DrawRoomUp(SpriteBatch spriteBatch, List<IRoom> existingRooms, Dictionary<int, Vector2> upRoomMap, Texture2D inventoryMapTexture)
        {
            if (spriteBatch == null)
            {
                throw new ArgumentNullException(nameof(spriteBatch));
            }
            if (upRoomMap == null)
            {
                throw new ArgumentNullException(nameof(upRoomMap));
            }
            if (existingRooms != null)
            {
                Rectangle sourceRectangle = new Rectangle(31, 11, 19, 19);
                for (int i = 0; i < existingRooms.Count; i++)
                {

                    int desX = (int)upRoomMap[existingRooms[i].roomNumber].X;
                    int desY = (int)upRoomMap[existingRooms[i].roomNumber].Y;
                    Rectangle destinationRectangle = new Rectangle(desX, desY, 19, 19);
                    spriteBatch.Draw(inventoryMapTexture, destinationRectangle, sourceRectangle, Color.White);

                }
            }
        }



        //width=24, height =11
        public void DrawRoomDown(SpriteBatch spriteBatch, List<IRoom> existingRooms, Dictionary<int, Vector2> downRoomMap, Texture2D barMapTexture,int y)
        {
            if (spriteBatch == null)
            {
                throw new ArgumentNullException(nameof(spriteBatch));
            }
            if (downRoomMap == null)
            {
                throw new ArgumentNullException(nameof(downRoomMap));
            }
            if (existingRooms != null)
            {
                Rectangle sourceRectangle = new Rectangle(20, 6, 24, 11);
                for (int i = 0; i < existingRooms.Count; i++)
                {

                    int desX = (int)downRoomMap[existingRooms[i].roomNumber].X;
                    int desY = (int)downRoomMap[existingRooms[i].roomNumber].Y;
                    Rectangle destinationRectangle = new Rectangle(desX, desY + y, 24, 11);
                    spriteBatch.Draw(barMapTexture, destinationRectangle, sourceRectangle, Color.White);

                }
            }
        }

        public void drawEntireMapUp(SpriteBatch spriteBatch, Texture2D inventoryMapTexture)
        {
            if (spriteBatch == null)
            {
                throw new ArgumentNullException(nameof(spriteBatch));
            }
           
            Rectangle sourceRectangle = new Rectangle(31, 11, 128, 155);
            Rectangle destinationRectangle = new Rectangle(425, 380, 133, 152);
            spriteBatch.Draw(inventoryMapTexture, destinationRectangle, sourceRectangle, Color.White);
        }

        public void DrawEntireMapDown(SpriteBatch spriteBatch, Texture2D barMapTexture,int y)
        {
            if (spriteBatch == null)
            {
                throw new ArgumentNullException(nameof(spriteBatch));
            }
           
            Rectangle sourceRectangle = new Rectangle(20, 6, 131, 78);
            Rectangle destinationRectangle = new Rectangle(49, 110 + y, 120, 66);
            spriteBatch.Draw(barMapTexture, destinationRectangle, sourceRectangle, Color.White);
        }
        public void DrawLinkPosDotUpRoom(SpriteBatch spriteBatch, List<IRoom> existingRooms, Dictionary<int, Vector2> upRoomMap, int currentRoom, ISprite linkPosDotSprite,int diff)
        {
            if (linkPosDotSprite == null)
            {
                throw new ArgumentNullException(nameof(linkPosDotSprite));
            }
            if (upRoomMap == null)
            {
                throw new ArgumentNullException(nameof(upRoomMap));
            }
            if (existingRooms != null)
            {
                int desX = (int)upRoomMap[currentRoom].X;
                int desY = (int)upRoomMap[currentRoom].Y;
                linkPosDotSprite.Draw(spriteBatch, new Vector2((int)(desX + 7), (int)(desY + 5 - diff))); //current room
            }
        }
        public void DrawLinkPosDotDownRoom(SpriteBatch spriteBatch, List<IRoom> existingRooms, Dictionary<int, Vector2> downRoomMap, int currentRoom, ISprite linkPosDotSprite, int diff,int y)
        {
            if (linkPosDotSprite == null)
            {
                throw new ArgumentNullException(nameof(linkPosDotSprite));
            }
            if (downRoomMap == null)
            {
                throw new ArgumentNullException(nameof(downRoomMap));
            }
            if (existingRooms != null)
            {
                int desX = (int)downRoomMap[currentRoom].X;
                int desY = (int)downRoomMap[currentRoom].Y;
                linkPosDotSprite.Draw(spriteBatch, new Vector2((int)(desX + 10), (int)(desY + 3 + y - diff))); //current room
            }
        }
    }
}
