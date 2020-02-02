using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Console = System.Console;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // input person 1
            string firstName = PromptString("first name");
            string lastName = PromptString("last name");
            int age = PromptInt("age");
            float weight = PromptFloat("weight");
            float height = PromptFloat("height");

            // introduce person 1
            Console.WriteLine(firstName + " " + lastName + " is " + age + " years old, his/her weight is "
                            + weight + " kg and his/her height is " + height + " cm.");

            // calculate BMI person 1
            double heightInMeters = height / 100.0;
            double bmi = weight / (heightInMeters * heightInMeters);

            Console.WriteLine("BMI: " + Math.Round(bmi, 2));



            // input person 2
            firstName = PromptString("first name");
            lastName = PromptString("last name");
            age = PromptInt("age");
            weight = PromptFloat("weight");
            height = PromptFloat("height");

            // introduce person 2
            Console.WriteLine(firstName + " " + lastName + " is " + age + " years old, his/her weight is "
                            + weight + " kg and his/her height is " + height + " cm.");

            // calculate BMI person 2
            heightInMeters = height / 100.0;
            bmi = weight / (heightInMeters * heightInMeters);

            Console.WriteLine("BMI: " + Math.Round(bmi, 2));
        }

        private static string PromptString(string message)
        {
            Console.Write("Enter " + message + ": ");
            string value = Console.ReadLine();
            return value;
        }

        private static int PromptInt(string message)
        {
            Console.Write("Enter " + message + ": ");
            int value = Int32.Parse(Console.ReadLine());
            return value;
        }

        private static float PromptFloat(string message)
        {
            Console.Write("Enter " + message + ": ");
            float value = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            return value;
        }
    }
}
