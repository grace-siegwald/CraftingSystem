using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace CraftingSystem
{
    public class Display
    {
        public static void Print (string text)
        {
            Console.WriteLine(text);
        }

        public static void Pause()
        {
            Console.ReadKey();
        }
        public static string PlayerInput()
        {
            return Console.ReadLine();
        }
        public static void AddSpace()
        {
            Console.WriteLine();
            Console.WriteLine();
        }


        public static void PrintCenter(string[] inputText)
        {
            foreach (string line in inputText)
            {
                if (Console.WindowWidth < line.Length)
                {
                    Console.WriteLine(line);
                }

                int leadingSpaces = (Console.WindowWidth - line.Length) / 2;
                string padding = new string(' ', leadingSpaces);

                Console.WriteLine(padding + line);
            }
        }
        public static void PrintCenter(string inputText)
        {
            if (Console.WindowWidth < inputText.Length)
            {
                Console.WriteLine(inputText);
            }

            int leadingSpaces = (Console.WindowWidth - inputText.Length) / 2;
            string padding = new string(' ', leadingSpaces);

            Console.WriteLine(padding + inputText);
        }
        public static void PrintCenterLeft(string inputText)
        {
            if (Console.WindowWidth < inputText.Length)
            {
                Console.WriteLine(inputText);
            }

            int leadingSpaces = Console.WindowWidth / 3;
            string padding = new string(' ', leadingSpaces);

            //string  padding = AnsiConsole.MarkupLine("[rgb(255,87,51)]Orange-red text[/]");;
            //AnsiConsole.MarkupLine($"[on red]{padding}[/]" + line);

            Console.WriteLine(padding + inputText);
        }
        public static void PrintCenterLeft(string[] inputText)
        {
            foreach (string line in inputText)
            {
                if (Console.WindowWidth < line.Length)
                {
                    Console.WriteLine(line);
                }

                int leadingSpaces = Console.WindowWidth / 3;
                string padding = new string(' ', leadingSpaces);
                
                //string  padding = AnsiConsole.MarkupLine("[rgb(255,87,51)]Orange-red text[/]");;
                //AnsiConsole.MarkupLine($"[on red]{padding}[/]" + line);

                Console.WriteLine(padding + line);
            }
        }

        public static void Render()
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            PrintCenter(".-=-..-=-..-=-..-=-..-=-..-=-..-=-..-=-..-=-..-=-..-=-..-=-..-=-..-=-..-=-..-=-..-=-..-=-..-=-..-=-..-=-.");
            AddSpace();
        }
    }
}