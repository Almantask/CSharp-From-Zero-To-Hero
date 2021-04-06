using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("First name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Sure Name: ");
                string sureName = Console.ReadLine();
                Console.WriteLine("Age: ");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("Weight: ");
                double weight = double.Parse(Console.ReadLine());
                Console.WriteLine("Height: ");
                double height = double.Parse(Console.ReadLine());

                var bmi = weight / ((height / 100) * (height / 100));

                Console.WriteLine($"{name} {sureName} is {age} years old, his weight is {weight} kg and his height is {height} cm.");

                Console.WriteLine("Your BMI - " + bmi);
            }
        }
    }
}
