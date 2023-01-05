using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name? ");
            string firstName = Console.ReadLine();

            Console.Write("What is your last name? ");
            string lastName = Console.ReadLine();

            Console.Write("How old are you? ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("What is your weight (kg)? ");
            double weight = double.Parse(Console.ReadLine());

            Console.Write("What is your height (cm)? ");
            double height = double.Parse(Console.ReadLine());

            double bmi = weight / Math.Pow((height / 100), 2);

            Console.WriteLine($"\n{firstName} {lastName} is {age} years old, his weight is {weight} kg and his height is {height} cm. BMI is {bmi}.");
        }
    }
}
