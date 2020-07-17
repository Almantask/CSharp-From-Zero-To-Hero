using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadAndWritePersonData();
            ReadAndWritePersonData();
        }
        // Read and print all required data.
        private static void ReadAndWritePersonData()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Please enter your surname: ");
            string surname = Console.ReadLine();
            Console.Write("Please enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Please enter your weight (in kg): ");
            double weight = double.Parse(Console.ReadLine());
            Console.Write("Please enter your lenght (in cm): ");
            double length = double.Parse(Console.ReadLine());

            double bmi = weight / (length * length / 10000);

            Console.WriteLine($"{name} {surname} is {age} years old, his weight is {weight} kg " +
                $"and his height is {length} cm.");
            Console.WriteLine($"{bmi:F1}");
        }

    }
}
