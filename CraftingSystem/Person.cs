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
        //public List<Recipe> KnownRecipes = new List<Recipe>();

        //public Dictionary<Recipe, List<Item>> KnownRecipes = new Dictionary<Recipe, List<Item>>();
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
            Inventory.Add(new Item("Wood", 10, 1));
            Inventory.Add(new Item("Stone", 10, 1));
            Inventory.Add(new Item("Flint", 10, 1));
        }

        public Person() { }

        private void BuyItem(Item item)
        {
            // Adds the specified item to the person's Inventory
        }
        private void SellItem(Item item)
        {
            // Removes the specified item to the person's Inventory
        }

        public bool Search(Item name)
        {
            // Searches through a collection of a person's current ITEMS. If it finds it, return TRUE. If it doesn't, return FALSE
            foreach (var item in Inventory)
            {
                if (item.Name == name.Name)
                {
                    return true;
                }
            }
            return false;
        }
        public bool Search(Recipe name)
        {
            // Searches through a collection of a person's current RECIPES. If it finds it, return TRUE. If it doesn't, return FALSE
            bool output = true;

            return output;
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

            PrintCenter($"Wowww {Name} look at all these recipes you've discovered");

            foreach (var recipe in KnownRecipes)
            {
                for (int n = 0; n < KnownRecipes.Count; n++)
                {
                    string[] text = {
                        $"{n + 1}) {recipe.Name}",
                        $"   Description: {recipe.Description}",
                        $"   Requires:"
                    };
                    PrintCenterLeft(text);
                }
            }
            AddSpace();
            PrintCenter("Press any key to return to menu");
            Console.ReadKey();
        }

        public void ShowInventory()
        {
            Render();

            PrintCenter($"Wowww {Name} look at all these items you have");

            int n = 1;
            foreach (var item in Inventory)
            {
                string[] text = {
                        $"{n}) {item.Name}",
                        $"   Description: {item.Description}",
                        $"   Value: {item.Value}$"
                    };
                n++;
                PrintCenterLeft(text);
            }
            AddSpace();
            PrintCenter("Press any key to return to menu");
            Console.ReadKey();
        }

        public string[] Info()
        {
            string[] output = {
                $"Hiiiiii {Name}!!",
                $"You have {Money}$"
            };

            return output;
        }
    }
}