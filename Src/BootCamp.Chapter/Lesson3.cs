using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            ProcessPersonInfo();
            ProcessPersonInfo();
        }

        public static void ProcessPersonInfo()
        {
            string name = PromptString("Name: ");
            int age = PromptInt("Age: ");
            float weight = PromptFloat("Weight in kg: ");
            float height = PromptFloat("Height in metres: ");
            float bmi = CalculateBMI(weight, height);

            Console.WriteLine(name + " is " + age + " years old, their weight is " + weight + " kg and their height is " + height + " m.");
            Console.WriteLine(name + "'s BMI is " + bmi);
        }

        public static string PromptString(string message)
        {
            Console.Write(message);
            var input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Name cannot be empty.");
                return "-";
            }
            return input;
        }

        public static int PromptInt(string message)
        {
            Console.Write(message);
            var input = Console.ReadLine();
            bool isNumber = int.TryParse(input, out var age);

            if (!isNumber)
            {
                Console.WriteLine($"{input} is not a valid number.");
                return -1;
            }

            if (age == 0)
            {
                Console.WriteLine($"{input} is a number but 0.");
                return 0;
            }

            return Convert.ToInt32(age);
        }

        public static float PromptFloat(string message)
        {
            Console.Write(message);
            return float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);
        }

        public static float CalculateBMI(float weight, float height)
        {
            float bmi = weight / (height * height);
            return bmi;
        }
    }
}
