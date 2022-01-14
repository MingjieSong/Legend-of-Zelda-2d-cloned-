using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Diagnostics;

namespace Sprint2
{

    public class Game1 : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch; 

        
        public IGameState gameState { get; set; }
        
        public static int WindowWidth = 800;
        public static int WindowHeight = 800; 
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            //graphics.IsFullScreen = true;
            graphics.PreferredBackBufferWidth = WindowWidth;
            graphics.PreferredBackBufferHeight = WindowHeight;
            graphics.ApplyChanges();
            
        }

        protected override void Initialize()
        {
 
            IsMouseVisible = true; 
            base.Initialize(); 
        }

        protected override void LoadContent()
        {
            Texture2DStorage.LoadAllTextures(Content);
            spriteBatch = new SpriteBatch(GraphicsDevice); 
            gameState = new StartState(this);
            Sound.LoadBGM(Content);
            Sound.PlayMainSong();

        }

        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        protected override void Update(GameTime gameTime)
        {  
                gameState.Update(); 
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            spriteBatch.Begin();
            
            gameState.Draw(spriteBatch); 
            spriteBatch.End();
           
            base.Draw(gameTime);
        }
    }
}
