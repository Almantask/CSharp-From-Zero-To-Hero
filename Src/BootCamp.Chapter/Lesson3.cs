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
            var doAnotherPerson = true;
            while (doAnotherPerson)
            {
                var firstName = PromptString("First Name: ");
                var surname = PromptString("Surname: ");
                var age = PromptInt("Age: ");
                var weight = PromptFloat("Weight in kilograms: ");
                var height = PromptFloat("Height in meters: ");
                var bmi = CalculateBmi(weight, height);

                Console.WriteLine($"{firstName} {surname} is {age} years old, his weight is {weight} kg and his height is {height} meters.\n" +
                    $"Body-mass index (BMI) is: {bmi.ToString("0.00")}");

                var answer = PromptString("\nDo you want to check BMI for another person? y/n: ").ToLowerInvariant();
                doAnotherPerson = answer.Equals("y") || answer.Equals("yes");
            }
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
            return float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture.NumberFormat);
        }
        public static float CalculateBmi(float weight, float height)
        {
            return weight / height / height;
        }
    }
}
