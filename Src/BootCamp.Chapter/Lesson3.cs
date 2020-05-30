using System;
using System.Globalization;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            string name = StringPrompt("Please introduce a name:");
            string surname = StringPrompt("Please introduce surname:");
            int age = IntPrompt("Please introduce age:");
            float weight = FloatPrompt("Please introduce weight (kg):");
            float height = FloatPrompt("Please introduce height (m):");

            Console.WriteLine($"{name} {surname} is {age} years old, weight is {weight} kg and height is {height} m.");

            Console.WriteLine($"BMI of {name} {surname} is {CalculateBMI(weight, height)}.");
        }

        public static float FloatPrompt(string message)
        {
            Console.WriteLine(message);
            return float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        public static string StringPrompt(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public static int IntPrompt(string message)
        {
            Console.WriteLine(message);
            return int.Parse(Console.ReadLine());
        }

        public static float CalculateBMI(float weight, float height)
        {
            return weight / (height * height);
        }
    }
}
