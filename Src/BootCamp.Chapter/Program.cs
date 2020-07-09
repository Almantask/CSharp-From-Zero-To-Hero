using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Person 1:");
            Console.Write("Please provide your name: ");
            string name = Console.ReadLine();
            Console.Write("Please provide your surname: ");
            string surname = Console.ReadLine();
            Console.Write("Please provide your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Please provide your weigth in kg: ");
            int weight = int.Parse(Console.ReadLine());
            Console.Write("Please provide your height in cm: ");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine(name + " " + surname + " is " + age + " years old, their weight is " + weight + " kg and their height is " + height + "cm.");

            // BMI is (weight in kg)/(height square in m)
            double heightInMeters = height / 100;
            double bmi = weight / (heightInMeters * heightInMeters);
            Console.WriteLine("Their BMI is: " + bmi);

            // Person 2
            Console.WriteLine("Person 2:");
            Console.Write("Please provide your name: ");
            name = Console.ReadLine();
            Console.Write("Please provide your surname: ");
            surname = Console.ReadLine();
            Console.Write("Please provide your age: ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Please provide your weigth in kg: ");
            weight = int.Parse(Console.ReadLine());
            Console.Write("Please provide your height in cm: ");
            height = double.Parse(Console.ReadLine());

            Console.WriteLine(name + " " + surname + " is " + age + " years old, their weight is " + weight + " kg and their height is " + height + "cm.");

            heightInMeters = height / 100;
            bmi = weight / (heightInMeters * heightInMeters);
            Console.WriteLine("Their BMI is: " + bmi);
        }
    }
}
