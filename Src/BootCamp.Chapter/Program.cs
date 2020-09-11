using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            int numPeople = 2;

            while(numPeople > 0)
            {
                Console.Write("Enter name: ");
                string name = Console.ReadLine();

                Console.Write("Enter surname: ");
                string surname = Console.ReadLine();

                Console.Write("Enter age: ");
                int age = int.Parse(Console.ReadLine());

                Console.Write("Enter weight (in kg): ");
                double weight = double.Parse(Console.ReadLine());

                Console.Write("Enter height (in cm): ");
                double height = double.Parse(Console.ReadLine());

                Console.WriteLine($"{name} {surname} is {age} years old, his weight is {weight} kg and his height is {height} cm.");

                BMIPrinter(weight, height);

                numPeople--;
            }

            Console.ReadKey();
        }

        static void BMIPrinter(double weight, double height)
        {
            double BMI = weight / ((height / 100) * (height / 100));
            Console.WriteLine($"BMI = {BMI}");
        }
    }
}
