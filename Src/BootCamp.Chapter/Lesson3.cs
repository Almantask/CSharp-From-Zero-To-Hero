using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            for (int i = 0; i < 2; i++)
            {
                string name = PromptString("Name: ");

                string surname = PromptString("Surname: ");

                int age = PromptInt("Age: ");

                float weight = PromptFloat("Weight(kg): ");

                float heightCM = PromptFloat("Height(cm): ");
                float heightM = heightCM / 100.0f;

                Console.WriteLine(name + " " + surname + " is " + age + " years old, his weight is " + weight + " kg and his height is " + heightCM + " cm.");

                float BMI = CalculateBmi(weight, heightM);
                Console.WriteLine("His Body-Mass Index(BMI) is " + BMI);
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
            return Int32.Parse(Console.ReadLine());
        }

        public static float PromptFloat(string message)
        {
            Console.Write(message);
            return float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        public static float CalculateBmi(float weight, float height)
        {
            return weight / (height * height);
        }
    }
}
