using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson4
    {
        private const string InvalidStringReturnValue = "-";
        private const int InvalidNumberReturnValue = -1;
        private const int EmptyNumberReturnValue = 0;
        public static void Demo()
        {
            int numberOfIndividuals = PromptInt("Please enter the number of individuals you would like to calculate the BMI of: ");
            while (numberOfIndividuals > 0)
            {
                PromptForPersonalData();

                numberOfIndividuals--;
            }
        }

        static void PromptForPersonalData()
        {
            string firstName = PromptString("Please enter the individual's first name: ");
            string lastName = PromptString("Please enter the individual's last name: ");
            int age = PromptInt("Please enter the individual's age: ");
            float weight = PromptFloat("Please enter the individual's weight (in kg, example: 70.5): ");
            float height = PromptFloat("Please enter the individual's height (in meters, example: 1.8): ");
            float bodyMassIndex = CalculateBMI(weight, height);

            Console.WriteLine($"{firstName} {lastName} is {age} years old, their weight is {weight} kg and their height is {height} m.");
            Console.WriteLine($"{firstName} {lastName}'s BMI is: {bodyMassIndex}");
        }


        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            return ValidateString(Console.ReadLine());
        }

        public static int PromptInt(string message)
        {
            Console.WriteLine(message);
            return ValidateInt(Console.ReadLine());
        }

        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            return ValidateFloat(Console.ReadLine());
        }

        public static float CalculateBMI(float weight, float height)
        {
            if (!IsValidBMI(weight, height))
            {
                return InvalidNumberReturnValue;
            }

            float bodyMassIndex = weight / (MathF.Pow(height, 2.0f)); //BMI equals to kg/m2 hence the number 2
            return bodyMassIndex;
        }

        static string ValidateString(string input)
        {
            if (String.IsNullOrWhiteSpace(input))
            {
                Console.Write("Name cannot be empty.");
                return InvalidStringReturnValue;
            }
            return input;
        }

        static int ValidateInt(string input)
        {
            if (String.IsNullOrWhiteSpace(input))
            {
                return EmptyNumberReturnValue;
            }

            bool isValidInt = int.TryParse(input, out int result);
            if (!isValidInt)
            {
                Console.Write("\"" + input + "\" is not a valid number.");
                return InvalidNumberReturnValue;
            }
            return result;
        }

        static float ValidateFloat(string input)
        {
            if (String.IsNullOrWhiteSpace(input))
            {
                return EmptyNumberReturnValue;
            }

            bool isValidFloat = float.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out float result);
            if (!isValidFloat)
            {
                Console.Write("\"" + input + "\" is not a valid number.");
                return InvalidNumberReturnValue;
            }
            return result;
        }

        static bool IsValidBMI(float weight, float height)
        {
            bool isValidBmi = weight > 0 && height > 0;
            if (isValidBmi)
            {
                return true;
            } else
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                if (weight <= 0 && height <= 0)
                {
                    Console.WriteLine("Weight cannot be equal or less than zero, but was {0}.", weight);
                    Console.WriteLine("Height cannot be less than zero, but was {0}.", height);
                }
                else
                {
                    if (weight <= 0)
                    {
                        Console.WriteLine("Weight cannot be equal or less than zero, but was {0}.", weight);
                    }
                    if (height <= 0)
                    {
                        Console.WriteLine("Height cannot be equal or less than zero, but was {0}.", height);
                    }
                }
                return false;
            }
        }
    }
}
