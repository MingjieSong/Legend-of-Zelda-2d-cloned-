using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    class DownLineCommand:ICommand
    {
        private IInventory inventory;
        public DownLineCommand(IInventory inventory)
        {
            this.inventory = inventory;
        }
        public void Execute()
        {
            int i = inventory.currentIndex+4;
            int count = inventory.itemList.Count;
            if (i < count )
            {
                inventory.currentIndex += 4;
            }

        }
    }
}
