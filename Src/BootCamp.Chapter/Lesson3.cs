using System;
using System.Globalization;

namespace BootCamp.Chapter
{
    public class Lesson3
    {
        public static void Demo()
        {
            const int maxEntries = 2;

            for (int i = 1; i <= maxEntries; i++)
            {
                Console.Clear();

                RegisterNewPersonData(i);

                PromptNewPerson(i);
            }
        }

        static void RegisterNewPersonData(int entry)
        {
            Console.WriteLine($"Enter the following information for person #{entry}.");

            string firstName = RegisterStringValue("Firstname: ");
            string lastName = RegisterStringValue("Lastname: ");

            int age = RegisterIntValue("Age:");

            float weight = RegisterFloatValue("Weight in kilograms:");
            float height = RegisterFloatValue("Height in meters:");

            var bmi = CalculateBmi(weight, height);

            Summarize(firstName, lastName, age, weight, height, bmi);
        }

        public static string RegisterStringValue(string message)
        {
            Console.Write(message);

            return Console.ReadLine();
        }

        public static int RegisterIntValue(string message)
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

        public static float CalculateBmi(float weight, float height)
        {
            return weight / (height * height);
        }
    }
}
