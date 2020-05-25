using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.Write("Please enter your first name and last name: ");
            string fullName = Console.ReadLine();

            Console.Write("Please enter your age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Please enter your weight: ");
            double weight = double.Parse(Console.ReadLine());

            Console.Write("Please enter your height: ");
            double height = double.Parse(Console.ReadLine());

            double BMICalculator = weight / (height * height);

            Console.WriteLine($"His name is {fullName}, and he is {age} years old. His BMI score is: {BMICalculator}.");

        }
    }
}
