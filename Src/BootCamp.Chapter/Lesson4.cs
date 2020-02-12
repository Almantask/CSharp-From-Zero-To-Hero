using System;
namespace BootCamp.Chapter
{
    class Lesson4
    {
        public static void Demo()
        {
            string decision;
            do
            {
                Console.Clear();
                decision = AddNewPerson();

            } while (decision == "Y");
        }

        public static string AddNewPerson()
        {
            string name = PromptNameString("What is your name?");
            float age = PromptInt("How old are you?");
            float weight = PromptFloat("What is your weight (in kg)?");
            float height = PromptFloat("What is your height (in cm)?");

            Console.WriteLine($"{name} is {age} years old, his weight is {weight} kg and his height is {height} cm.");

            float heightInMeters = height / 100;
            float bmi = CalculateBmi(weight, heightInMeters);
            Console.WriteLine($"His/her BMI = {bmi:N}");

            Console.WriteLine("Do you want to add another person (Y/y = Yes, everything else = No)?");
            string decision = Console.ReadLine();
            string decisionToUpper = decision.ToUpperInvariant();

            return decisionToUpper;
        }

        public static string PromptNameString(string message)
        {
            Console.WriteLine(message);

            string name = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(name))
            {
                Console.Write("Name cannot be empty.");
                return "-";
            }
            else
            {
                return name;
            }
        }

        public static float CalculateBmi(float weight, float height)
        {
            bool isValidHeightAndWeight = height > 0 && weight > 0;
            const string heightError = "Height cannot be equal or less than zero, but was ";
            const string heightErrorForNegative = "Height cannot be less than zero, but was ";
            const string weightError = "Weight cannot be equal or less than zero, but was ";
            if (isValidHeightAndWeight)
            {
                return weight / (float)Math.Pow(height, 2);
            }
            else
            {
                if (height <= 0 && weight <= 0)
                {
                    DisplayErrorBmi($"{weightError}{weight}.{Environment.NewLine}{heightErrorForNegative}{height}.");
                }
                else if (height <= 0)
                {
                    DisplayErrorBmi($"{heightError}{height}.");
                }
                else
                {
                    DisplayErrorBmi($"{weightError}{weight}.");
                }
                return -1;
            }
        }

        public static void DisplayErrorBmi(string message)
        {
            Console.WriteLine($"Failed calculating BMI. Reason:{Environment.NewLine}{message}");
        }

        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);

            string input = Console.ReadLine();

            if (IsValidFloat(input))
            {
                return float.Parse(input);
            }
            else if (String.IsNullOrEmpty(input))
            {
                return 0;
            }
            else
            {
                return DisplayError(input);
            }
        }

        public static int PromptInt(string message)
        {
            Console.WriteLine(message);

            string input = Console.ReadLine();

            if (IsValidInt(input))
            {
                return int.Parse(input);
            }
            else if (String.IsNullOrEmpty(input))
            {
                return 0;
            }
            else
            {
                return DisplayError(input);
            }
        }

        public static int DisplayError(string input)
        {
            Console.Write($"\"{input}\" is not a valid number.");
            return -1;
        }

        public static bool IsValidFloat(string input)
        {
            bool isValidNumber = float.TryParse(input, out float number) && (number > 0);
            return isValidNumber;
        }
        public static bool IsValidInt(string input)
        {
            bool isValidNumber = int.TryParse(input, out int number) && (number > 0);
            return isValidNumber;
        }
    }
}
