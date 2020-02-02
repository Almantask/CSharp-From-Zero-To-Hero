using System;
using System.Globalization;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter a last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter an age: ");
            int age = Int32.Parse(Console.ReadLine());
            Console.Write("Enter a weight: ");
            double weight = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter a height: ");
            double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // introduce person
            Console.WriteLine(firstName + " " + lastName + " is " + age + " years old, his weight is "
                            + weight + " kg and his height is " + height + " cm.");

            // calculate BMI
            double heightInMeters = height / 100.0;
            double bmi = weight / (heightInMeters * heightInMeters);

            Console.WriteLine("BMI: " + Math.Round(bmi, 2));
        }
    }
}
