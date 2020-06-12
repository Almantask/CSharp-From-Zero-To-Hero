using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter age:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter weight (in kg):");
            float weight = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter height (in cm):");
            float height = float.Parse(Console.ReadLine());

            float bmi = weight / ((height / 100) * (height / 100));

            Console.WriteLine(name + " is " + age + " years old, their weight is " + weight + " kg, and their height is " + height + " cm.");
            Console.WriteLine("Their BMI is: " + bmi);
        }
    }
}
