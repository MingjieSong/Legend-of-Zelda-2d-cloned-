using System;
using System.Collections.Generic; 
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;



namespace Sprint2
{
    public class Inventory : IInventory
    {

        protected Texture2D inventoryTexture = Texture2DStorage.GetNumberSpriteSheet();
        protected Texture2D barMapTexture = Texture2DStorage.GetDownMapSpriteSheet();
        protected Texture2D inventoryMapTexture = Texture2DStorage.GetUpMapSpriteSheet();
        protected Texture2D containerTexture = Texture2DStorage.GeHeartContainerSpriteSheet();
        protected Texture2D heartTexture = Texture2DStorage.GetLinkSpriteSheet();
        protected InventoryDraw inventoryDraw = new InventoryDraw();

        protected int diff = 0;
        public int heartNum { get; set; } = 12;
        public int heartContainerNum { get; set; } = 12;
        public int diamondNum { get; set; } = 10;
        public int keyNum { get; set; } = 0;
        public int bombNum { get; set; } = 0;
        public int triPieceNum { get; set; } = 0;

        public string itemA { get; set; } = "sword";
        public string itemB { get; set; }

        // being initialized as empty 
        //"bomb","boomerang","bow","candle","candle"
#pragma warning disable CA2227 // Collection properties should be read only
        public List<String> itemList { get; set; } = new List<String>();
#pragma warning restore CA2227 // Collection properties should be read only
        public int currentIndex { get; set; } = 0;
        public string itemSelect { get; set; }


        //the width and height for the bar rectangle 
        protected static int width = 800;
        protected static int height = 200;
        protected Vector2 heartPos = new Vector2(width - 240, height - 94);
        public bool barOnly { get; set; } = true; 
        protected int y = 0;
        protected ISprite mapSprite = new StaticSprite(Texture2DStorage.GetItemSpriteSheet(), 244,80,8,16);
        protected ISprite compassSprite = new StaticSprite(Texture2DStorage.GetItemSpriteSheet(), 82, 42, 11, 12);
        //assume triforce are being set in room 14,15,16
        protected ISprite triforceDotSprite1 = new ShiningDotSprite(Texture2DStorage.GetItemSpriteSheet(), 343, 123, 10, 10);
        protected ISprite triforceDotSprite2 = new ShiningDotSprite(Texture2DStorage.GetItemSpriteSheet(), 343, 123, 10, 10);
        protected ISprite triforceDotSprite3 = new ShiningDotSprite(Texture2DStorage.GetItemSpriteSheet(), 343, 123, 10, 10);
        protected ISprite linkPosDotSprite = new ShiningDotSprite(Texture2DStorage.GetNumberSpriteSheet(), 34, 35, 7, 5);
        public bool showMap { get; set; } = false;
        public bool showCompass { get; set; } = false;


        //the coordination for each item in the item selet bar
        protected Dictionary<string, Vector2> itemMap = new Dictionary<string, Vector2>(){
            {"sword", new Vector2 (66,53)},  //12 27
            { "bomb", new Vector2 (148,53)},
            { "bow",new Vector2(197,53)},
            { "boomerang",new Vector2(114,54)},
            { "candle",new Vector2(216,53)}
            };

        //room map on the top position of inventory sprite sheet 
        //int represents room number
        //width=height=19
        protected Dictionary<int, Vector2> upRoomMap = new Dictionary<int, Vector2>()
        {
            { 1, new Vector2 (478,407)},
            { 2, new Vector2 (478,380)},
            { 3,new Vector2(452,380)},
            { 4,new Vector2(425,433)},
            { 5,new Vector2(452,433)},
            { 6, new Vector2 (452,460)},
            { 7, new Vector2 (532,433)},
            { 8,new Vector2(478,460)},
            { 9,new Vector2(505,460)},
            { 10,new Vector2(425,460)},
            { 11, new Vector2 (505,433)},
            { 12, new Vector2 (532,460)},
            { 13,new Vector2(425,487)},
            { 14,new Vector2(478,513)},
            { 15,new Vector2(425,380)},
            { 16, new Vector2 (532,407)},
            { 17, new Vector2 (478,433)},
            { 18,new Vector2(478,487)},
            { 19,new Vector2(505,513)} 
         } ;
     


        //room map on the bottom position of inventory sprite sheet 
        //int represents room number
        //width=22, height =10
        protected Dictionary<int, Vector2> downRoomMap = new Dictionary<int, Vector2>()
        {
            { 1, new Vector2 (102,123)},
            { 2, new Vector2 (102,110)},
            { 3,new Vector2(75,110)},
            { 4,new Vector2(49,136)},
            { 5,new Vector2(75,136)},
            { 6, new Vector2 (75,150)},
            { 7, new Vector2 (155,136)},
            { 8,new Vector2(102,150)},
            { 9,new Vector2(129,150)},
            { 10,new Vector2(49,150)},
            { 11, new Vector2 (129,136)},
            { 12, new Vector2 (155,150)},
            { 13,new Vector2(49,163)},
            { 14,new Vector2(102,176)},
            { 15,new Vector2(49,110)},
            { 16, new Vector2 (155,123)},
            { 17, new Vector2 (102,136)},
            { 18,new Vector2(102,163)},
            { 19,new Vector2(129,176)}
        };

        protected List<IRoom> existingRooms;
        protected PlayState play;
        protected int currentRoom;

        public Inventory() { 
        
        }
        public Inventory(PlayState play)
        {
            this.play = play;

        }

        public void Update()
        {
            //only needed if we want to implement dot blicking in the map
            if (barOnly)
            {
                y = 0;
            }
            else
            {
                y = 600;
            }
            if (itemList.Count > 0)
            {
                itemB = itemList[currentIndex];
            }
            existingRooms = play.level.existingRooms;
            currentRoom = play.level.currentRoomNum;
            if (showMap && showCompass)
            {
                //need to update compass
                triforceDotSprite1.Update();
                triforceDotSprite2.Update();
                triforceDotSprite3.Update();
            }
            linkPosDotSprite.Update();
        }
        public void Draw(SpriteBatch spriteBatch)
        {

            if (spriteBatch == null)
            {
                throw new ArgumentNullException(nameof(spriteBatch));
            }

            //drawing in the bar area
            inventoryDraw.DrawNumber(spriteBatch,  barOnly, width,  height,  diamondNum,  keyNum,  bombNum);
            inventoryDraw.DrawItemA(spriteBatch, inventoryTexture, width,  height,  y);
            inventoryDraw.DrawItemB(spriteBatch, itemSelect, itemMap, width, height,inventoryTexture,  y);
            inventoryDraw.DrawHeart(spriteBatch,  heartContainerNum,  heartPos, containerTexture,  heartNum,  y, heartTexture);
            if (!showMap)
            {
                inventoryDraw.DrawRoomDown(spriteBatch,existingRooms,downRoomMap, barMapTexture, y);
            }
            else
            {
                diff = 2;
                inventoryDraw.DrawEntireMapDown(spriteBatch, barMapTexture,  y);
                if (showCompass)
                {
                    //draw triforce dot
                    triforceDotSprite1.Draw(spriteBatch, new Vector2(134, 170 + y));//in room14
                    triforceDotSprite2.Draw(spriteBatch, new Vector2(54, 110 + y)); //in room15
                    triforceDotSprite3.Draw(spriteBatch, new Vector2(157, 120 + y)); //in room16
                }

            }

            if (!barOnly)
            {
                inventoryDraw.DrawItem(spriteBatch, itemList, itemMap, inventoryTexture);
                inventoryDraw.DrawSelectBox(spriteBatch,  itemB,  itemMap,  inventoryTexture);
                inventoryDraw.DrawSelector(spriteBatch,  itemList,  itemMap, inventoryTexture,  currentIndex);
                if (showCompass)
                {
                    //draw compass
                    compassSprite.Draw(spriteBatch, new Vector2(120, 520));
                }
                if (!showMap)
                {
                    inventoryDraw.DrawRoomUp(spriteBatch,  existingRooms, upRoomMap, inventoryMapTexture);
                }
                else
                {
                    diff = 2;
                    inventoryDraw.drawEntireMapUp(spriteBatch, inventoryMapTexture);
                    mapSprite.Draw(spriteBatch, new Vector2(120, 400));
                    if (showCompass)
                    {
                        //draw triforce dot
                        triforceDotSprite1.Draw(spriteBatch, new Vector2(483, 518));//in room14
                        triforceDotSprite2.Draw(spriteBatch, new Vector2(430, 385)); //in room15
                        triforceDotSprite3.Draw(spriteBatch, new Vector2(537, 412)); //in room16

                    }
                }

            }

            inventoryDraw.DrawLinkPosDotDownRoom(spriteBatch, existingRooms,  downRoomMap,currentRoom,  linkPosDotSprite, diff,  y);
            inventoryDraw.DrawLinkPosDotUpRoom(spriteBatch, existingRooms,  upRoomMap, currentRoom,  linkPosDotSprite,  diff);




        }


       
    }
    }
 