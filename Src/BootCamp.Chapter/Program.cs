using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {    
            // BMI Calculator. Collects info from user first.
            Console.WriteLine("BMI Calculator");
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter your age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your weight in kg: ");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your height in cm: ");
            double height = double.Parse(Console.ReadLine());

            // Echos back info that was taken in.
            Console.WriteLine(name + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " cm.");
            
            // BMI Calculations
            height = height / 100; // Coverts height from cm to meters.
            double BMI = weight / Math.Pow(height, 2);
            Console.WriteLine("Your BMI is: " + Math.Round(BMI, 2)); // Note rounding of BMI
        }
    }
}
