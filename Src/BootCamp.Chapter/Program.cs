using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Console = System.Console;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
        }

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
            string input = Console.ReadLine();
            if (float.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out float number) && number >= 1)
            {
                return number;
            }
            else if (input.Length == 0)
            {
                return 0;
            }
            else
            {
                Console.WriteLine($"{input} is not a valid entry");
                return -1;
            }
            
        }

        public static string StringPrompt(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public static int IntPrompt(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            if (int.TryParse(input, out int number) && number > 0)
            {
                return number;
            }
            else if (input.Length == 0)
            {
                return 0;
            }
            else
            {
                Console.WriteLine($"{input} is not a valid entry");
                return -1;
            }
            
        }

        public static float CalculateBMI(float weight, float height)
        {
            return weight / (height * height);
        }
    }
}
}
