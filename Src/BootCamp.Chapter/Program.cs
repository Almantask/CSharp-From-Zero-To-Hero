using System;
using System.Collections.Generic;
using System.IO;
using Console = System.Console;

namespace BootCamp.Chapter
{
    class Program
    {
        public static float CalculateBmi(float weight, float height)
        {
            if (!(weight <= 0) && !(height <= 0)) return weight / (height * height);
            Console.WriteLine("Failed calculating BMI. Reason:");
            if (weight <= 0) Console.WriteLine("Weight cannot be equal or less than zero, but was " + weight);
            if (height <= 0) Console.WriteLine("Height cannot be equal or less than zero, but was " + height);
            Console.WriteLine();
            return -1;
        }

        public static int PromptInt(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            bool isNumber = int.TryParse(input, out int number);
            if (isNumber) return number;
            Console.WriteLine('"' + input + "\" is not a valid number.");
            return -1;
        }

        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            bool isNumber = float.TryParse(input, out float number);
            if (isNumber) return number;
            Console.WriteLine('"' + input + "\" is not a valid number.");
            return -1;
        }

        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input)) return input;
            Console.WriteLine("Name cannot be empty.");
            return "-";
        }

        static void Main(string[] args)
        {
        }
    }
}