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
            Inventory.Add(new Item("Water", 1, 10));
            Inventory.Add(new Item("Chamomile", 1, 10));
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

        public Item? Craft(Recipe recipe)
        {
            string output = "";
            // This method needs to SEARCH the player's inventory for each of the items required in the recipe being passed in
            foreach (Item item in recipe.Ingredients)
            {
                // Check player inventory for the Item...
                bool itemCheck = Search(item);
                if (itemCheck == true)
                {
                    output += $"You have |{item}| ";
                    
                    // ...and the Quantity of said Item
                    bool quantityCheck = SearchQuantity(item.Quantity);
                    if (quantityCheck == true)
                    {
                        output += $"and its required quantity of |{item.Quantity}|";
                        
                        // if both checks are passed, we break out of the loop...
                        break;
                    }
                    else if (quantityCheck == false)
                    {
                        output += $"but not its required quantity of |{item.Quantity}|";
                        PrintCenter(output);
                        return null;
                    }
                }
                else if (itemCheck == false)
                {
                    PrintCenter($"Sorryyyyy {Name}, you don't have the required ingredients to craft this recipe!");
                    return null;
                }
            }
            // ...create a new Item with the same name as the recipe, as well as it's specified amount and value, and return said Item!
            Item recipeProduct = new Item(recipe.Name, recipe.YieldAmount, recipe.YieldValue);

            string[] successText = {output ,$"Beautiful! You have now crafted a {recipeProduct.Name}"};
            PrintCenter(successText);

            return recipeProduct;
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
        public bool SearchQuantity(int recipeQuantity)
        {
            foreach (var item in Inventory)
            {
                if (item.Quantity == recipeQuantity)
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
        public string GetMoney()
        {
            return Money.ToString();
        }


        public void RecipesMenu()
        {
            Render();

            PrintCenter($"Wowww {Name} look at all these recipes you've discovered");

            foreach (var recipe in KnownRecipes)
            {
                List<Item> itemList = new List<Item>();
                foreach (Item item in recipe.Ingredients) { itemList.Add(item); }

                for (int n = 0; n < KnownRecipes.Count; n++)
                {
                    string[] text = {
                        $"{n + 1}) {recipe.Name}",
                        $"      Description: {recipe.Description}",
                        $"      Requires:"
                    };
                    PrintCenterLeft(text);
                    foreach (Item item in itemList)
                    {
                        PrintCenterLeft($"          {item.Name} (x{item.Quantity})");
                    }
                }
            }
            AddSpace();
            PrintCenter("Press any key to return to menu");
            Console.ReadKey();
        }

        public void InventoryMenu()
        {
            Render();
            
            PrintCenter($"Wowww {Name} look at all these items you have");

            foreach (var item in Inventory)
            {
                string[] text = {
                        $"* {item.Name} (x{item.Quantity})",
                        $"   Value: ${item.Value}"
                    };
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