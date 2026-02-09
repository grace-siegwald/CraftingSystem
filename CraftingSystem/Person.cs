using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static CraftingSystem.Display;

namespace CraftingSystem
{
    public class Person
    {
        public string Name;
        public int Money;
        public List<Item> Inventory = new List<Item>();
        public List<Recipe> KnownRecipes = new List<Recipe>();

        public Person(string name, int money, List<Item> inventory, List<Recipe> recipes)
        {
            Name = name;
            Money = money;
            Inventory = inventory;
            KnownRecipes = recipes;
        }

        public Person(int money)
        {
            Money = money;
        }

        // overloaded constructor
        public Person() { }

        private void BuyItem(Item item)
        {

        }
        private void SellItem(Item item)
        {

        }

        private Item Craft(Recipe recipe)
        {
            return null;
        }

        public string GetMoney()
        {
            return Money.ToString();
        }
        
        public void ShowKnownRecipes()
        {
            Render();
            foreach (Recipe recipe in KnownRecipes)
            {
                for (int n=0; n < KnownRecipes.Count; n++)
                {
                    Print($"{n + 1}) {recipe.Name}");
                }
            }
            Print("Press any key to return to menu");
            Console.ReadKey();
        }

        public string[] Info()
        {
            //var content = $"Hiiiiii {Name}!!" +
            //    $" You have {Money}$"; 

            string[] content = { 
                $"Hiiiiii {Name}!!", 
                $"You have {Money}$"
            };

            return content;
        }
    }
}