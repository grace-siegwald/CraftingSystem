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
        public int ResultQuantity;
        
        public Recipe(string name, string description, int resultQuantity, List<Item> ingredients)
        {
            Name = name;
            Description = description;
            ResultQuantity = resultQuantity;
            Ingredients = ingredients;
        }
    }
}