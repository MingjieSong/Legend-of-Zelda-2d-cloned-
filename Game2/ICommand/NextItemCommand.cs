using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    class NextItemCommand : ICommand
    {
        private IInventory inventory;
        public NextItemCommand(IInventory inventory)
        {
            this.inventory = inventory;
        }
        public void Execute()
        {

            int i = inventory.currentIndex + 1;
            int count = inventory.itemList.Count;
            if (i < count)
            {
                inventory.currentIndex += 1;
            }


        }
    }
}