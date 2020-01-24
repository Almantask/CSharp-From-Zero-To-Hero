using System;

namespace BootCamp.Chapter
{
    public static class Lesson4
    {
        public static void Demo()
        {
            WelcomePrompt();
            do
            {
                PromptUserForStats();

            } while (PromptCalculateNewBmi());
        }
        private static void WelcomePrompt()
        {
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|                              |");
            Console.WriteLine("|    Welcome to C# Bootcamp    |");
            Console.WriteLine("|        BMI Calculator        |");
            Console.WriteLine("|        Version 0.0.3         |");
            Console.WriteLine("|                              |");
            Console.WriteLine("+------------------------------+");
        }
        
        public static bool PromptCalculateNewBmi()
        {
            Console.WriteLine("Do you wish to calculate another person? Y/N ");
            string response = Console.ReadLine();
            return response.StartsWith("Y") || response.StartsWith("y");
        }

        public static void PromptUserForStats()
        {

            string name = PromptNameInput("What is your name?");
            int age = PromptAgeInput("How old are you? If I may ask");
            float weight = PromptFloatInput("What is your weight? In Kilograms please.");
            float height = PromptFloatInput("How tall are you? In Meters please.");

            bool isHeightAndWeightValid = ValidateHeightAndWeight(weight, height);

            if (isHeightAndWeightValid)
            {
                float calculatedBMI = GetBmi(weight, height);
                Console.WriteLine($"{name} is {age} years old, weight is {weight} kg with a height of {height} meters.");
                Console.WriteLine($"The calculated BMI  is: {calculatedBMI:F}");
            }
            else
            {
                Console.WriteLine("The values you provided were not valid.");
            }

        }

        // Validation Functions
        public static string PromptNameInput(string promptMessage)
        {
            Console.WriteLine(promptMessage);

            var name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.Write("Name cannot be empty.");
                return "-";
            }
            else
            {
                return name;
            }
        }
        
        public static int PromptAgeInput(string promptMessage)
        {
            Console.WriteLine(promptMessage);
            var age = Console.ReadLine();
            if (IsNumber(age) && IsPositive(float.Parse(age)))
            {
                return int.Parse(age);             
            }
            else if (string.IsNullOrEmpty(age))
            {
                return 0;
            }
            else
            {
                DisplayInvalidInputErrorMessage(age);
                return -1;
            }
        }

        public static float PromptFloatInput(string promptMessage)
        {
            Console.WriteLine(promptMessage);

            var value = Console.ReadLine();
            if (IsNumber(value) && IsPositive(float.Parse(value)))
            {
                return float.Parse(value);
            }
            else if(string.IsNullOrEmpty(value))
            {
                return 0;
            }
            else
            {
                DisplayInvalidInputErrorMessage(value);
                return -1;
            }
        }
       
        public static bool ValidateHeightAndWeight(float weight, float height)
        {
            bool isValidWeight = IsPositive(weight);
            bool isValidHeight = IsPositive(height);
            return ((isValidHeight && isValidWeight) && (weight > height));
        }

        public static float GetBmi(float weight, float height)
        {

            bool isHeightAndWeightValid = ValidateHeightAndWeight(weight, height);

            if (isHeightAndWeightValid)
            {
                return weight / MathF.Pow(height, 2);
            }
            else
            {
                if (!IsPositive(weight) && !IsPositive(height))
                {
                    DisplayErrorMessageForNumbers($"Weight cannot be equal or less than zero, but was {weight}.{Environment.NewLine}Height cannot be less than zero, but was {height}.");
                }
                else if (!IsPositive(height))
                {
                    DisplayErrorMessageForNumbers($"Height cannot be equal or less than zero, but was {height}.");
                }else if(weight >= height)
                {
                    DisplayErrorMessageForNumbers($"Weight cannot be more or equal to height.{Environment.NewLine} Height= {height}, Weight= {weight}.");
                }else
                {
                    DisplayErrorMessageForNumbers($"Weight cannot be equal or less than zero, but was {weight}.");
                }
                return -1;
            }
        }

        public static bool IsPositive(float number) {
           return number > 0;
        }
        
        public static bool IsNumber(string value) => float.TryParse(value, out _);

        public static void DisplayInvalidInputErrorMessage(string input)
        {
            Console.Write($"\"{input}\" is not a valid number.");
        }

        public static void DisplayErrorMessageForNumbers(string input)
        {
            Console.WriteLine($"Failed calculating BMI. Reason:{Environment.NewLine}{input}");
        }

        public static void DisplayErrorMessageForNumbers(string input1, string input2)
        {
            Console.WriteLine($"Failed calculating BMI. Reason:{Environment.NewLine}{input1}{input2}");
        }

    }
}