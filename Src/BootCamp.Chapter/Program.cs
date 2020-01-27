﻿using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {

        StartOver:
            InteractionManager.PerformInteractions();

            Console.WriteLine("Whould you like to start again?");
            var answer = Console.ReadLine();
            if (answer.ToLower() == "y") goto StartOver;
        }
    }



    public static class InteractionManager
    {
        public static void PerformInteractions()
        {
            var name = Prompter("What is your full name?");
            var age = int.Parse(Prompter("What is your age?"));
            var weight = double.Parse(Prompter("What is your weight in kg?"));
            var height = double.Parse(Prompter("What is your height in cm?"));
            var bmi = CalculateBmi(height, weight);

            Console.WriteLine($"{name} is {age} years old, his weight is {weight} kg and his height is {height} cm.");
            Console.WriteLine($"{name} has a BMI of {bmi}");
        }

        private static string Prompter(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        private static double CalculateBmi(double height, double weight)
        {
            if (weight > 0 && height > 0)
            {
                var heightInMeters = height / 100;
                return weight / (heightInMeters * heightInMeters);
            }

            return 0;
        }
    }
}
