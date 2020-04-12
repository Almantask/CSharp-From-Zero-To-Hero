using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Surname: ");
            string surname = Console.ReadLine();

            Console.WriteLine("Enter Age: ");
            if (!int.TryParse(Console.ReadLine(), out int age))
            {
                Console.WriteLine("Age Should be a Number");
            }

            Console.WriteLine("Enter Weight: ");
            if(!int.TryParse(Console.ReadLine(), out int weight))
            {
                Console.WriteLine("Weight must be a Number");
            }

            Console.WriteLine("Enter Height: ");
            if(!double.TryParse(Console.ReadLine(), out double height))
            {
                Console.WriteLine("Height Must be a Number");
            }

            Console.WriteLine($"{name} {surname} is {age} old, his weight is " +
                $"{weight}KG and his height is {height}cm");

            Console.WriteLine($"BMI is {height / weight}");

        }
    }
}
