using System;
using System.Globalization;

namespace BootCamp.Chapter
{
    class Lesson4
    {
        public static void Demo()
        {
            PromptPersonData();
            PromptPersonData();
        }

        private static void PromptPersonData()
        {
            // input
            string firstName = PromptString("Enter first name: ");
            string lastName = PromptString("Enter last name: ");
            int age = PromptInt("Enter age: ");
            float weight = PromptFloat("Enter weight: ");
            float height = PromptFloat("Enter height: ");

            // output
            PrintPersonDataAndCalculateBmi(firstName, lastName, age, weight, height);
        }

        private static void PrintPersonDataAndCalculateBmi(string firstName, string lastName, int age, float weight, float height)
        {
            Console.WriteLine(firstName + " " + lastName + " is " + age + " years old, his/her weight is " + weight + " kg and his/her height is " + height + " cm.");
            float bmi = CalculateBmi(weight, height / 100);
            Console.WriteLine(firstName + " " + lastName + "'s BMI: " + Math.Round(bmi, 2));
        }

        public static float CalculateBmi(float weightKg, float heightM)
        {
            if (weightKg <= 0 || heightM <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                if (weightKg <= 0 && heightM <= 0)
                {
                    Console.WriteLine("Weight cannot be equal or less than zero, but was " + weightKg + ".");
                    Console.WriteLine("Height cannot be less than zero, but was " + heightM + ".");
                } else {
                    if (heightM <= 0)
                    {
                        Console.WriteLine("Height cannot be equal or less than zero, but was " + heightM + ".");
                    }
                    if (weightKg <= 0)
                    {
                        Console.WriteLine("Weight cannot be equal or less than zero, but was " + weightKg + ".");
                    }
                }
                return -1;
            }
            return weightKg / heightM / heightM;
        }

        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            return ValidateString(Console.ReadLine());
        }

        private static string ValidateString(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                Console.Write("Name cannot be empty.");
                return "-";
            }
            return input;
        }

        public static int PromptInt(string message)
        {
            Console.WriteLine(message);
            return ValidateInt(Console.ReadLine());
        }

        private static int ValidateInt(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }
            var isNumber = int.TryParse(input, out var value);
            if (!isNumber)
            {
                Console.Write("\"" + input + "\" is not a valid number.");
                return -1;
            }
            return value;
        }

        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            return ValidateFloat(Console.ReadLine());
        }

        private static float ValidateFloat(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }
            var isNumber = float.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out var value);
            if (!isNumber)
            {
                Console.Write("\"" + input + "\" is not a valid number.");
                return -1;
            }
            return value;
        }
    }
}
