using System;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static float CalculateBmi(float height, float weight)
        {
            // Calculate BMI
            // Formula: weight (kg) / [height (m)]**2

            //float heightM = height / 100;  // calculate height in meters

            float BMI = weight / (height * height);

            return BMI;
        }

        public static string ReadInputString(string message)
        {
            Console.Write(message);
            string value = Console.ReadLine();
            return value;
        }

        public static float ReadInputFloat(string message)
        {
            Console.Write(message);
            float.TryParse(Console.ReadLine(), out float value);
            return value;
        }

        public static int ReadInputInt(string message)
        {
            Console.Write(message);
            int.TryParse(Console.ReadLine(), out int value);
            return value;
        }

        public static void Demo()
        {
            
            string name = ReadInputString("Name: ");
            string surname = ReadInputString("Surname: ");
            int age = ReadInputInt("Age: ");
            float weight = ReadInputFloat("Weight (in kg): ");
            float height = ReadInputFloat("Height(in m): ");

            // Print all the info
            string message = name + " " + surname + " is " + age + " years old, his weight is " + weight + "Kg and his height is " + height + "cm.";
            Console.WriteLine(message);

            float BMI = CalculateBmi(height, weight);
            Console.WriteLine("His BMI is: " + BMI);
        }
    }
}
