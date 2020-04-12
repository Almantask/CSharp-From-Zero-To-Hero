using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        internal static void Demo()
        {
            // Greetings
            Console.WriteLine("Hello! Im a BMI Calculator, to calculate I need some info.");

            string name = PromptString("First name: ");
            string surname = PromptString("Surname: ");
            int age = PromptInt("Age: ");
            float weight = PromptFloat("Weight(Kg): ");
            float height = PromptFloat("Height(cm): ");
            float heightM = height / 100;

            // Calculate BMI
            float bmi = CalculateBmi(heightM, weight);
            Console.WriteLine(bmi);

            Console.WriteLine($"{name} {surname} is {age} year old, his weight is {weight} kg and his height is {height} cm.\n" +
                    $"IBM: {bmi}");


        }

        public static float CalculateBmi(float height, float weight)
        {
            float bmi = weight / (height * height);
            return bmi;
        }

        public static float PromptFloat(string text)
        {
            Console.Write(text);
            return float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        public static int PromptInt(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());

        }

        public static string PromptString(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
    }
}
