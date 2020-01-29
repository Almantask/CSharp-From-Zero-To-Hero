using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first name: ");

            var firstName = Console.ReadLine();

            Console.WriteLine("Enter last name: ");
            var lastName = Console.ReadLine();

            Console.WriteLine("Enter age: ");
            var age = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter weight (in kg): ");
            var weight = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter weight (in cm): ");
            var height = Double.Parse(Console.ReadLine());

            var output = $"{firstName} {lastName} is {age} years old, his weight is {weight} kg and his height is {height} cm.";

            Console.WriteLine(output);
            
        }
    }
}
