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
        public static void PrintCenter(string text)
        {
            if (Console.WindowWidth < text.Length)
            {
                Console.WriteLine(text);
            }

            int leadingSpaces = (Console.WindowWidth - text.Length) / 2;
            string padding = new string(' ', leadingSpaces);

            Console.WriteLine(padding + text);
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

                Console.WriteLine(padding + line);
            }
        }

        public static void Render()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
        }

        public static void Border()
        {
            string[,] border = { {"I"}, {""}, {"I"} };

        }
    }
}