using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read name, surename, age, weight (in kg) and height (in cm) from console.
            Console.Write("Please tell me your first name: ");
            string name = Console.ReadLine();
            Console.Write("Please tell me your surname: ");
            string surname = Console.ReadLine();
            Console.Write("Please tell me your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Please tell me your weight in Kg: ");
            int weight = int.Parse(Console.ReadLine());
            Console.Write("Please tell me your height in cm: ");
            double height = double.Parse(Console.ReadLine());
            // Tom Jefferson is 19 years old, his weight is 50 kg and his height is 156.5 cm. 
            Console.WriteLine($"{name} {surname} is {age} years old, his weight is {weight} kg and his height is {height} cm .");
            // BMI = kg/m2
            double heightInMeters = height / 100;
            double bmi = weight / (heightInMeters * heightInMeters);
            Console.WriteLine($"Your BMI is {bmi}");

            // Second person using the vars from the first person because they are not needed anymore.
            Console.Write("Please tell me your first name: ");
            name = Console.ReadLine();
            Console.Write("Please tell me your surname: ");
            surname = Console.ReadLine();
            Console.Write("Please tell me your age: ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Please tell me your weight in Kg: ");
            weight = int.Parse(Console.ReadLine());
            Console.Write("Please tell me your height in cm: ");
            height = double.Parse(Console.ReadLine());
            // Tom Jefferson is 19 years old, his weight is 50 kg and his height is 156.5 cm. 
            Console.WriteLine($"{name} {surname} is {age} years old, his weight is {weight} kg and his height is {height} cm .");
            // BMI = kg/m2
            heightInMeters = height / 100;
            bmi = weight / (heightInMeters * heightInMeters);
            Console.WriteLine($"Your BMI is {bmi}");
        }
    }
}
