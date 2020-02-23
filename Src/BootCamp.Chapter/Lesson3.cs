using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            const int personCount = 2;

            for (int i = 0; i < personCount; i++)
            {
                string firstName = GetString("Input your first name: ");
                string lastName = GetString("Input your last name: ");
                int age = GetInt("Input your age: ");
                float height = GetFloat("Input your height in m: ");
                float weight = GetFloat("Input your weight in kg: ");

                float bmi = CalculateBmi(weight, height);

                Console.WriteLine($"{firstName} {lastName} is {age} years old, his weight is {weight} kg and his height is {height} cm. His BMI is {bmi}");
                Console.WriteLine();
            }

            Console.ReadKey();

            
        }
        public static int GetInt(string message)
        {
            Console.Write(message);
            int result;

            if (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Incorrect data entered!");
                GetInt(message);
            }

            return result;
        }

        public static float GetFloat(string message)
        {
            Console.Write(message);
            float result;

            if (!float.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Incorrect data entered!");
                GetFloat(message);
            }
            return result;
        }

        public static string GetString(string message)
        {
            Console.Write(message);

            string result = Console.ReadLine();

            return result;
        }

        public static float CalculateBmi(float weight, float height)
        {
            float bmi = (weight / (height * height));

            return bmi;
        }
    }
}
