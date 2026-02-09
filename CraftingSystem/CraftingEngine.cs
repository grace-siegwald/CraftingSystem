using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using static CraftingSystem.Display;

namespace CraftingSystem
{
    public class CraftingEngine
    {
        public string CraftingEngineName = "Craft Craft Craft!";
        public Person Player = new Person(100);
        public Person Vendor = new Person();

        public Dictionary<Recipe, List<Item>> Recipes = new Dictionary<Recipe, List<Item>>();

        public void Setup()
        {
            // Setting Console Title!
            Console.Title = CraftingEngineName;

            // Adding a couple recipes to the game!
            AddAllRecipesToGame();

            foreach (var recipe in Recipes)
            {
                Player.KnownRecipes.Add(recipe.Key, recipe.Value);
            }

            SetName();
        }
        
        
        public void MainMenu()
        {
            Render();

            PrintCenter(Player.Info());

            string[] menuText = {
                "1) View your Recipes",
                "2) blah",
                "3) blah",
                "4) blah",
                "4) Change your Name",
                "",
                "",
                "6) Credits!"
            };
            PrintCenterLeft(menuText);

            string input = Console.ReadLine();
            int choice = Convert.ToInt32(input);
            switch (choice)
            {
                case 1:
                    Player.ShowKnownRecipes();
                    MainMenu();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    SetName();
                    break;
                case 6:
                    Credits();
                    break;
            }
        }

        public void SetName()
        {
            Render();
            Print("Hello beautiful player of this crafting game! " +
                "\nPlease enter your name:");
            
            // Player inputs their name
            Player.Name = Console.ReadLine();

            Print($"Wow {Player.Name}, a beautiful name for a beautiful person! Now press any key to enter the game!");
            Console.ReadKey();
            MainMenu();
        }
        public void Credits()
        {
            Render();
            string[] text = {
                $"Wow thanks for looking at the credits {Player.Name}, you beautiful human!",
                $"── ⋅⋅ ──── ⋅⋅ ──── ⋅⋅ ──",
                $"Created By: Grace Siegwald",
                $"https://github.com/grace-siegwald",
                $"Press any Key to return to the Main Menu! :D",
            };

            PrintCenter(text);

            Console.ReadKey();
            MainMenu();
        }

        public void AddAllRecipesToGame()
        {
            Recipes.Add(
            new Recipe(
                "Recipe 1",
                "description",
                1),
            new List<Item>()
                    {
                        new Item("item name", 1, 1),
                        new Item("item name 2", 2, 2),
                        new Item("item name 3", 3, 3)
                    }
            );
            Recipes.Add(
            new Recipe(
                "Recipe 2",
                "description",
                2),
            new List<Item>()
                    {
                        new Item("item name 4", 4, 4)
                    }
            );
        }
    }
}