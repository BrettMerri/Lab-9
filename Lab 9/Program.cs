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
            Console.Title = "Circle Tester"; //Set console title

            //Set default console colors
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Welcome to the Circle Tester!");

            bool loop = true; //Set loop to true

            List<Circle> CircleList = new List<Circle>(); //Create a list of Circle objects named CircleList
            while (loop)
            {
                Console.Write("Enter radius: "); //Prompts user to input radius
                CircleList.Add(new Circle(ValidateConsoleInput.GetDoubleInRange(0, double.MaxValue))); //Validates user input is valid and in range and creates a new circle object with that radius input
                Console.WriteLine($"Circumference: {CircleList.Last().GetFormattedCircumference()}"); //Writes the formatted circumference of the last added Circle in the CircleList
                Console.WriteLine($"Area: {CircleList.Last().GetFormattedArea()}"); //Writes the formatted area of the last added Circle in the CircleList
                if (!ContinueApp()) //Prompts user if he wants to continue. Set loop to false if use does not want to continue.
                    loop = false;
            }
            Console.WriteLine($"\nGoodbye. You have created {CircleList.Count} Circle object(s)."); //Lets the user know how many circle objects were created while this application was running
        }

        public static bool ContinueApp()
        {
            string[] Options = new string[] { "y", "n" };
            Console.Write("Do you want to test more circles? (y/n): "); //Prompt user to type y or n
            string input = ValidateConsoleInput.GetValidString(Options); //Gets validated string from the user that is either y or n.
            if (input == "y") //If input is y, write new line and return true
            {
                Console.WriteLine();
                return true;
            }
            else //If inpus is n, return false
                return false;
        }

    }
}
