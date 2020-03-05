using System;
using System.Globalization;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            const int personCount = 2;

            for (int i = 0; i < personCount; i++)
            {
                ProcessBmi();
            }

            Console.ReadKey();
        }

        public static void ProcessBmi()
        {
            string firstName = PromptString("Input your first name: ");
            string lastName = PromptString("Input your last name: ");
            int age = PromptInt("Input your age: ");
            float height = PromptFloat("Input your height in m: ");
            float weight = PromptFloat("Input your weight in kg: ");
            float bmi = CalculateBmi(weight, height);

            if (Math.Abs(bmi - (-1)) < 0.01)
            {
                return;
            }
            Console.WriteLine($"{firstName} {lastName} is {age} years old, with a weight of {weight} kg and a height of {height} cm.\nCalculated BMI is {bmi}");
            Console.WriteLine();
        }
        public static int PromptInt(string message)
        {
            Console.Write(message);

            if (!int.TryParse(Console.ReadLine(), out int result))
            {
                return -1;
            }

            if (result <= 0)
            {
                return 0;
            }

            return result;
        }

        public static float PromptFloat(string message)
        {
            Console.Write(message);

            var style = NumberStyles.Float;
            var culture = CultureInfo.InvariantCulture;
            if (!float.TryParse(Console.ReadLine(), style, culture , out float result))
            {
                return -1;
            }

            if (Math.Abs(result) < 0.01)
            {
                return 0;
            }

            return result;
        }

        public static string PromptString(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                input = "-";
                Console.WriteLine("Name cannot be empty.");
                input = PromptString(message);
            }

            return input;
        }

        public static float CalculateBmi(float weight, float height)
        {
            bool weightError = false;
            bool heightError = false;

            if (weight <= 0)
            {
                weightError = true;
            }

            if (height <= 0)
            {
                heightError = true;
            }

            if (!weightError && !heightError) return (weight / (height * height));
            
            PrintErrorMessage(weightError, heightError, weight, height);
            
            return -1;

        }

        public static void PrintErrorMessage(bool weightError, bool heightError, float weight, float height)
        {
            string message = "Failed calculating BMI. Reason:\n";
            
            if (heightError)
            {
                message += "Height cannot be";

                if (!weightError)
                {
                    message += " equal or ";
                }

                message += $"less than zero, but was {height}.";
            }

            if (weightError)
            {
                if (heightError)
                {
                    message += "\n";
                }

                message += $"Weight cannot be equal to or less than zero, but was {weight}.";
            }

            Console.WriteLine($"{message}\n");
        }
    }
}
