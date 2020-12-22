
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            string name = PromptString("Name: ");
            string surName = PromptString("Surname: ");
            int age = PromptInt("Age: ");
            float weight = PromptFloat("Weight(Kg): ");
            float height = PromptFloat("Height(m): ");

            float heightM = ConvertToMeters(height);
            float yourBMI = CalculateBMI(heightM, weight);

            Console.Write("\n");
            Console.WriteLine($"{name} {surName} you are {age} years old, your weight is {weight} Kg and your height is {height} cm\n");

            Console.WriteLine("Your Body Mass Index (BMI) is: " + yourBMI);
            Console.Write("\n");
        }

        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public static int PromptInt(string message)
        {
            Console.WriteLine(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            return float.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
        }

        public static float ConvertToMeters(float height)
        {
            return height / 1.0f;
        }

        public static float CalculateBMI(float height, float weight)
        {
            return weight / (height * height);
        }
    }
}
