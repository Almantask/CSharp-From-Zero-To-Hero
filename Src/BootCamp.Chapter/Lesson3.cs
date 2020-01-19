using System;
using System.Globalization;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static int ConvertStringToInt(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        public static string ConvertStringToString(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        public static float ConvertStringToFloat(string message)
        {
            Console.Write(message);
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
                string name = ConvertStringToString("Name: ");
                string sureName = ConvertStringToString("Surename: ");
                int age = ConvertStringToInt("Age: ");
                float weight = ConvertStringToFloat("Weight: ");
                float height = ConvertStringToFloat("Height: ");

                Console.WriteLine($"{name} {sureName} is {age} old, his weight is {weight}kg and his heigth is {height}m");

                Console.WriteLine($"{sureName} {name}'s BMI is {Bmi(weight, height)}\n");

                Console.WriteLine("press ENTER to continue...\n");
                Console.ReadLine();
                currentPerson++;
            }
        }
    }
}
