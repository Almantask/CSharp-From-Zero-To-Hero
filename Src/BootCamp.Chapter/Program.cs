using System;
using System.Security.Cryptography.X509Certificates;

namespace BootCamp.Chapter
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string Name;
            string AgeEntered;
            int Age;
            string WeightEntered;
            double Weight;
            string HeightEntered;
            double Height;
            double BMICalculated;
            double BMIRounded;
            Console.WriteLine("What is your name?");
            Name = Console.ReadLine();
            Console.WriteLine("What is your age?");
            AgeEntered = Console.ReadLine();
            Age = int.Parse(AgeEntered);
            Console.WriteLine("What is your weight in kilograms?");
            WeightEntered = Console.ReadLine();
            Weight = double.Parse(WeightEntered);
            Console.WriteLine("What is your height in centimeters?");
            HeightEntered = Console.ReadLine();
            Height = double.Parse(HeightEntered);
            BMICalculated = (Weight/Height/Height)*10000;
            BMIRounded = Math.Round(BMICalculated, 1);
            Console.WriteLine(Name + " is " + Age + " years old, his weight is " + Weight + " and his height is " + Height + ". His BMI is " + BMIRounded + "%.");
        }
    }
}
