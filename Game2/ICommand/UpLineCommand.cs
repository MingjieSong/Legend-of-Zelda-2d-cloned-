using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  Sprint2
{
    class UpLineCommand: ICommand
    {
        private IInventory inventory;
        public UpLineCommand(IInventory inventory)
        {
            this.inventory = inventory;
        }
        public void Execute()
        {
            int i = inventory.currentIndex - 4;
            int count = inventory.itemList.Count;
            if (i >=0)
            {
                inventory.currentIndex -= 4;
            }
        }

    }
}

