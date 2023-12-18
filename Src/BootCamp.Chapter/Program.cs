using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter the name:");
            string firstName=Console.ReadLine();
            Console.WriteLine("Enter the surname:");
            string lastName=Console.ReadLine();
            Console.WriteLine("Enter the age:");
            int age=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the weight:");
            float weight=float.Parse(Console.ReadLine());   
            Console.WriteLine("Enter the height:");
            float height=float.Parse(Console.ReadLine());
            Console.WriteLine($"{ firstName} {lastName} is {age} years old, his weight is {weight} kg and his height is {height} cm.");
        }
    }
}
