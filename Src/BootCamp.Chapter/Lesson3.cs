using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            int i = 0;

            while (i < 2)
            {
                Console.Clear();

                string name = InputString("What's your name?");

                string surname = InputString("What's your surname?");

                int age = InputInt("How old are you?");

                float weightInKg = InputFloat("What's your weight? (in kg)");

                float heightInCm = InputFloat("How height are you? (in meters)");

                Console.WriteLine("\n{0} {1} is {2} years old, his weight is {3} kg and his height is {4} cm", name, surname, age, weightInKg, heightInCm);

                Console.WriteLine("\nBMI: {0:F} ", CalculateBmi(weightInKg, heightInCm));

                Console.ReadKey();

                i++;
            }
        }

        public static float CalculateBmi(float w, float h)
        {
            float bmi = w / (h * h);

            return (float)bmi;
        }

        public static string InputString(string text)
        {
            Console.WriteLine(text);
            return Console.ReadLine();
        }
        public static int InputInt(string text)
        {
            Console.WriteLine(text);
            return int.Parse(Console.ReadLine());
        }

        public static float InputFloat(string text)
        {
            Console.WriteLine(text);
            var input = Console.ReadLine();
            return float.Parse(input);
        }
    }

}
