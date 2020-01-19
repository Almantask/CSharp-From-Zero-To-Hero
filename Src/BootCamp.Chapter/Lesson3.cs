using System;
using System.Globalization;

namespace BootCamp.Chapter
{
    public class Lesson3
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

                Console.WriteLine($"{name}  {surname}  is {age} years old, his weight is {weight} kg and his height is {height:F2} cm.");
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
            return weight / (float)Math.Pow(height, 2);
        }

        public static string GetString(string message)
        {
            Console.Write(message);
            var input = Console.ReadLine();
            return input;
        }

        public static int GetInt(string message)
        {
            Console.Write(message);
            var input = int.Parse(Console.ReadLine());
            return input;
        }

        public static float GetFloat(string message)
        {
            Console.Write(message);
            var input = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            return input;
        }

    }
}