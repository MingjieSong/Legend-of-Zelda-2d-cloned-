using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
 
namespace Sprint2
{
    public  static class NumberGenerator
    {
        private static Texture2D numberTexture = Texture2DStorage.GetLetterSpriteSheet();
        private static Dictionary<int, Vector2> numMap = new Dictionary<int, Vector2>(){
            {0, new Vector2 (51,27)},
            {1, new Vector2 (170,27)},
            { 2,new Vector2 (275,27)},
            { 3,new Vector2 (387,27)},
            { 4,new Vector2 (499,27)},
            { 5,new Vector2 (611,27)},
            { 6,new Vector2 (723,27)},
            { 7,new Vector2 (835,27)},
            { 8,new Vector2 (947,27)},
            { 9,new Vector2 (1059,27)}
            };
        private static Vector2 drawLoc;
        private static Vector2 numSize = new Vector2(49, 49);
        private static Vector2 drawSize = new Vector2(25,25);
        private static int num;
        private static int y;


        //largest number 99;
        public static void DrawSingleNumber(SpriteBatch spriteBatch,bool isBar, Vector2 vector, int number) {
            num = number;
            drawLoc = vector;
            if (isBar)
            {
                y = 0;
            }
            else
            {
                y = 600;
            }
            if (num < 10)
            {
                Rectangle sourceRectangle = new Rectangle((int)numMap[num].X, (int)numMap[num].Y, (int)numSize.X, (int)numSize.Y);
                Rectangle destinationRectangle = new Rectangle((int)drawLoc.X, (int)drawLoc.Y+y, (int)drawSize.X, (int)drawSize.Y);
#pragma warning disable CA1062 // Validate arguments of public methods
                spriteBatch.Draw(numberTexture, destinationRectangle, sourceRectangle, Color.White);
#pragma warning restore CA1062 // Validate arguments of public methods
            }
            else {
                int num2 = num % 10;
                int num1 = num / 10;
                Rectangle sourceRectangle1 = new Rectangle((int)numMap[num1].X, (int)numMap[num1].Y, (int)numSize.X, (int)numSize.Y);
                Rectangle destinationRectangle1 = new Rectangle((int)drawLoc.X, (int)drawLoc.Y+y, (int)drawSize.X, (int)drawSize.Y);

                spriteBatch.Draw(numberTexture, destinationRectangle1, sourceRectangle1, Color.White);

                Rectangle sourceRectangle2 = new Rectangle((int)numMap[num2].X, (int)numMap[num2].Y, (int)numSize.X, (int)numSize.Y);
                Rectangle destinationRectangle2 = new Rectangle((int)drawLoc.X+ (int)drawSize.X, (int)drawLoc.Y+y, (int)drawSize.X, (int)drawSize.Y);

                spriteBatch.Draw(numberTexture, destinationRectangle2, sourceRectangle2, Color.White);

            }
        }

    }
}