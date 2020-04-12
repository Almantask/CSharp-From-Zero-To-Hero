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

            // Get Info from user
            string name = PromptString("First name: ");
            string surname = PromptString("Surname: ");
            int age = PromptInt("Age: ");
            float weight = PromptFloat("Weight(Kg): ");
            float height = PromptFloat("Height(cm): ");

            // Convert height(Cm) to Meter
            float heightM = height / 100;

            // Calculate BMI
            float bmi = CalculateBmi(weight, heightM);

            // Print Info on console
            Console.WriteLine($"{name} {surname} is {age} year old, his weight is {weight} kg and his height is {height} cm.\n" +
                    $"BMI: {bmi}");

            // Ask if user want to do the test again
            Console.WriteLine("Would you like to try again?");
            string response = Console.ReadLine();
            if (response.ToLower() == "yes" || response.ToLower() == "y")
            {
                Console.Clear();
                Demo();
            }
        }

        public static float CalculateBmi(float weight, float height)
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
