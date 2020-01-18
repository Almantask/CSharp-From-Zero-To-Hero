using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your surname: ");
            string surname = Console.ReadLine();
            Console.Write("Enter your age: ");
            string age = Console.ReadLine();
            Console.Write("Enter your weight in kg: ");
            string weight = Console.ReadLine();
            Console.Write("Enter your height in cm: ");
            string height = Console.ReadLine();

            double heightInMeters = Convert.ToDouble(height) / 100;
            double heightSquared = Math.Pow(heightInMeters, 2);
            double bmi = Convert.ToDouble(weight) / heightSquared;

            Console.WriteLine(name + " " + surname + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " cm.");
            Console.WriteLine("BMI = " + bmi);
        }
    }
}
