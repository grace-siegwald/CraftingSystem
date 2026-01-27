using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CraftingSystem
{
    public class Recipe
    {
        private string RecipeName;
        private int ResultQuantity;
        private List<Item> Ingredients = new List<Item>();

        public Recipe(string name, int resultQuantity, List<Item> ingredients)
        {
            RecipeName = name;
            ResultQuantity = resultQuantity;
            Ingredients = ingredients;
        }
    }
}