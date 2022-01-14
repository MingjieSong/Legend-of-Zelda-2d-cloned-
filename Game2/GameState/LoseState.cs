using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint2
{
    public class LoseState : IGameState

    {
       
        //private Texture2D LoseTexture = Texture2DStorage.GetLoseSpriteSheet();
        //private Texture2D cursor = Texture2DStorage.GetItemSpriteSheet();
        private IController loseStateController;
       


        public LoseState(Game1 game) {
          
            loseStateController = new LoseStateController(game);
            Sound.PlayLoseSong();
           

        }
        public void Update() {
            loseStateController.Update();
         
        }
        public void Draw(SpriteBatch spriteBatch) {
            LetterGenerator.drawSentence(spriteBatch, "YOU DIE", new Vector2(300, 200), new Vector2(25, 25));
            LetterGenerator.drawSentence(spriteBatch, "PRESS R TO RESTART", new Vector2(250, 500), new Vector2(18, 18));
            LetterGenerator.drawSentence(spriteBatch, "PRESS ESC TO QUIT", new Vector2(250, 550), new Vector2(18, 18));

        }

    }
}
