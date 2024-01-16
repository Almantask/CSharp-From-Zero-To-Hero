using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your first name: ");
            string firstName = Console.ReadLine();
        
            Console.Write("Please enter your last name: ");
            string lastName = Console.ReadLine();
        
            Console.Write("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
        
            Console.Write("Please enter your weight in lbs: ");
            int weight = Convert.ToInt32(Console.ReadLine());
        
            Console.Write("Please enter your height in inches: ");
            int height = Convert.ToInt32(Console.ReadLine());

            double bmi = weight / Math.Pow(height, 2) * 703;
        
            Console.WriteLine($"{firstName} {lastName} is {age} years old, their weight is {weight} lbs and their height is {height} inches. Their BMI is {bmi}.");
        }
    }
}