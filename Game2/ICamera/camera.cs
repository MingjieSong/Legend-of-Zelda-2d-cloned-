using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint2
{
    public class Camera : ICamera
    {
        private Texture2D Texture = Texture2DStorage.GetDungeonSpriteSheet();
        public string direction { get; set; }
        public static bool SwitchRoom { get; set; }
        
        public static int width = 257;
        public static int height = 177;
        public  static int sourceLocX = 515;
        public static int sourceLocY = 177;
        //room1:(515,177) room10:(1,532) room11:(772,353) room12:(1030,530) room13:(0,707) room14:(515,885) room15:(0,0)

        private int delay = 0;


        public Camera()
        {
            sourceLocX = 515;
            sourceLocY = 177;
            direction = "";
        }

        public void Update()
        {
            if (direction.Length == 0)
            {
                // do nothing
            }
            else if (direction.Equals("Up", System.StringComparison.Ordinal))
            {
                if (SwitchRoom)
                {
                    sourceLocY--;
                    delay++;
                    if (delay >= 177)
                    {
                        SwitchRoom = false;

                    }

                }
                else
                {
                    delay = 0;
                    direction = "";
                }
            }
            else if (direction.Equals("Down", System.StringComparison.Ordinal))
            {

                if (SwitchRoom)
                {
                    sourceLocY++;
                    delay++;
                    if (delay >= 177)
                    {
                        SwitchRoom = false;
                    }

                }
                else
                {
                    delay = 0;
                    direction = "";
                }
            }
            else if (direction.Equals("Left", System.StringComparison.Ordinal))
            {
                if (SwitchRoom)
                {
                    sourceLocX--;
                    delay++;
                    if (delay >= 257)
                    {
                        SwitchRoom = false;
                    }

                }
                else
                {
                    delay = 0;
                    direction = "";
                }
            }
            else if (direction.Equals("Right", System.StringComparison.Ordinal))
            {
                if (SwitchRoom)
                {
                    sourceLocX++;
                    delay++;
                    if (delay >= 257)
                    {
                        SwitchRoom = false;
                    }

                }
                else
                {
                    delay = 0;
                    direction = "";
                }

            }

        }


        public void Draw(SpriteBatch spriteBatch)
        {
            if (spriteBatch == null)
            {
                throw new System.ArgumentNullException(nameof(spriteBatch));
            }
            if (Texture != null)
            {
                Rectangle sourceRectangle = new Rectangle(sourceLocX, sourceLocY, width, height);
                Rectangle destinationRectangle = new Rectangle(0, 200, 800, 600);
                //0,0,Game1.WindowWidth, Game1.WindowHeight original setting

                spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);

            }
        }
    }
}