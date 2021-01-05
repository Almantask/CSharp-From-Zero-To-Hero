using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Homework Inputs
            for (int i = 0; i < 2; i++)
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Surname: ");
                string surname = Console.ReadLine();
                Console.Write("Age: ");
                string age = Console.ReadLine();
                Console.Write("Weight (in kg): ");
                string weight = Console.ReadLine();
                Console.Write("Height (in cm): ");
                string height = Console.ReadLine();
                Console.WriteLine(name + " " + surname + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " cm. ");
                float bmi = float.Parse(weight) / float.Parse(height);
                Console.WriteLine("BMI: " + bmi);
            }
        }
    }
}
