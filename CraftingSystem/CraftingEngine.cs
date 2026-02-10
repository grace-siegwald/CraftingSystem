using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Xml;
using static CraftingSystem.Display;

namespace CraftingSystem
{
    public class CraftingEngine
    {
        public string CraftingEngineName = "Craft Craft Craft!";
        public Person Player = new Person(100);
        public Person Vendor = new Person();

        //public Dictionary<Recipe, List<Item>> Recipes = new Dictionary<Recipe, List<Item>>();
        public List<Recipe> Recipes = new List<Recipe>();

        public void Setup()
        {
            // Setting Console Title!
            Console.Title = CraftingEngineName;

            // Adding a couple recipes to the game!
            LoadRecipes();

            foreach (var recipe in Recipes)
            {
                Player.KnownRecipes.Add(recipe);
            }

            SetName();
        }
        
        
        public void MainMenu()
        {
            Render();

            PrintCenter(Player.Info());

            string[] menuText = {
                "1) Inventory",
                "2) Your Recipes",
                "3) blah",
                "4) blah",
                "5) Change your Name",
                "",
                "",
                "6) Credits!"
            };
            PrintCenterLeft(menuText);

            string input = PlayerInput();
            if (input is "1" or "2" or "3" or "4" or "5" or "6" or "7" or "8" or "9")
            {
                int choice = Convert.ToInt32(input);
                if (choice is 1 or 2 or 3 or 4 or 5 or 6)
                {
                    switch (choice)
                    {
                        case 1:
                            Player.ShowInventory();
                            MainMenu();
                            break;
                        case 2:
                            Player.ShowKnownRecipes();
                            MainMenu();
                            break;
                        case 3:
                            MainMenu();
                            break;
                        case 4:
                            MainMenu();
                            break;
                        case 5:
                            SetName();
                            break;
                        case 6:
                            Credits();
                            break;
                    }
                }
                else
                {
                    PrintCenter("that's not a number 1-6, silly!");
                    Pause();
                    MainMenu();
                }
            }
            else
            {
                PrintCenter("that's not a number 1-6, silly!");
                Pause();
                MainMenu();
            }
        }

        public void SetName()
        {
            Render();

            // TEMP EXAMPLE for External Data IO Demo -----------------------
            //string exampleText = "";
            
            //string fileNamePath = "../../../data/defualtNames.txt";
            //if (!File.Exists(fileNamePath))
            //{
            //    Player.Name = "Player";
            //    return;
            //}
            //else
            //{
            //    string[] names = File.ReadAllLines(fileNamePath);
            //    Player.Name = names[RandomNumberGenerator.GetInt32(0,6)];
            //    PrintCenter($"Your defualt name is {Player.Name}!");
            //}
                
            //try
            //{
            //    exampleText = File.ReadAllText("../../../data/ExampleText.txt");
            //}
            //catch 
            //{
            //    Console.WriteLine($"Error reading file");
            //    return;
            //}
            //PrintCenter(exampleText);
            // END OF EXAMPLE -------------------------------------------

            PrintCenter("Hello beautiful player of this crafting game! Please enter your name:");

            // Player inputs their name
            Player.Name = PlayerInput();

            PrintCenter($"Wow {Player.Name}, a beautiful name for a beautiful person! Now press any key to enter the game!");
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

        public void LoadRecipes()
        {
            string fileName = "../../../data/Recipes.xml";

            XmlDocument doc = new XmlDocument();
            doc.Load(fileName);
            XmlNode root = doc.DocumentElement;
            XmlNodeList recipeList = root.SelectNodes("/recipes/recipe");
            
            XmlNodeList ingredientsList;

            foreach (XmlElement recipe in recipeList)
            {
                Recipe recipeToAdd = new Recipe();
                // find what is in the recipe class and match that to what's in the xml file...
                recipeToAdd.Name = recipe.GetAttribute("name");
                recipeToAdd.Description = recipe.GetAttribute("description");
                string yieldAmount = recipe.GetAttribute("yieldAmount");
                if (int.TryParse(yieldAmount, out int amount))
                { recipeToAdd.YieldAmount = amount; }

                ingredientsList = recipe.ChildNodes; //for ingredients

                foreach (XmlElement i in ingredientsList)
                {
                    //Item itemToAdd = new Item();
                    //itemToAdd.Name = i.GetAttribute("name");

                    string ingredientName = i.GetAttribute("name");
                    string ingredientAmountString = i.GetAttribute("amount");
                    int ingredientAmount = 0;
                    if (int.TryParse(ingredientAmountString, out int e))
                    { ingredientAmount = e; }

                    string tempIngredientValue = i.GetAttribute("value");
                    int ingredientValue = 0;
                    if (int.TryParse(tempIngredientValue, out int ingValue))
                    { ingredientValue = ingValue; }

                    recipeToAdd.Ingredients.Add(new Item(ingredientName, ingredientAmount, ingredientValue));
                }
                Recipes.Add(recipeToAdd);
            }
        }

    }
}