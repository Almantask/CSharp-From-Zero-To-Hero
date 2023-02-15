using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            int age = int.Parse((Console.ReadLine()));
            Console.Write("Enter your weight in (kg): ");
            double weight = double.Parse(Console.ReadLine());
            Console.Write("Enter your height in (cm): ");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine($"{name} is {age} years old, his weight is {weight} kg and his height is {height} cm");
            double BMI = (weight/height/height) * 10000;
            Console.WriteLine($"{name}, BMI is {BMI}");


            Console.Write("\nEnter your name: ");
            string name2 = Console.ReadLine();
            Console.Write("Enter your age: ");
            int age2 = int.Parse((Console.ReadLine()));
            Console.Write("Enter your weight in (kg): ");
            double weight2 = double.Parse(Console.ReadLine());
            Console.Write("Enter your height in (cm): ");
            double height2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"{name2} is {age2} years old, his weight is {weight2} kg and his height is {height2} cm");

            double BMI2 = (weight2/height2/height2) * 10000;
            Console.WriteLine($"{name2} BMI is {BMI2}");
            Console.WriteLine("Press any key to exit the program...");
            Console.ReadKey();
        }
    }
}
