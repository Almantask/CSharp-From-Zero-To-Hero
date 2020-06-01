using System;
using System.Globalization;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            for (int i = 0; i < 2; i++)
            {
                string name = StringPrompt("Please introduce a name:");
                string surname = StringPrompt("Please introduce surname:");
                int age = IntPrompt("Please introduce age:");
                float weight = FloatPrompt("Please introduce weight (kg):");
                float height = FloatPrompt("Please introduce height (m):");

                Console.WriteLine(PromptPersonData(name, surname, age, weight, height));

                Console.WriteLine(PromptPersonBMI(name, surname, weight, height));

                if (i == 0)
                {
                    Console.WriteLine("Now let's do it a second time!");
                }
            }

        }

        private static string PromptPersonData(string name, string surname, int age, float weight, float height)
        {
            return $"{name} {surname} is {age} years old, weight is {weight} kg and height is {height} m.";
        }

        public static float FloatPrompt(string message)
        {
            Console.WriteLine(message);
            return float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        public static string StringPrompt(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public static int IntPrompt(string message)
        {
            Console.WriteLine(message);
            return int.Parse(Console.ReadLine());
        }

        public static float CalculateBMI(float weight, float height)
        {
            return weight / (height * height);
        }

        public static string PromptPersonBMI(string name, string surname, float weight, float height)
        {
           return $"BMI of {name} {surname} is {CalculateBMI(weight, height)}.";
        }

    }
}
