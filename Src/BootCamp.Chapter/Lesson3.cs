using System;
using System.Globalization;
using System.Text;

namespace BootCamp.Chapter
{
    public class Lesson3
    {
        public static void Demo()
        {
            const int maxEntries = 2;

            for (int i = 1; i <= maxEntries; i++)
            {
                Console.Clear();

                RegisterNewPersonData(i);

                PromptNewPerson(i);
            }
        }

        private static string WriteNewLine(int count)
        {
            StringBuilder newLines = new StringBuilder(Environment.NewLine);

            for (int i = 1; i < count; i++)
            {
                newLines.Append(Environment.NewLine);
            }

            return newLines.ToString();
        }

        static void RegisterNewPersonData(int entry)
        {
            Console.WriteLine($"Enter the following information for person #{entry}.");

            string firstName = RegisterStringValue("Firstname: ");
            string lastName = RegisterStringValue("Lastname: ");

            int age = RegisterIntValue("Age:");

            float weight = RegisterFloatValue("Weight in kilograms:");
            float height = RegisterFloatValue("Height in meters:");

            var bmi = CalculateBmi(weight, height);

            Summarize(firstName, lastName, age, weight, height, bmi);
        }

        public static string RegisterStringValue(string message)
        {
            Console.Write($"{message}{WriteNewLine(1)}");

            string stringValue = Console.ReadLine();

            if (string.IsNullOrEmpty(stringValue))
            {
                Console.Write($"Name cannot be empty.");
                return "-";
            }

            return stringValue;
        }

        public static int RegisterIntValue(string message)
        {
            Console.Write($"{message}{WriteNewLine(1)}");

            string userInput = Console.ReadLine();

            if (string.IsNullOrEmpty(userInput))
            {
                return 0;
            }

            if (!int.TryParse(userInput, out int intValue))
            {
                Console.Write($"\"{userInput}\" is not a valid number.");
                return -1;
            }

            return intValue;
        }

        public static float RegisterFloatValue(string message)
        {
            Console.Write($"{message}");
            
            string userInput = Console.ReadLine();

            if (string.IsNullOrEmpty(userInput))
            {
                Console.WriteLine();
                return 0;
            }

            if (!float.TryParse(userInput, NumberStyles.Any, CultureInfo.InvariantCulture, out float floatValue))
            {
                Console.Write($"{WriteNewLine(1)}\"{userInput}\" is not a valid number.");
                return -1;
            }

            Console.WriteLine();

            return floatValue;
        }

        public static void Summarize(string firstName, string lastName, int age, float weight, float height, float bmi)
        {
            Console.WriteLine($"{WriteNewLine(1)}{firstName} {lastName} is {age} years old and his weight is {weight} and his height is {height} \n \n");

            Console.WriteLine($"He/she has a BMI of {bmi} {WriteNewLine(3)}");
        }

        public static void PromptNewPerson(int entry)
        {
            Console.WriteLine(entry < 2
                ? "Press any key to register another person, press n to exit."
                : "Maximum entries reached. Press any key to exit the program");

            ConsoleKey userInputKey = Console.ReadKey(true).Key;

            if (userInputKey == ConsoleKey.N)
            {
                Environment.Exit(0);
            }
        }

        public static float CalculateBmi(float weight, float height)
        {
            var calculatedBmi = weight / (height * height);

            if (height <= 0 && weight <= 0)
            {
                Console.WriteLine($"Failed calculating BMI. Reason:");
                Console.WriteLine($"Weight cannot be equal or less than zero, but was {weight}.");
                Console.WriteLine($"Height cannot be less than zero, but was {height}.");

                return -1;
            }

            if (height <= 0 || weight <= 0)
            {
                Console.WriteLine($"Failed calculating BMI. Reason:");

                if (height <= 0)
                {
                    Console.WriteLine($"Height cannot be equal or less than zero, but was {height}.");
                }

                if (weight <= 0)
                {
                    Console.WriteLine($"Weight cannot be equal or less than zero, but was {weight}.");
                }

                return -1;
            }

            return calculatedBmi;
        }
    }
}