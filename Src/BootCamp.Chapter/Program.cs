using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input your first name: ");
            string name = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Input your surname: ");
            string surname = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Input your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Input your weight in kg: ");
            float weight = float.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Input your height in cm: ");
            float height = float.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine($"{name} {surname} is {age} years old, his weight is {weight} kg and his height is {height} cm.");
            Console.WriteLine();

            double heightInMeters = height / 100;
            double bmiResult = weight / Math.Pow(heightInMeters, 2);

            Console.WriteLine(bmiResult);
        }
    }
}
