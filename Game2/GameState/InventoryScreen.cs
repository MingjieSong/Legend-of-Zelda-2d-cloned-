using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
   public class InventoryScreen : IGameState
    {
        private Texture2D backTexture = Texture2DStorage.GetInventorySpriteSheet();
      
        private IController inventoryStateController;
        

        public IInventory inventory { get; set; }
        public string name { get; set; }
#pragma warning disable IDE0044 // Add readonly modifier
#pragma warning disable IDE0052 // Remove unread private members
        private Game1 game;
#pragma warning restore IDE0052 // Remove unread private members
#pragma warning restore IDE0044 // Add readonly modifier
        private PlayState play;

        public InventoryScreen(Game1 game, PlayState play) {
            this.game = game;
#pragma warning disable CA1062 // Validate arguments of public methods
            this.play = play;
            inventory = play.inventoryBar;
#pragma warning restore CA1062 // Validate arguments of public methods
            inventoryStateController = new InventoryScreenController(game, play);
        }
        public void Update() {
           // inventoryStateController = new InventoryStateController(game, this);
            inventoryStateController.Update();
            inventory.Update();
            
        }
        public void Draw(SpriteBatch spriteBatch) {

            //draw background
            Rectangle sourceRectangle1 = new Rectangle(0, 71, 800, 800);
            Rectangle destinationRectangle = new Rectangle(0, 0, Game1.WindowWidth, Game1.WindowHeight);
#pragma warning disable CA1062 // Validate arguments of public methods
            spriteBatch.Draw(backTexture, destinationRectangle, sourceRectangle1, Color.White);
#pragma warning restore CA1062 // Validate arguments of public methods

            inventory.barOnly = false;
            inventory.Draw(spriteBatch);
            

        }





    }
}
