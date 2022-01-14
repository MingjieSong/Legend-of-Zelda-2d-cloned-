using Microsoft.Xna.Framework.Graphics; 
using Microsoft.Xna.Framework;

 
namespace Sprint2
{
    public class PlayState : IGameState
    {
         

        private Texture2D inventoryTexture = Texture2DStorage.GetInventorySpriteSheet();
        private   int width = 800;
        private  int height = 871;
#pragma warning disable CA1051 // Do not declare visible instance fields
        public IPlayer player;
#pragma warning restore CA1051 // Do not declare visible instance fields
#pragma warning disable CA1051 // Do not declare visible instance fields
        public ILevel level;
#pragma warning restore CA1051 // Do not declare visible instance fields

#pragma warning disable CA1051 // Do not declare visible instance fields
        public ICollisionDetection linkDetection;
#pragma warning restore CA1051 // Do not declare visible instance fields
#pragma warning disable CA1051 // Do not declare visible instance fields
        public ICollisionDetection enemyDetection;
#pragma warning restore CA1051 // Do not declare visible instance fields


        public IInventory inventoryBar { get; set; }

        
        private IController playStateController;
        //responsible for switching between playstate to win/lose state
        private IController inventoryController;

       
        public PlayState(Game1 game)
        { 
            player = new Link(new Vector2(648, 577)); 
            level = new Level1(player); 
            linkDetection = new LinkCollisionDetection(level, player, inventoryBar);
            enemyDetection = new EnemyCollisionDetection(level); 
            Sound.PlayRoom();
            playStateController = new PlayStateController(game, this);
            inventoryController = new InventoryController(game, this);
            //initialize the inventory here for the first time 

            inventoryBar = new Inventory(this);

        }
        public void Draw(SpriteBatch spriteBatch)
        {
            
             
            Rectangle sourceRectangle1 = new Rectangle(0, height - 200, width, Game1.WindowHeight / 4);          
            Rectangle destinationRectangle = new Rectangle(0, 0, Game1.WindowWidth, Game1.WindowHeight/4);

#pragma warning disable CA1062 // Validate arguments of public methods
            spriteBatch.Draw(inventoryTexture, destinationRectangle, sourceRectangle1, Color.White);
#pragma warning restore CA1062 // Validate arguments of public methods

            //only draw the bar area
            inventoryBar.barOnly = true;
            inventoryBar.Draw(spriteBatch); 
            level.Draw(spriteBatch);
            player.Draw(spriteBatch);
           
                
            
        }

        public void Update()
        {
             
            playStateController.Update();
            inventoryController.Update();
            player.Update();
            linkDetection.Update();
            //stop update when using clock in order to avoid detection with wall and block, result in changing position
            enemyDetection.Update();
            level.Update();
            linkDetection = new LinkCollisionDetection(level, player, inventoryBar);
             if (Level1.roomUpdate)
             {
                enemyDetection = new EnemyCollisionDetection(level);
             }

            inventoryBar.Update();
           
            if (!LinkCollisionDetection.BlueRing)
            {
                linkDetection = new LinkCollisionDetection(level, player, inventoryBar);
            }
        }

      
        
    }
}
