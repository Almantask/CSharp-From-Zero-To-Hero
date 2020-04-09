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
            //Input
            Console.WriteLine(message);
            string number = Console.ReadLine();

            //Check if the string is empty
            if (string.IsNullOrEmpty(number)) return 0;

            //Check if the string is a number
            if (!int.TryParse(number, out var wholeNumber))
            {
                Console.WriteLine(number + " is not a valid number.");
                return -1;
            }

            return wholeNumber;
        }

        public static string PromptString(string message)
        {
            //Input
            Console.WriteLine(message);
            string text = Console.ReadLine();

            //Check if the string is empty
            if (string.IsNullOrEmpty(text))
            {
                Console.WriteLine("Name cannot be empty.");
                return "-";
            }

            return text;
        }

        public static float PromptFloat(string message)
        {
            //Input
            Console.WriteLine(message);
            string number = Console.ReadLine();

            //Check if the string is empty
            if (string.IsNullOrEmpty(number)) return 0;

            //Check if the string is a number
            if (!float.TryParse(number, out float floatNumber))
            {
                Console.WriteLine(number + " is not a valid number.");
                return -1;
            }

            return floatNumber;
        }

        public static float CalculateBmi(float weight, float height)
        {
            string caseFail = "Failed calculating BMI. Reason: ";
            string case1 = "Height cannot be equal or less than zero, but was " + height + ".";
            string case2 = "Weight cannot be equal or less than zero, but was " + weight + ".";

            //Check if values are correct
            if (height <= 0 && weight <= 0)
            {
                Console.WriteLine(caseFail);
                Console.WriteLine(case1);
                Console.WriteLine(case2);
                return -1;
            }
            else if (height <= 0)
            {
                Console.WriteLine(caseFail);
                Console.WriteLine(case1);
                return -1;
            }
            else if (weight <= 0)
            {
                Console.WriteLine(caseFail);
                Console.WriteLine(case2);
                return -1;
            }

            float bmi = weight / (height * height);

            return bmi;
        }
    }
}
