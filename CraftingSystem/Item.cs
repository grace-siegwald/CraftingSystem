using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CraftingSystem
{
    public class Item
    {
        public string Name;
        public string Description;
        public int Quantity;
        public int Price;
        public Item(string name, int quantity, int price)
        {
            Name = name;
            Description = "temp description";
            Quantity = quantity;
            Price = price;
        }
        public Item() { }
    }
}