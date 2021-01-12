using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            var name = GetInputString("Name");
            var lastname = GetInputString("Surname");
            var age = GetInputInt("Age");
            var weightInKg = GetInputFloat("Weight (in kg)");
            var heightInCm = GetInputFloat("Height (in cm)");

            var bmi = CalculateBodyMaxIndex(weightInKg, (heightInCm / 100)); //converting height cm to m

            Console.WriteLine(
                $"{name} {lastname} is {age} years old, his weight is {weightInKg} kg and his height is {heightInCm} cm.{Environment.NewLine}" +
                $"Your body mass index is {bmi:0.00}"
                );
        }

        public static string GetInputString(string question)
        {
            Console.Write(question + " ");
            return Console.ReadLine();
        }

        public static int GetInputInt(string question)
        {
            Console.Write(question + " ");
            return int.Parse(Console.ReadLine());
        }

        public static float GetInputFloat(string question)
        {
            Console.Write(question + " ");
            return float.Parse(Console.ReadLine());
        }

        public static float CalculateBodyMaxIndex(float weightInKg, float heightInM)
        {
            return weightInKg / (heightInM * heightInM);
        }
    }
}
