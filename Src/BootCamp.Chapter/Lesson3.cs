using System;
using System.Globalization;

namespace BootCamp.Chapter
{
    public class Lesson3
    {
        // Program is defined here.
        public static void Demo()
        {
            string firstName = PromptString("Please enter the first name.");
            string lastName = PromptString("Please enter the surname.");
            int age = PromptInt("Please enter the age in years.");
            float weight = PromptFloat("Please enter the weight in kg.");
            float height = PromptFloat("Please enter the height in metres.");

            Console.WriteLine(firstName + " " + lastName + " is " + age + " years old, their weight is " + weight + " kg and their height is " + height + " m.");
            Console.WriteLine("Their BMI is " + CalculateBmi(weight, height) + ".");
            Console.ReadLine();
        }

        // All functions are defined here for use in the main Demo function.

        public static int PromptInt(string message)
        {
            Console.WriteLine(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            return float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        public static float CalculateBmi(float weight, float height)
        {
            return weight / (height * height);
        }
    }
}