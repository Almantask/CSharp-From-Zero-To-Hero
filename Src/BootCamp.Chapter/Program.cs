using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Person 1***");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Surname: ");
            string surname = Console.ReadLine();

            Console.Write("Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Weight (in kg): ");
            float weight = Convert.ToSingle(Console.ReadLine());

            Console.Write("Height (in cm): ");
            float height = Convert.ToSingle(Console.ReadLine());

            // 1. Print all the info
            string message = name + " " + surname + " is " + age + " years old, his weight is " + weight + "Kg and his height is " + height + "cm.";
            Console.WriteLine(message);

            // 2. calculate BMI
            // Formula: weight (kg) / [height (m)]**2

            float heightM = height / 100;  // calculate height in meters

            float BMI = weight / (heightM * heightM);

            Console.WriteLine("His BMI is: " + BMI);


            // repeat for another person
            Console.WriteLine("\n***Person 2***");
            Console.Write("Name: ");
            name = Console.ReadLine();

            Console.Write("Surname: ");
            surname = Console.ReadLine();

            Console.Write("Age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Weight (in kg): ");
            weight = Convert.ToSingle(Console.ReadLine());

            Console.Write("Height (in cm): ");
            height = Convert.ToSingle(Console.ReadLine());

            // 1. Print all the info
            message = name + " " + surname + " is " + age + " years old, his weight is " + weight + "Kg and his height is " + height + "cm.";
            Console.WriteLine(message);

            // 2. calculate BMI
            // Formula: weight (kg) / [height (m)]**2

            heightM = height / 100;  // calculate height in meters

            BMI = weight / (heightM * heightM);

            Console.WriteLine("His BMI is: " + BMI);
        }
    }
}
