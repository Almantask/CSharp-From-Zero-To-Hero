using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            int numberOfIndividuals = PromptInt("Please enter the number of individuals you would like to calculate the BMI of: ");
            while (numberOfIndividuals != 0)
            {
                PromptForPersonalData();

                numberOfIndividuals--;
            }
        }

        static void PromptForPersonalData()
        {
            string firstName = PromptString("Please enter the individual's first name: ");
            string lastName = PromptString("Please enter the individual's last name: ");
            int age = PromptInt("Please enter the individual's age: ");
            float weight = PromptFloat("Please enter the individual's weight (in kg): ");
            float height = PromptFloat("Please enter the individual's height (in meters, example: 1.8): ");
            float bodyMassIndex = CalculateBMI(height, weight);

            Console.WriteLine($"{firstName} {lastName} is {age} years old, their weight is {weight} kg and their height is {height} m.");
            Console.WriteLine($"{firstName} {lastName}'s BMI is: {bodyMassIndex}");
        }

        public static string PromptString(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        public static int PromptInt(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        public static float PromptFloat(string message)
        {
            Console.Write(message);
            return float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        public static float CalculateBMI(float height, float weight)
        {
            float bodyMassIndex = weight / (MathF.Pow(height, 2.0f)); //BMI equals to kg/m2 hence the number 2
            return bodyMassIndex;
        }
    }
}
