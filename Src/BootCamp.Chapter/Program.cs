using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            float Weight = 0;
            float Height = 0;

            Console.WriteLine("Body-Mass Index (BMI) Calculator");
            
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();
            Console.WriteLine("What's your weight? (in kg)");
            string weight = Console.ReadLine();
            Console.WriteLine("What's your height? (in cm)");
            string height = Console.ReadLine();

            Weight = float.Parse(weight);
            Height = float.Parse(height);

            Console.WriteLine($"{name} is {age} years old, his weight is {weight} kg ans his height is {height} cm.");

            float bmi = Weight / (Height * Height / 10000);

            Console.WriteLine($"Your BMI is {bmi}");
        }
    }
}
