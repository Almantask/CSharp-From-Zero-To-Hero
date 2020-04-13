using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Person 1:
            // Gathering Input:
            // Name
            Console.WriteLine("Enter Name: ");
            string name1 = Console.ReadLine();

            // Age
            Console.WriteLine("Enter Age: ");
            int age1 = int.Parse(Console.ReadLine());
        
            // Weight
            Console.WriteLine("Enter Weight: ");
            int weight1 = int.Parse(Console.ReadLine());

            // Height
            Console.WriteLine("Enter Height: ");
            float height1 = float.Parse(Console.ReadLine());

            // Calculating BMI
            float bmi1 = weight1 / (height1 * height1) * 10000;

            // Ouput Results:
            Console.WriteLine($"My name is {name1} and I am {age1} years old, my weight is {weight1} kg, I'm {height1} meters tall and my BMI is {bmi1}");

            // Person 2:
            // Gathering Input:
            // Name
            Console.WriteLine("Enter Name: ");
            string name2 = Console.ReadLine();

            // Age
            Console.WriteLine("Enter Age: ");
            int age2 = int.Parse(Console.ReadLine());

            // Weight
            Console.WriteLine("Enter Weight: ");
            int weight2 = int.Parse(Console.ReadLine());

            // Height
            Console.WriteLine("Enter Height: ");
            float height2 = float.Parse(Console.ReadLine());

            // Calculating BMI
            float bmi2 = weight1 / (height1 * height1) * 10000;

            // Ouput Results:
            Console.WriteLine($"My name is {name2} and I am {age2} years old, my weight is {weight2} kg, I'm {height2} meters tall and my BMI is {bmi2}");
        }
    }
}