using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            for (int i = 0; i < 2; i++)
            {
                string name = PrintAndReadString("First Name: ");

                string sureName = PrintAndReadString("Last Name: ");

                int age = PrintAndReadInt("Age: "); ;

                float weight = PrintAndReadFloat("Weight: ");

                float height = PrintAndReadFloat("Height: ");

                var bmi = BMICalc(weight, height);

                Console.WriteLine($"{name} {sureName} is {age} years old, his weight is {weight} kg and his height is {height} cm.");

                Console.WriteLine($"Your BMI - {bmi:N2}");
            }
        }

        public static float BMICalc(float weight, float height)
        {
            return weight / (height * height);
        }

        public static string PrintAndReadString(string message)
        {
            Console.WriteLine(message);
            string stringVar = Console.ReadLine();
            return stringVar;
        }

        public static float PrintAndReadFloat(string message)
        {
            Console.WriteLine(message);
            float floatVar = float.Parse(Console.ReadLine());
            return floatVar;
        }

        public static int PrintAndReadInt(string message)
        {
            Console.WriteLine(message);
            int intVar = int.Parse(Console.ReadLine());
            return intVar;
        }

    }
}

