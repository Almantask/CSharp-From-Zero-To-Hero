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
            var name = promptString("Please enter name ");
            var surname = promptString("Please enter surname ");
            var age = promptInt("Please enter an age ");
            var weight = promptFloat("Please enter your weight in kg ");
            var height = promptFloat("Please enter your height in m ");
            var bmi = calculateBmi(weight, height);

            Console.WriteLine($"{name} {surname} is {age} years old, his weight is {weight} kg and his height is {height} cm.");
            Console.WriteLine($"Also the BMI is {bmi}.");

        }
        public static int promptInt(string message)
            {
                Console.Write(message);
                int age = int.Parse(Console.ReadLine());
                return age;
            }
            
        public static string promptString(string message)
            {
                Console.Write(message);
                string name = Console.ReadLine();
                return name;
            }
            
        public static float promptFloat(string message)
            {
                Console.Write(message);
                float measuring = float.Parse(Console.ReadLine());
                return measuring;
            }

            
        public static float calculateBmi(float weight, float height)
            {
                var bmi = weight / (height * height);
                Console.WriteLine($"Also the BMI is {bmi}.");
                return bmi;
            }
    }
}
