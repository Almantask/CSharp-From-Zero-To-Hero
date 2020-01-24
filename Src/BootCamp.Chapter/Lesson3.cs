using System;
using System.Globalization;

namespace BootCamp.Chapter
{
    public static class Lesson3
    {
        private static bool IsNumeric(string s)
        {
            return double.TryParse(s, out _);
        }

        public static int PromptInt(string message)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(input))
            {
                return 0;
            }
            if (IsNumeric(input))
            {
                return Convert.ToInt32(input);
            }
            else
            {
                Console.Write($"\"{input}\" is not a valid number.");
                return -1;
            }
        }

        public static string PromptString(string message)
        {
            const string errorMessage = "Name cannot be empty.";
            const string invalid = "-";
            Console.WriteLine(message);
            var input = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(input))
            {
                Console.Write(errorMessage);
                return invalid;
            }
            else
            {
                return input;
            }
        }

        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(input))
            {
                return 0;
            }
            if (IsNumeric(input))
            {
                return float.Parse(input, CultureInfo.InvariantCulture);
            }
            else
            {
                Console.Write($"\"{input}\" is not a valid number.");
                return -1;
            }
        }

        public static float CalculateBmi(float weight, float heigth)
        {
            const string messageBmi = "Failed calculating BMI. Reason:";
            var messageWeight = $"Weight cannot be equal or less than zero, but was { weight }.";
            var messageHeight = $"Height cannot be equal or less than zero, but was { heigth }.";
            var messageHeightLessZero = $"Height cannot be less than zero, but was { heigth }.";

            if (weight <= 0 && heigth <= 0)
            {
                Console.WriteLine($"{messageBmi}{Environment.NewLine}{messageWeight}{Environment.NewLine}{messageHeightLessZero}");
                return -1;
            }
            else if (weight <= 0)
            {
                Console.WriteLine($"{messageBmi}{Environment.NewLine}{messageWeight}");
                return -1;
            }
            else if (heigth <= 0)
            {
                Console.WriteLine($"{messageBmi}{Environment.NewLine}{messageHeight}");
                return -1;
            }
            else if (heigth < 0)
            {
                Console.WriteLine($"{messageBmi}{Environment.NewLine}{messageHeightLessZero}");
                return -1;
            }
            else
            {
                return weight / (float)Math.Pow(heigth, 2);
            }
        }

        public static void Demo(int numberOfPersons = 1)
        {
            int currentPerson = 0;

            while (currentPerson < numberOfPersons)
            {
                string name = PromptString("Name: ");
                string sureName = PromptString("Surename: ");
                int age = PromptInt("Age: ");
                float weight = PromptFloat("Weight: ");
                float height = PromptFloat("Height: ");

                Console.WriteLine($"{name} {sureName} is {age} old, his weight is {weight}kg and his heigth is {height}m");

                Console.WriteLine($"{sureName} {name}'s BMI is {CalculateBmi(weight, height)}\n");

                Console.WriteLine("press ENTER to continue...\n");
                Console.ReadLine();
                currentPerson++;
            }
        }
    }
}