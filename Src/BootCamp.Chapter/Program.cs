using System;

namespace BootCamp.Chapter
{
    class Program
    {

        static void Main(string[] args)
        {
            string name = "Tom";
            string surname = "Jefferson";
            int age = 19;
            double weight = 50;
            double height = 156.5;

            double bmi = weight / Math.Pow(height / 100.0, 2);

            Console.WriteLine($"{name} {surname} is {age} years old, his weight is {weight} kg and his height is {height} cm");
            Console.WriteLine($"BMI of {name} {surname} is {bmi}");

            Console.WriteLine("Introduce a name:");
            name = Console.ReadLine();

            Console.WriteLine("Introduce a surname:");
            surname = Console.ReadLine();

            Console.WriteLine("Introduce an age:");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce a weight (kg):");
            weight = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Introduce a height (cm):");
            height = double.Parse(Console.ReadLine());

            Console.WriteLine($"{name} {surname} is {age} years old, his weight is {weight} kg and his height is {height} cm");

            bmi = weight / Math.Pow(height / 100.0, 2);

            Console.WriteLine($"BMI of {name} {surname} is {bmi}");
        }

    }
}
