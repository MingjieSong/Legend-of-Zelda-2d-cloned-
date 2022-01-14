using System;
 
namespace Sprint2 
{
    public class Gear2: ICommand
    {
        
        private PlayState play;
        private int itemNum;
        private IInventory inventory;
        public Gear2(PlayState play )
        {
            this.play = play;
#pragma warning disable CA1062 // Validate arguments of public methods
            this.inventory = play.inventoryBar;
#pragma warning restore CA1062 // Validate arguments of public methods
            itemNum =getItemNum(play.inventoryBar.itemSelect);
        }
        public void Execute()
        {

            if( (itemNum!=2 && itemNum!=9)||( inventory.bombNum > 0)) { 

            /* direction should have value 0,1,2,3 corresponding to up, down, left, right*/
            int direction = play.player.GetDirection();
                switch (direction)
                {
                    case 0:
                        play.player.SetLinkWithItemUpState(itemNum);

                        break;
                    case 1:
                        play.player.SetLinkWithItemDownState(itemNum);

                        break;
                    case 2:
                        play.player.SetLinkWithItemLeftState(itemNum);

                        break;
                    case 3:
                        play.player.SetLinkWithItemRightState(itemNum);

                        break;
                    default:
                        Console.WriteLine("not gonna happen ");
                        break;

                }
                if (itemNum == 2 || itemNum ==9) //bomb, need to calculate its number 
                {
                    inventory.bombNum--;
                    
                    if(inventory.bombNum == 0)
                    {
                        inventory.itemList.Remove("bomb");
                        inventory.itemSelect = null;
                        inventory.itemB = null;
                    }
                }
            }
             


        }
        private int getItemNum(String selectItem)
        {
            int i = -1;
            //selected item, can be bomb(2), arrow(0), boomerage(5), candle(1)  
            switch (selectItem)
            {
                case "bomb":
                    if (Link.ifDamage)
                    {
                        i = 9;
                    }
                    else
                    {
                        i = 2;
                    }
                    break;
                case "bow":
                    if (Link.ifDamage)
                    {
                        i = 7;
                    }
                    else
                    {
                        i = 0;
                    }
                    break;
                case "candle":
                    if (Link.ifDamage)
                    {
                        i = 8;
                    }
                    else
                    {
                        i = 1;
                    }
                    break;
                case "boomerang":
                    if (Link.ifDamage)
                    {
                        i = 10;
                    }
                    else
                    {
                        i = 5;
                    }
                    break;



            }
            return i;
        }

    }
}
