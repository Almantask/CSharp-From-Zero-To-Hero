using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    /// <summary>
    /// Test class is used to test your implementation.
    /// Each homework will have a set of steps that you will have to do.
    /// You can name your functions however you want, but to validate your solution, place them here.
    /// DO NOT CALL FUNCTIONS FROM TESTS CLASS
    /// DO NOT IMPLEMENT FUNCTIONS IN TESTS CLASS
    /// TESTS CLASS FUNCTIONS SHOULD ALL HAVE 1 LINE OF CODE
    /// </summary>
    public static class Checks
    {
        public static int PromptInt(string message)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();
            if(string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Input cannot be empty");
                return -1;
            }
            else if (!int.TryParse(input, out int number))
            {
                Console.WriteLine($"\"{input}\" is not a valid number.");
                return -1;
            }
            else
            {
                return number;
            }

        }

        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            var name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name cannot be empty");
                return "-";
            }
            else
            {
                return name;
            }
        }

        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Input cannot be empty");
                return -1;
            }
            else if (!float.TryParse(input, out float number))
            {
                Console.WriteLine($"\"{input}\" is not a valid number.");
                return -1;
            }
            else
            {
                return number;
            }
        }

        public static float CalculateBmi(float weight, float height)
        {
            if (weight == 0 && height == 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:Weight cannot be equal or less than zero, but was 0.\n Height cannot be equal or less than zero, but was 0");
                return -1;
            }
            else if (weight <= 0)
            {
                Console.WriteLine($"Failed calculating BMI. Reason:Weight cannot be equal or less than zero, but was {weight}.");
                return -1;
            }
            else if (height <= 0)
            {
                Console.WriteLine($"Failed calculating BMI. Reason:Height cannot be equal or less than zero, but was {height}");
                return -1;
            }   
            else
            {
                return weight / (height * height);
            }
        }
    }
}
