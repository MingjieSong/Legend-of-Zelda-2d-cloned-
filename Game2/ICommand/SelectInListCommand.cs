using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  Sprint2
{
    class SelectInListCommand:ICommand
    {
        // later: add shining feature to the rectangle
        private IInventory inventory;
        public SelectInListCommand(IInventory inventory)
        {
            this.inventory = inventory;
        }
        public void Execute()
        {
            int i = inventory.currentIndex ;
            inventory.itemSelect = inventory.itemList[i];


        }

    }
}
