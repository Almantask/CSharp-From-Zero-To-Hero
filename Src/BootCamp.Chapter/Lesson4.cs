using System;
using System.Globalization;

namespace BootCamp.Chapter
{
    public class Lesson4
    {
        public static void Demo()
        {
            for (int i = 0; i < 2; i++)
            {
                var name = GetString("What is your name: ");
                var surname = GetString("What is your surname: ");
                var age = GetInt("What is your age: ");


                var weight = GetFloat("What is your weight in kilogram: ");
                var height = GetFloat("What is your height in metres: ");
                var bmi = GetBmi(weight, height);

                Console.Write($"{name}  {surname}  is {age} years old, his weight is {weight} kg and his height is {height:F2} cm.");
                Console.WriteLine($"His BMI is:  {bmi:N2}");
                Console.WriteLine("");
                if (i == 0)
                {
                    Console.WriteLine($"Now for another person {Environment.NewLine}  ");
                }
            }
        }

        public static float GetBmi(float weight, float height)
        {
            if (height <= 0 || weight <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");

                if (height <= 0 && weight <= 0)
                {
                    Console.WriteLine($"Weight cannot be equal or less than zero, but was 0.{Environment.NewLine}Height cannot be less than zero, but was 0.");
                }
                else if (height <= 0)
                {
                    Console.WriteLine($"Height cannot be equal or less than zero, but was {height}.");
                }
                else if (weight <= 0)
                {
                    Console.WriteLine($"Weight cannot be equal or less than zero, but was {weight}.");
                }

                return -1; 
            }
            


            return weight / (float)Math.Pow(height, 2);
        }

        public static string GetString(string message)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();
            var validated = ValidateString(input); 
            if (validated == "-")
            {
                Console.Write($"Name cannot be empty."); 
            }

            return validated;
        }

        public static string ValidateString(string input)
        {
            if (String.IsNullOrEmpty(input))
            {
                return "-";
            }

            return input; 
             
        }

        public static int GetInt(string message)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();
            var validated = ValidateInt(input);
            if (validated == -1)
            {
                DisplayErrorMessageForNumbers(input);
            }

            return validated;
        }

        public static void DisplayErrorMessageForNumbers(string input)
        {
            Console.Write($"\"{input}\" is not a valid number.");
        }

        private static int ValidateInt(string input)
        {
            if (String.IsNullOrEmpty(input))
            {
                return 0;
            }

            var isValid = int.TryParse(input, out int number);

            if (isValid)
            {
                return number;
            }

            return -1;
        }

        public static float GetFloat(string message)
        {
            Console.WriteLine(message);
            var input = Console.ReadLine();
            var validated = ValidateFloat(input);
            if (Math.Abs(validated - -1) <= 0.001)
            {
                DisplayErrorMessageForNumbers(input);
            }

            return validated;
        }

        private static float ValidateFloat(string input)
        {
            if (String.IsNullOrEmpty(input))
            {
                return 0;
            }

            var isValid = float.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture,  out float number);

            if (isValid)
            {
                return number;
            }

            return -1;
        }

    }
}