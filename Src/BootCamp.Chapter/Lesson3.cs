using System;
using System.Globalization;

namespace BootCamp.Chapter
{
    public static class Lesson3
    {
        public static int PromptInt(string message)
        {
            Console.WriteLine(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            return float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        public static float Bmi(float weight, float heigth)
        {
            return weight / (float)Math.Pow(heigth, 2);
        }

        public static void Demo(int numberOfPersons = 1)
        {
            int currentPerson = 0;

            while (currentPerson < numberOfPersons)
            {
                string name = PromptString("Name: ");
                string sureName = PromptString("Surename: ");
                int age = PromptInt("Age: ");
                float weight = PromptFloat("Weight: ");
                float height = PromptFloat("Height: ");

                Console.WriteLine($"{name} {sureName} is {age} old, his weight is {weight}kg and his heigth is {height}m");

                Console.WriteLine($"{sureName} {name}'s BMI is {Bmi(weight, height)}\n");

                Console.WriteLine("press ENTER to continue...\n");
                Console.ReadLine();
                currentPerson++;
            }
        }
    }
}
