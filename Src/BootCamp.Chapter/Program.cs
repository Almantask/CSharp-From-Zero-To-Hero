using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter person information:");
            Console.WriteLine("First name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Age: ");
            string age = Console.ReadLine();
            Console.WriteLine("Weight(kg): ");
            string weight = Console.ReadLine();
            Console.WriteLine("Height(cm): ");
            string height = Console.ReadLine();

            double parseWeight = double.Parse(weight);
            double parseHeight = double.Parse(height);
            double heightSquared = Math.Pow(parseHeight, 2);

            //Calculate BMI 
            double bmi = (parseWeight / heightSquared);

            Console.WriteLine($"{firstName} {lastName} is {age} years old, his weight is {weight} kg and his height is {height} cm.");
            Console.WriteLine($"BMI is: {bmi}");
        }
    }
}
