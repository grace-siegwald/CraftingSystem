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
        public int Value;
        public Item(string name, int quantity, int value)
        {
            Name = name;
            //Description = Description;
            Quantity = quantity;
            Value = value;
        }
        public Item() { }
    }
}