using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First User");
            Console.Write("First name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine(firstName);

            Console.Write("Last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine(lastName);

            Console.Write("Age: ");
            var age = Console.ReadLine();
            Console.WriteLine(age);

            Console.Write("Height (in cm): ");
            var height = Console.ReadLine();
            Console.WriteLine(height);

            Console.Write("Weight (in kg): ");
            var weight = Console.ReadLine();
            Console.WriteLine(weight);

            Console.WriteLine(firstName + " " + lastName + " is " + age + " years old, their weight is " + weight + "kg and their height is " + height + " cm.");

            var toMeters = height / 100;
            var metersSquared = toMeters * toMeters;
            var bmi = weight / metersSquared;
            Console.WriteLine(firstName + lastName + " BMI: " + bmi);

            Console.WriteLine("Second User");
            Console.Write("First name: ");
            string firstName2 = Console.ReadLine();
            Console.WriteLine(firstName);

            Console.Write("Last name: ");
            string lastName2 = Console.ReadLine();
            Console.WriteLine(lastName2);

            Console.Write("Age: ");
            var age2 = Console.ReadLine();
            Console.WriteLine(age2);

            Console.Write("Height (in cm): ");
            var height2 = Console.ReadLine();
            Console.WriteLine(height2);

            Console.Write("Weight (in kg): ");
            var weight2 = Console.ReadLine();
            Console.WriteLine(weight2);

            Console.WriteLine(firstName2 + " " + lastName2 + " is " + age2 + " years old, their weight is " + weight2 + "kg and their height is " + height2 + " cm.");

            var toMeters2 = height2 / 100;
            var metersSquared2 = toMeters2 * toMeters2;
            var bmi2 = weight2 / metersSquared2;
            Console.WriteLine(firstName2 + lastName2 + " BMI: " + bmi2);

        }
    }
}