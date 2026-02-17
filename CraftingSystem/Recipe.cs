using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CraftingSystem
{
    public class Recipe
    {
        public string Name;
        public string Description;
        public List<Item> Ingredients = new List<Item>();
        public int YieldAmount;
        public int YieldValue;

        public Recipe(string name, string description, int yieldAmount)
        {
            Name = name;
            Description = description;
            YieldAmount = yieldAmount;
        }
        public Recipe() { }

    }
}