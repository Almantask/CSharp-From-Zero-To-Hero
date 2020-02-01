using System;
using System.Globalization;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            int age;
            double weight;
            double height;

            Console.Write("Enter a first name: ");
            firstName = Console.ReadLine();
            Console.Write("Enter a last name: ");
            lastName = Console.ReadLine();
            Console.Write("Enter an age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a weight: ");
            weight = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter a height: ");
            height = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            // introduce person
            Console.WriteLine(firstName + " " + lastName + " is " + age + " years old, his weight is "
                            + weight + " kg and his height is " + height + " cm.");

            // calculate BMI
            height = height / 100.0;
            double bmi = weight / (height * height);

            Console.WriteLine("BMI: " + bmi.ToString("0.##"));
        }
    }
}
