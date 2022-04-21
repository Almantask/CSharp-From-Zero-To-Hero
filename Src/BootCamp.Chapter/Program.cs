using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using Console = System.Console;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static int ParseInt(string message)
        {
            Console.WriteLine(message);
            string maybeNumber = Console.ReadLine();
            bool isNumber = int.TryParse(maybeNumber, out int number);
            if (!isNumber)
            {
                Console.WriteLine($"\"{maybeNumber}\" is not a valid number.");
                return -1;
            }
            return number;
        }

        public static float FloatParse(string message)
        {
            CultureInfo.CurrentCulture = new CultureInfo("en-US");
            Console.WriteLine(message);
            string maybeNumber = Console.ReadLine();
            bool isNumber = float.TryParse(maybeNumber, out float number);
            if (!isNumber)
            {
                Console.WriteLine($"\"{maybeNumber}\" is not a valid number.");
                return -1;
            }
            return number;
        }

        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            bool isName = string.IsNullOrEmpty(input);
            if (isName)
            {
                Console.WriteLine("Name cannot be empty");
                return "-";
            }
            return input;
        }

        public static float CalculateBmi(float weight, float height)
        {
            CultureInfo.CurrentCulture = new CultureInfo("en-US");
            if ((weight <= 0 || height <= 0))
            {
                string underNull = "";
                if (height <= 0)
                {
                    underNull = string.Format($"Height cannot be equal or less than zero, but was {height}.");
                }
                if (weight <= 0)
                {
                    underNull += string.Format($"Weight cannot be equal or less than zero, but was {weight}.");
                }
                Console.WriteLine("Failed calculating BMI. Reason:" + underNull);
                return -1;
            }
            return weight / (float)Math.Pow(height, 2);
        }
    }
}
