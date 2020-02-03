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
            string firstName = ParseString("Enter first name: ");
            string lastName = ParseString("Enter last name: ");
            int age = ParseInt("Enter age: ");
            float weight = ParseFloat("Enter weight: ");
            float height = ParseFloat("Enter height: ");

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
            return weightKg / heightM / heightM;
        }

        public static string ParseString(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            var value = ValidateString(input);
            if (value.Equals("-"))
                Console.WriteLine("Name cannot be empty.");
            return value;
        }

        private static string ValidateString(string input)
        {
            if (string.IsNullOrEmpty(input)) return "-";
            return input;
        }

        public static int ParseInt(string message)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();
            var value = ValidateInt(input);
            if (value.Equals(-1))
                Console.WriteLine("\"" + value + "\" is not a valid number.");
            return value;
        }

        private static int ValidateInt(string input)
        {
            if (string.IsNullOrEmpty(input)) return 0;
            var isNumber = int.TryParse(input, out var value);
            if (!isNumber) return -1;
            return value;
        }

        public static float ParseFloat(string message)
        {
            Console.WriteLine(message);
            return float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        private static bool isValidName(string name)
        {
            if (name.Equals("-")) return false;
            return true;
        }

        private static int isValidWeightOrHeight(float value)
        {
            if (value <= 0) return -1;
            return 1;
        }
    }
}
