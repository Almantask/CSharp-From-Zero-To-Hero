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
            var weight = GetInputFloat("Weight (in kg)");
            var height = GetInputFloat("Height (in cm)");

            var bmi = CalculateBodyMaxIndex(weight, height);

            Console.WriteLine(
                $"{name} {lastname} is {age} years old, his weight is {weight} kg and his height is {height} cm.{Environment.NewLine}" +
                $"Your body mass index is {bmi:0.00}"
                );
        }

        public static string GetInputString(string question)
        {
            Console.Write("Enter your " + question + ": ");
            return Console.ReadLine();
        }

        public static int GetInputInt(string question)
        {
            Console.Write("Enter your " + question + ": ");
            return int.Parse(Console.ReadLine());
        }

        public static float GetInputFloat(string question)
        {
            Console.Write("Enter your " + question + ": ");
            return float.Parse(Console.ReadLine());
        }

        //height in cm
        public static float CalculateBodyMaxIndex(float weight, float height)
        {
            var heightInMeter = height / 100;
            return weight / (heightInMeter * heightInMeter);
        }
    }
}
