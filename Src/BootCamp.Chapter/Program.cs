using System;
using System.Globalization;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // input person 1
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

            // introduce person 1
            Console.WriteLine(firstName + " " + lastName + " is " + age + " years old, his/her weight is "
                            + weight + " kg and his/her height is " + height + " cm.");

            // calculate BMI person 1
            double heightInMeters = height / 100.0;
            double bmi = weight / (heightInMeters * heightInMeters);

            Console.WriteLine("BMI: " + Math.Round(bmi, 2));



            // input person 2
            Console.Write("Enter a first name: ");
            firstName = Console.ReadLine();
            Console.Write("Enter a last name: ");
            lastName = Console.ReadLine();
            Console.Write("Enter an age: ");
            age = Int32.Parse(Console.ReadLine());
            Console.Write("Enter a weight: ");
            weight = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter a height: ");
            height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // introduce person 2
            Console.WriteLine(firstName + " " + lastName + " is " + age + " years old, his/her weight is "
                            + weight + " kg and his/her height is " + height + " cm.");

            // calculate BMI person 2
            heightInMeters = height / 100.0;
            bmi = weight / (heightInMeters * heightInMeters);

            Console.WriteLine("BMI: " + Math.Round(bmi, 2));
        }
    }
}
