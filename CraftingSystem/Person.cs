using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CraftingSystem
{
    public class Person
    {
        private string PersonName;
        private int Money;
        private List<Item> Inventory = new List<Item>();
        private List<Recipe> KnownRecipes = new List<Recipe>();

        public Person(string name, int money, List<Item> inventory, List<Recipe> recipes)
        {
            PersonName = name;
            Money = money;
            Inventory = inventory;
            KnownRecipes = recipes;
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
    }
}