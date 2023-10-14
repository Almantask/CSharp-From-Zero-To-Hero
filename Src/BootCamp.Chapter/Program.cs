using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Please state your full name:");
                string fullname = Console.ReadLine();
                Console.WriteLine("Please state your age in years:");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("Please state your weight in kilograms:");
                double weight = double.Parse(Console.ReadLine());
                Console.WriteLine("Please state your height in meters:");
                double height = double.Parse(Console.ReadLine());
                double bmi = weight / (height * height);
                Console.WriteLine(fullname + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height * 100 + " cm.");
                Console.WriteLine(fullname + " has a BMI of " + bmi);
            }
        }
    }
}
