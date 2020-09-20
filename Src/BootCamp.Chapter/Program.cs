using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First person:");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your surname: ");
            string surname = Console.ReadLine();
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter your weight (kg): ");
            double weight = double.Parse(Console.ReadLine());
            Console.Write("Enter your height (cm): ");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine($"{name} {surname} is {age} years old, his weight is {weight} kg and his height is {height} cm.");

            double BMI = weight / (height/100 * height/100);
            Console.WriteLine($"Your BMI is: {BMI}");

            Console.WriteLine("\nSecond person:");
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.Write("Enter your surname: ");
            surname = Console.ReadLine();
            Console.Write("Enter your age: ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Enter your weight (kg): ");
            weight = double.Parse(Console.ReadLine());
            Console.Write("Enter your height (cm): ");
            height = double.Parse(Console.ReadLine());

            Console.WriteLine($"{name} {surname} is {age} years old, his weight is {weight} kg and his height is {height} cm.");

            BMI = weight / (height / 100 * height / 100);
            Console.WriteLine($"Your BMI is: {BMI}");
        }
    }
}
