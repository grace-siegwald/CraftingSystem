using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CraftingSystem
{
    public class Display
    {
        public static void Print (string text)
        {
            Console.WriteLine(text);
        }
        public static void Render()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
        }
    }
}