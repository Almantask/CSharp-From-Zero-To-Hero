using System;
using System.Globalization;

namespace BootCamp.Chapter
{
    public static class Lesson4
    {
        public const int EmptyNumberInput = 0;
        public const int InvalidNumberInput = -1;
        public const string EmptyName = "-";

        public static void Demo()
        {
            CalculatePersonBMI();
        }


        public static int PromptInt(string message)
        {
            if (PromptTryParse(message, out int parsingResult, out string input))
            {
                return CheckNumber(parsingResult);
            }
            else
            {
                return InvalidInput(input);
            }
        }

        public static float PromptFloat(string message)
        {
            if (PromptTryParse(message, out float parsingResult, out string input))
            {
                return CheckNumber(parsingResult);
            }
            else
            {
                return InvalidInput(input);
            }
        }

        public static string PromptString(string message)
        {
            return CheckName(PromptInput(message));
        }

        public static float CalculateBMI(float weightInKg, float heightInM)
        {
            string errorMessage = "Failed calculating BMI. Reason:";

            bool isInvalidWeight = IsLessOrEqualZero(weightInKg, "Weight", ref errorMessage);
            bool isInvalidHeight = IsLessOrEqualZero(heightInM, "Height", ref errorMessage, !isInvalidWeight);

            if (isInvalidWeight || isInvalidHeight)
            {
                Console.WriteLine(errorMessage);
                return InvalidNumberInput;
            }

            return weightInKg / heightInM / heightInM;
        }

        private static void CalculatePersonBMI()
        {
            string fullName = PromptString("Full name: ");
            int age = PromptInt("Age: ");
            float weightInKg = PromptFloat("Weight (kg): ");
            float heightInCm = PromptFloat("Height (cm): ");

            Console.WriteLine($"{fullName} is {age} years old, his weight is {weightInKg} kg and his height is {heightInCm} cm.");
            Console.WriteLine($"His BMI is {CalculateBMI(weightInKg, heightInCm / 100)}.");
        }

        private static bool PromptTryParse(string message, out int result, out string input)
        {
            input = PromptInput(message);
            return int.TryParse(input, out result);
        }

        private static bool PromptTryParse(string message, out float result, out string input)
        {
            input = PromptInput(message);
            return float.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out result);
        }

        private static string PromptInput(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        private static int InvalidInput(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return EmptyNumberInput;
            }
            else
            {
                return PrintInvalidNumber(input);
            }
        }

        private static int CheckNumber(int value)
        {
            if (value > 0)
            {
                return value;
            }
            else
            {
                return InvalidNumberInput;
            }
        }

        private static float CheckNumber(float value)
        {
            if (value > 0)
            {
                return value;
            }
            else
            {
                return InvalidNumberInput;
            }
        }


        private static string CheckName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                Console.Write("Name cannot be empty.");
                return EmptyName;
            }

            return name;
        }

        private static bool IsLessOrEqualZero(float value, string name, ref string errorMessage, bool printEqual = true)
        {
            string equal = printEqual ? "equal or " : "";
            string errorMessage2 = $"{name} cannot be {equal}less than zero, but was {value}.";

            if (value <= 0)
            {
                errorMessage += $"{Environment.NewLine}{errorMessage2}";
                return true;
            }

            return false;
        }

        private static int PrintInvalidNumber(string input)
        {
            Console.Write($"\"{input}\" is not a valid number.");
            return InvalidNumberInput;
        }
    }
}