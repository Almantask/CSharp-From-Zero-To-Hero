using System;

namespace BootCamp.Chapter
{
    internal class Program
    {
        private static void Main()
        {
            var name = GetInput("Name");
            var lastname = GetInput("Surname");
            var age = int.Parse(GetInput("Age"));
            var weight = double.Parse(GetInput("Weight (in kg)"));
            var height = double.Parse(GetInput("Height (in cm)"));

            var bmi = CalculateBodyMaxIndex(weight, height);

            Console.WriteLine($"{name} {lastname} is {age} years old, his weight is {weight} kg and his height is {height} cm.");
            Console.WriteLine($"Your body mass index is {bmi:0.00}");
        }

        private static string GetInput(string question)
        {
            Console.Write("Enter your " + question + ": ");
            return Console.ReadLine();
        }


        //height in cm
        private static double CalculateBodyMaxIndex(double weight, double height)
        {
            var heightInMeter = height / 100;
            return weight / (heightInMeter * heightInMeter);
        }
    }
}