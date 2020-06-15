using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            var name = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            var surname = Console.ReadLine();
            Console.WriteLine("how old are you?");
            var age = Console.ReadLine();
            Console.WriteLine("What is your weight in kg?");
            var weight = Double.Parse(Console.ReadLine());
            Console.WriteLine("what is your height in in?");
            var height = Double.Parse(Console.ReadLine());

            double heightSquared = Math.Pow(height, 2);
            double Bmi = weight / heightSquared;

            Console.WriteLine($"{name} at a height of {height}in and a weight of {weight}kg, your BMI is {Bmi}");
        }
    }
}
