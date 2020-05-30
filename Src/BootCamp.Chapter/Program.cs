using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Tom";
            string surname = "Jefferson";
            int age = 19;
            double weight = 50;
            double height = 156.5;
            
            Console.WriteLine($"{name} {surname} is {age} years old, his weight is {weight} kg and his height is {height} cm");

            double bmi = weight / Math.Pow(height / 100.0, 2);
            Console.WriteLine($"BMI of {name} {surname} is {bmi}");

            string name2 = "John";
            string surname2 = "Smith";
            int age2 = 34;
            double weight2 = 86.5;
            double height2 = 178.9;

            Console.WriteLine($"{name2} {surname2} is {age2} years old, his weight is {weight2} kg and his height is {height2} cm");

            double bmi2 = weight2 / Math.Pow(height2 / 100.0, 2);
            Console.WriteLine($"BMI of {name2} {surname2} is {bmi2}");
        }
    }
}
