using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Circle Tester";

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Welcome to the Circle Tester!");

            bool loop = true;
            List<Circle> CircleList = new List<Circle>();
            while (loop)
            {
                Console.Write("Enter radius: ");
                CircleList.Add(new Circle(GetValidDouble()));
                Console.WriteLine($"Circumference: {CircleList.Last().GetFormattedCircumference()}");
                Console.WriteLine($"Area: {CircleList.Last().GetFormattedArea()}");
                if (!ContinueApp()) //Prompts user if he wants to continue. Set loop to false if use does not want to continue.
                    loop = false;
            }
            Console.WriteLine($"\nGoodbye. You have created {CircleList.Count} Circle object(s).");
        }

        public static double GetValidDouble()
        {
            double input;
            while (!double.TryParse(Console.ReadLine(), out input))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Please enter a valid input. Try again: ");
                Console.ForegroundColor = ConsoleColor.White;
            }
            return input;
        }

        public static bool ContinueApp()
        {
            while (true) //Loop ContinueApp in case of an error
            {
                Console.Write("Do you want to test more circles? (y/n): ");
                string input = Console.ReadLine().ToLower();
                if (input == "y")
                {
                    Console.WriteLine();
                    return true;
                }
                else if (input == "n")
                    return false;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: Input not y or n.\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

    }
}
