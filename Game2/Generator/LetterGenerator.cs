using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
 
namespace Sprint2
{
    public static class LetterGenerator
    {
        private static Texture2D letterTexture = Texture2DStorage.GetLetterSpriteSheet();
        private static int width = 49;
        private static int height = 49;
        private static Dictionary<char, Vector2> letterMap = new Dictionary<char, Vector2>(){
            {'A', new Vector2 (1171,27) }, {'B', new Vector2 (1283,27)},
            { 'C',new Vector2 (1395,27)},
            { 'D',new Vector2 (1507,27)},
            { 'E',new Vector2 (1619,27)},
            { 'F',new Vector2 (1731,27)},
            { 'G',new Vector2 (51,139)},
            { 'H',new Vector2 (163,139)},
            { 'I',new Vector2 (289,139)},
            { 'J',new Vector2 (387,139)},
            { 'K',new Vector2 (499,139)},
            { 'L',new Vector2 (618,139)},
            { 'M',new Vector2 (723,139)},
            { 'N',new Vector2 (835,139)},
            { 'O',new Vector2 (947,139)},
            { 'P',new Vector2 (1059,139)},
            { 'Q',new Vector2 (1171,139)},
            { 'R',new Vector2 (1283,139)},
            { 'S',new Vector2 (1395,139)},
            { 'T',new Vector2 (1514,139)},
            { 'U',new Vector2 (1619,139)},
            { 'V',new Vector2 (1731,139)},
            { 'W',new Vector2 (51,251)},
            { 'X',new Vector2 (163,251)},
            { 'Y',new Vector2 (282,251)},
            { 'Z',new Vector2 (387,251)},
             { ' ',new Vector2 (1395,251)}

            };
       
 
        //can only draw sentence in one line
        //fontSize: the size you want it to appear on the screen  (width,height)
        public static void drawSentence(SpriteBatch spriteBatch,String sentence, Vector2 startLoc, Vector2 fontSize)
        {
            int i = 0;
#pragma warning disable CA1062 // Validate arguments of public methods
            foreach (char c in sentence)
#pragma warning restore CA1062 // Validate arguments of public methods
            { 
                Rectangle sourceRectangle = new Rectangle((int)letterMap[c].X, (int)letterMap[c].Y,width, height ); 
                Rectangle destinationRectangle = new Rectangle((int)(startLoc.X+fontSize.X*i), (int)startLoc.Y , (int)fontSize.X, (int)fontSize.Y);
#pragma warning disable CA1062 // Validate arguments of public methods
                spriteBatch.Draw(letterTexture, destinationRectangle, sourceRectangle, Color.White);
#pragma warning restore CA1062 // Validate arguments of public methods
                i++;
            }

        }
        
       
        

    }
}