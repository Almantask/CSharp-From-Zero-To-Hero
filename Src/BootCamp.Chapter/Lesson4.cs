using System;
using System.Globalization;

namespace BootCamp.Chapter
{
    class Lesson4
    {
        public static void Demo()
        {
            GetInfoAndPrint();
            GetInfoAndPrint();
        }

        static void GetInfoAndPrint()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            var age = PromptForInt("Age: ");

            var weight = PromptForFloat("Weight (in kg): ");

            var height = PromptForFloat("Height (in m): ");

            double bmi = CalculateBmi(weight, height);

            Console.WriteLine($"{ name } is { age } years old, his weight is { weight } kg and his height is { height } m. { name }'s BMI is { bmi }.");
        }

        public static float CalculateBmi(float weight, float height)
        {
            bool isValidWeight = true;
            bool isValidHeight = true;

            string errorMessage = "{0} cannot be equal or less than zero, but was {1}.";

            if (weight <= 0)
            {
                isValidWeight = false;
            }

            if (height <= 0)
            {
                isValidHeight = false;
            }

            if (!isValidWeight || !isValidHeight)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");

                if (!isValidWeight)
                {
                    Console.WriteLine(string.Format(errorMessage, "Weight", weight));
                }

                if (!isValidHeight)
                {
                    Console.WriteLine(string.Format(errorMessage, "Height", height));
                }

                return -1;
            }

            return weight / (height * height);
        }

        public static float PromptForFloat(string message)
        {
            var invC = CultureInfo.InvariantCulture;

            Console.WriteLine(message);
            string input = Console.ReadLine();
            bool isNumber = float.TryParse(input, NumberStyles.Float, invC, out float number);
            
            if (!isNumber && !string.IsNullOrEmpty(input))
            {
                Console.Write($"\"{input}\" is not a valid number.");
                return -1;
            }

            return number;
        }

        public static string PromptForString(string message)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.Write("Name cannot be empty.");
                return "-";
            }

            return input;
        }

        public static int PromptForInt(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            bool isNumber = int.TryParse(input, out int number);

            if (!isNumber && !string.IsNullOrEmpty(input))
            {
                Console.Write($"\"{input}\" is not a valid number.");
                return -1;
            }

            return number;
        }
    }
}
