using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            double weight;
            double height;
            double BMI;
            Console.WriteLine("BMI Calculator");
            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Please enter your age: ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your weight in kg: ");
            weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your height in cm: ");
            height = double.Parse(Console.ReadLine());
            Console.WriteLine(name + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " cm.");
            height = height / 100;
            BMI = weight / Math.Pow(height, 2);
            Console.WriteLine("Your BMI is: " + Math.Round(BMI, 2));
        }
    }
}
