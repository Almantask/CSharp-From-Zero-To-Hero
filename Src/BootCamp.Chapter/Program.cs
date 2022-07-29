using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BMI Calculator by Joseph Cerdan");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Surname: ");
            string surname = Console.ReadLine();

            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Weight (kg): ");
            int weight = int.Parse(Console.ReadLine());

            Console.Write("Height (cm): ");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine(name + " " + surname + " is " + age + " years old, their weight is " + weight + " kg and their height is " + height + " cm.");

            double bmi = weight / Math.Pow((height / 100), 2);

            Console.WriteLine("Their calculated BMI is: " + bmi);

            Console.Write("Name: ");
            name = Console.ReadLine();

            Console.Write("Surname: ");
            surname = Console.ReadLine();

            Console.Write("Age: ");
            age = int.Parse(Console.ReadLine());

            Console.Write("Weight (kg): ");
            weight = int.Parse(Console.ReadLine());

            Console.Write("Height (cm): ");
            height = double.Parse(Console.ReadLine());

            Console.WriteLine(name + " " + surname + " is " + age + " years old, their weight is " + weight + " kg and their height is " + height + " cm.");

            bmi = weight / Math.Pow((height / 100), 2);

            Console.WriteLine("Their calculated BMI is: " + bmi);
        }
    }
}
