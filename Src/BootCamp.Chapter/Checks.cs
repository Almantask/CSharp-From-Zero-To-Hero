using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

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
            Console.Write($"{message}");
            int.TryParse(Console.ReadLine(), out int value);
            return value;
        }

        public static string PromptString(string message)
        {
            Console.Write($"{message}");
            return Console.ReadLine();
        }

        public static float PromptFloat(string message)
        {
            Console.Write($"{message}");
            float.TryParse(Console.ReadLine(), out float value);
            return value;
        }

        public static float CalculateBmi(float weight, float height)
        {
            float bmi = (float)(weight / Math.Pow(height, 2));
            return bmi;
        }

        public static void DisplayDetail(string name, int age, float weight, float height, float bmi)
        {
            Console.WriteLine($"{name} is {age} years old, his weight is {weight} kg & his height is {height} cm. The bmi is {bmi}");
        }
    }
}
