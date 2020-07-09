using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please provide your name: ");
            string name = Console.ReadLine();
            Console.Write("Please provide your surname: ");
            string surname = Console.ReadLine();
            Console.Write("Please provide your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Please provide your weigth in kg: ");
            int weight = int.Parse(Console.ReadLine());
            Console.Write("Please provide your height in cm: ");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine(name + " " + surname + " is " + age + " years old, their weight is " + weight + " kg and their height is " + height + "cm.");

            // BMI is (weight in kg)/(height square in m)
            double heightInMeters = height / 100;
            double bmi = weight / (heightInMeters * heightInMeters);
            Console.WriteLine("Their BMI is: " + bmi);

        }
    }
}
