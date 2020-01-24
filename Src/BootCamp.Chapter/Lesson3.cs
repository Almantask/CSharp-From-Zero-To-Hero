using System;
using Console = System.Console;

namespace BootCamp.Chapter
{
    public class Lesson3
    {
        public static void Demo()
        {
            Console.WriteLine("Please enter your data" + Environment.NewLine);
            do
            {
                var name = PromptString("What is your first name?");
                var surname = PromptString("What is your last name?");
                var age = PromptInt("What is your age");
                var weight = PromptFloat("What is your weight in kilograms");
                var heightCm = PromptFloat("What is your height in centimeters");
                var bmi = CalculateBmi(weight, heightCm / 100);

                Console.WriteLine();
                Console.WriteLine("Name: " + name + " " + surname);
                Console.WriteLine("Age: " + age);
                Console.WriteLine("Weight: " + weight + "kg");
                Console.WriteLine("Height: " + heightCm / 100 + "m");
                Console.WriteLine("BMI: " + bmi);


                Console.WriteLine(Environment.NewLine + "Continue with a new set of inputs? " +
                "Press Y to continue or press any other button to exit the program" + Environment.NewLine);

                string answer = Console.ReadLine().ToLowerInvariant();
                if (answer == "y")
                {
                    Console.WriteLine(Environment.NewLine + "Please enter your data" + Environment.NewLine);
                }
                else
                {
                    Console.WriteLine(Environment.NewLine + "Thank you. Good Bye");
                    break;
                }
            }
            while (true);

        }

        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public static int PromptInt(string message)
        {
            Console.WriteLine(message);
            return int.Parse(Console.ReadLine());
        }

        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            return float.Parse(Console.ReadLine());
        }

        public static float CalculateBmi(float weight, float height)
        {
            return weight / (height * height);

        }
    }
}

