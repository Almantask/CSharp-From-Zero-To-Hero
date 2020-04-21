using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string age;
            string weight;
            float Weight;
            string height;
            float Height;
            float bmi;

            Console.WriteLine("Body-Mass Index (BMI) Calculator");
            Console.WriteLine("");

            // Person 01

            Console.WriteLine("What's your name?");
            name = Console.ReadLine();
            Console.WriteLine("How old are you?");
            age = Console.ReadLine();
            Console.WriteLine("What's your weight? (in kg)");
            weight = Console.ReadLine();
            Weight = float.Parse(weight);
            Console.WriteLine("What's your height? (in cm)");
            height = Console.ReadLine();
            Height = float.Parse(height);

            Console.WriteLine($"{name} is {age} years old, his weight is {weight} kg ans his height is {height} cm.");

            bmi = Weight / (Height * Height / 10000);
            Console.WriteLine($"Your BMI is {bmi}");
            Console.WriteLine("");

            // Person 02

            Console.WriteLine("What's your name?");
            name = Console.ReadLine();
            Console.WriteLine("How old are you?");
            age = Console.ReadLine();
            Console.WriteLine("What's your weight? (in kg)");
            weight = Console.ReadLine();
            Weight = float.Parse(weight);
            Console.WriteLine("What's your height? (in cm)");
            height = Console.ReadLine();
            Height = float.Parse(height);

            Console.WriteLine($"{name} is {age} years old, his weight is {weight} kg ans his height is {height} cm.");

            bmi = Weight / (Height * Height / 10000);
            Console.WriteLine($"Your BMI is {bmi}");
        }
    }
}
