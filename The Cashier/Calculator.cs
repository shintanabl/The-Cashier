using System;
using System.Collections.Generic;
using System.Text;

namespace The_Cashier
{
    class Calculator
    {
        private List<Item> ListItem;
        private double total = 0;
        
        public Calculator()
        {
            this.ListItem = new List<Item>();
        }
        public void addItem(Item item)
        {
            this.ListItem.Add(item);
            this.total += item.getSubtotal();
        }
        public double getTotal()
        {
            return total;
        }

        public List<Item> getListItem()
        {
            return ListItem;
        }
    }
}
