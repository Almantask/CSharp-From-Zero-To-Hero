using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            double weight;
            double height;
            Console.Write("Entern name: ");
            name = Console.ReadLine();

            Console.Write("Enter age: ");
            age = int.Parse(Console.ReadLine());

            Console.Write("Enter weight: ");
            weight = double.Parse(Console.ReadLine());

            Console.Write("Enter height: ");
            height = double.Parse(Console.ReadLine());


            Console.WriteLine($"{name} is {age} years old, his weight is {weight} kg & his height is {height} cm");
            Console.WriteLine($"his bmi is {weight/Math.Pow(height/100.0,2):N}");

            Console.Write("Entern name: ");
            name = Console.ReadLine();

            Console.Write("Enter age: ");
            age = int.Parse(Console.ReadLine());

            Console.Write("Enter weight: ");
            weight = double.Parse(Console.ReadLine());

            Console.Write("Enter height: ");
            height = double.Parse(Console.ReadLine());


            Console.WriteLine($"{name} is {age} years old, his weight is {weight} kg & his height is {height} cm");
            Console.WriteLine($"his bmi is {weight / Math.Pow(height / 100.0, 2):N}");
        }
    }
}
