using System;

namespace BootCamp.Chapter
{
    class Program
    {

        static void Main(string[] args)
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Introduce a name:");
                string name = Console.ReadLine();

                Console.WriteLine("Introduce a surname:");
                string surname = Console.ReadLine();

                Console.WriteLine("Introduce an age:");
                int age = int.Parse(Console.ReadLine());

                Console.WriteLine("Introduce a weight (kg):");
                double weight = double.Parse(Console.ReadLine());

                Console.WriteLine("Introduce a height (cm):");
                double height = double.Parse(Console.ReadLine());

                Console.WriteLine($"{name} {surname} is {age} years old, his weight is {weight} kg and his height is {height} cm.");

                double bmi = weight / Math.Pow(height / 100.0, 2);

                Console.WriteLine($"BMI of {name} {surname} is {bmi}.");

                if (i == 0)
                {
                    Console.WriteLine("Now do it a second time!");
                }
            }            
        }

    }
}
