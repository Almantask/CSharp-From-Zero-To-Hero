using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            double bmi,bmi1 = 0;
            Console.WriteLine("Enter the first name:");
            string firstName=Console.ReadLine();
            Console.WriteLine("Enter the last name:");
            string lastName=Console.ReadLine();
            Console.WriteLine("Enter the age:");
            int age=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the weight:");
            float weight=float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height:");
            float height=float.Parse(Console.ReadLine());
            Console.WriteLine($"{firstName} {lastName} is {age} years old, his weight is {weight}kg and his height is {height}cm.");
            bmi = weight / ((height/100) * (height/100));
            Console.WriteLine($"BMI of {firstName} {lastName} is {bmi}");
            Console.WriteLine("Enter the first name:");
            string firstName1 = Console.ReadLine();
            Console.WriteLine("Enter the last name:");
            string lastName1 = Console.ReadLine();
            Console.WriteLine("Enter the age:");
            int age1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the weight:");
            float weight1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height:");
            float height1 = float.Parse(Console.ReadLine());
            Console.WriteLine($"{firstName1} {lastName1} is {age1} years old, his weight is {weight1}kg and his height is {height1}cm.");
            bmi1 = weight1 / ((height1 / 100) * (height1 / 100));
            Console.WriteLine($"BMI of {firstName1} {lastName1} is {bmi1}");

        }
    }
}
