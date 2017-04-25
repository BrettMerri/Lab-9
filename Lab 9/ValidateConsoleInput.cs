using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    class ValidateConsoleInput
    {
        #region Double
        public static double GetValidDouble() //Gets a valid double from the user
        {
            double Input;
            while (!double.TryParse(Console.ReadLine(), out Input)) //While the user input cannot be parsed into a double, display error and have user try again.
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Input must be a number. Try again: ");
                Console.ForegroundColor = ConsoleColor.White;
            }
            return Input;
        }

        public static double GetDoubleInRange(double Min, double Max) //Gets a valid double within a specific range from the user
        {
            double Input = GetValidDouble();
            while (Input < Min || Input > Max) //While valid double input is not between Min and Max, display error and have the user try again.
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"Input not between {Min} and {Max}. Try again: ");
                Console.ForegroundColor = ConsoleColor.White;
                Input = GetValidDouble();
            }
            return Input;
        }
        #endregion

        #region String
        public static string GetValidString(string[] Options) //Gets a valid string from the user that equals one of the options in the Options array.
        {
            string Input;
            string ListOfOptions = string.Join(", ", Options); //Creates a string of all elements in the Options array seperated by a comma.

            while (true)
            {
                Input = Console.ReadLine().ToLower(); //Gets a lowercase input from user.

                foreach (string item in Options) //Checks if user input equals any string in the Options array.
                {
                    if (Input == item) //If user input equals an option, return the input.
                        return Input;
                }
                //If user input does not equal any of the options, write a list of options to choose from and have them try again.
                Console.ForegroundColor = ConsoleColor.Red; 
                Console.Write($"Input must be either of the following: [{ListOfOptions}]. Try again: "); 
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        #endregion


    }
}
