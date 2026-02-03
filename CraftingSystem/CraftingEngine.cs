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
        public string CraftingEngineName { get; set; }
        public Person Player = new Person();
        public Person Vendor = new Person();

        public List<Recipe> Recipes = new List<Recipe>();
         
        public void Setup()
        {
            // Adding a couple recipes to the game!
            Recipes.Add(
            new Recipe(
                "Recipe 1",
                "description",
                1,
                new List<Item>()
                    {
                        new Item("item name", 1, 1),
                        new Item("item name 2", 2, 2),
                        new Item("item name 3", 3, 3)
                    }
                )
            );
            Recipes.Add(
            new Recipe(
                "Recipe 2",
                "description",
                2,
                new List<Item>()
                    {
                        new Item("item name 4", 4, 4)
                    }
                )
            );

            foreach (Recipe recipe in Recipes)
            {
                Player.KnownRecipes.Add(recipe);
            }

            // The player chooses their name
            SetName();
        }
        
        
        public void MainMenu()
        {
            Render();
            Print("The Menu of Wonder!" +
                "\n1) View your Recipes" +
                "\n2) blah" +
                "\n3) blah" +
                "\n4) blah" +
                "\n5) Change your name");

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
    }
}