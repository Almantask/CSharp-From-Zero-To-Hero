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
                var surname = Lesson4.PromptString("Please enter your surname: ");
                var age = Lesson4.PromptInt("Please enter your age: ");
                var weight = Lesson4.PromptFloat("Please enter your weight (in kg): ");
                var height = Lesson4.PromptFloat("Please enter your height (in m): ");
                Console.WriteLine(surname + " is " + age + " " + "years old, his weight is " + weight + "kg and his height is " + height + "m.");

                var Bmi = Lesson4.CalculateBmi(weight, height);
                Console.WriteLine("Your estimated BMI is " + Bmi);
            }
        }

        public static string PromptString(string message)
        {
            Console.Write(message);
            var input = Console.ReadLine();
            var userName = validateString(input);
            if (userName == "-")
            {
                Console.WriteLine("Name cannot be empty.");
            }
            return userName;
        }

        public static string validateString(string input)
        {
            if (String.IsNullOrEmpty(input))
            {
                return "-";
            }
            return input;
        }

        public static int PromptInt(string message)
        {
            Console.Write(message);
            var input = Console.ReadLine();
            if (String.IsNullOrEmpty(input)) return 0;
            var isNumber = int.TryParse(input, out var age);
            if (!isNumber)
            {
                Console.WriteLine($"\"{age}\" is not a valid number.");
                return -1;
            }
            if (age > 200 || age <= 0)
            {
                Console.WriteLine($"\"{age}\" is not a valid number.");
                return -1;
            }
            return age;
        }
        public static float PromptFloat(string message)
        {
            Console.Write(message);
            var input = (Console.ReadLine());
            if (String.IsNullOrEmpty(input)) return 0;
            var isFloat = float.TryParse(input, out var heightWeight);
            if (!isFloat)
            {
                Console.WriteLine($"\"{heightWeight}\" is not a valid number.");
                return -1;
            }
            if (heightWeight > 200 || heightWeight <= 0)
            {
                Console.WriteLine($"\"{heightWeight}\" is not a valid number.");
                return -1;
            }
            return heightWeight;
        }
        public static float CalculateBmi(float weight, float height)
        {
            var weightInt = Convert.ToInt32(weight);
            var heightInt = Convert.ToInt32(height);
            var errorString = "Failed calculating BMI.Reason: ";
            var errorWeight = "Weight cannot be equal or less than zero, but was ";
            var errorHeight = "Weight cannot be equal or less than zero, but was ";
            if (weightInt <= 0 && heightInt <= 0)
            {
                Console.WriteLine(errorString);
                Console.WriteLine(errorWeight + weightInt);
                Console.WriteLine(errorHeight + heightInt);
                return -1;
            }
            if (weightInt <= 0)
            {
                Console.WriteLine(errorString);
                Console.WriteLine(errorWeight + weightInt);
                return -1;
            }
            if (heightInt <= 0)
            {
                Console.WriteLine(errorString);
                Console.WriteLine(errorHeight + heightInt);
                return -1;
            }

            var Bmi = weight / (float)Math.Pow(height, 2);
            return Bmi;
        }
    }
}
