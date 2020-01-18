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

            Console.Write("Last name: ");
            string lastName = Console.ReadLine();

            Console.Write("Age: ");
            var age = Console.ReadLine();

            Console.Write("Height (in cm): ");
            var height = float.Parse(Console.ReadLine());

            Console.Write("Weight (in kg): ");
            var weight = float.Parse(Console.ReadLine());

            Console.WriteLine(firstName + " " + lastName + " is " + age + " years old, their weight is " + weight + "kg and their height is " + height + " cm.");

            var toMeters = height / 100;
            var metersSquared = toMeters * toMeters;
            var bmi = weight / metersSquared;
            Console.WriteLine(firstName + " " + lastName + " BMI: " + bmi);

            Console.WriteLine("Second User");
            Console.Write("First name: ");
            string firstName2 = Console.ReadLine();

            Console.Write("Last name: ");
            string lastName2 = Console.ReadLine();

            Console.Write("Age: ");
            var age2 = Console.ReadLine();

            Console.Write("Height (in cm): ");
            var height2 = float.Parse(Console.ReadLine());

            Console.Write("Weight (in kg): ");
            var weight2 = float.Parse(Console.ReadLine());

            Console.WriteLine(firstName2 + " " + lastName2 + " is " + age2 + " years old, their weight is " + weight2 + "kg and their height is " + height2 + " cm.");

            var toMeters2 = height / 100;
            var metersSquared2 = toMeters2 * toMeters2;
            var bmi2 = weight / metersSquared2;
            Console.WriteLine(firstName2 + " " + lastName2 + " BMI: " + bmi2);

        }
    }
}