using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Enter your First Name:");
            string firstname = Console.ReadLine();

            System.Console.Write("Enter your Last Name: ");
            string lastname = Console.ReadLine();

            System.Console.Write("Enter our age:");
            int age = int.Parse(Console.ReadLine());

            System.Console.Write("Enter your weight(kg):");
            float weight = float.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter your height(cm)");
            float height = float.Parse(Console.ReadLine());

            System.Console.WriteLine($"{firstname} {lastname} is {age} years old, his weight is {weight} kg and his height is {height} cm");




        }
    }
}
