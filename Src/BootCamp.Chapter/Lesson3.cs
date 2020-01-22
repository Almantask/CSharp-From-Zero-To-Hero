using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BootCamp.Chapter
{
    public class Lesson3
    {
        public static void Demo()
        {
            const int maxEntries = 3;

            for (int i = 1; i < maxEntries; i++)
            {
                Console.Clear();

                RegisterNewPersonData(i);
            }
        }

        static void RegisterNewPersonData(int entry)
        {
            Console.WriteLine($"Enter the following information for person #{entry}.");

            string firstName = Checks.PromptString("Firstname: ");

            string lastName = Checks.PromptString("Lastname: ");

            int age = Checks.PromptInt("Age:");

            float weight = Checks.PromptFloat("Weight in kilograms:");

            float height = Checks.PromptFloat("Height in meters:");

            var bmi = Checks.CalculateBmi(weight, height);

            Summarize(firstName, lastName, age, weight, height, bmi);

            PromptNewPerson(entry);
        }

        public static string RegisterName(string message)
        {
            Console.Write(message);

            return Console.ReadLine();
        }

        public static int RegisterAge(string message)
        {
            Console.Write(message);

            return Convert.ToInt16(Console.ReadLine());
        }

        public static float RegisterFloatValue(string message)
        {
            Console.Write(message);

            return float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat); 
        }

        public static void Summarize(string firstName, string lastName, int age, float weight, float height, float bmi)
        {
            Console.WriteLine($"\n{firstName} {lastName} is {age} years old and his weight is {weight} and his height is {height} \n \n");

            Console.WriteLine($"He/she has a BMI of {bmi} \n \n \n");
        }

        public static void PromptNewPerson(int entry)
        {
            Console.WriteLine(entry < 2
                ? "Press any key to register another person, press n to exit."
                : "Maximum entries reached. Press any key to exit the program");

            ConsoleKey userInputKey = Console.ReadKey(true).Key;

            if (userInputKey == ConsoleKey.N)
            {
                Environment.Exit(0);
            }
        }
    }
}
