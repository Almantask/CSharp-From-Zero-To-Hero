using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name:");
            string name = Console.ReadLine();
            Console.WriteLine("What is your surname:");
            string surName = Console.ReadLine();
            Console.WriteLine("Age:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Weight:");
            int weight = int.Parse(Console.ReadLine());
            Console.WriteLine("Height:");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine($"{name} {surName} is {age} years old, his weight is {weight} kg and his height is {height} cm.");

            var BMI = weight/(height*height);
            Console.WriteLine(BMI);

            Console.WriteLine("\nWhat is your name:");
            string name1 = Console.ReadLine();
            Console.WriteLine("What is your surname:");
            string surName1 = Console.ReadLine();
            Console.WriteLine("Age:");
            int age1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Weight:");
            int weight1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Height:");
            double height1 = double.Parse(Console.ReadLine());
            Console.WriteLine($"{name1} {surName1} is {age1} years old, his weight is {weight1} kg and his height is {height1} cm.");

            var BMI1 = weight1 /(height1*height1);
            Console.WriteLine(BMI1);
        }
    }
}
