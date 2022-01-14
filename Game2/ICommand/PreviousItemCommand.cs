using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    class PreviousItemCommand: ICommand
    {
        private IInventory inventory;
        public PreviousItemCommand(IInventory inventory)
        {
            this.inventory = inventory;
        }
        public void Execute()
        {
            int i = inventory.currentIndex - 1;
            int count = inventory.itemList.Count;
            if (i >= 0)
            {
                inventory.currentIndex --;
            }
        }
    }
}
