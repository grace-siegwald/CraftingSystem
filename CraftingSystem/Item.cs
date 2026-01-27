using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CraftingSystem
{
    public class Item
    {
        private string ItemName;
        private int ItemQuantity;
        private int price;
        public Item(string name, int quantity, int price)
        {
            ItemName = name;
            ItemQuantity = quantity;
            this.price = price;
        }
    }
}