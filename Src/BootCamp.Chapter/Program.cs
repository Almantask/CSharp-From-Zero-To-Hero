using System;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex nameRegex = new Regex("^[aA-zZ]{2,100}$");

            Console.WriteLine("Name:");
            var name = Console.ReadLine();
            while (string.IsNullOrEmpty(name) || !nameRegex.IsMatch(name))
            {
                Console.WriteLine("Invalid name! Please try again");
                Console.WriteLine("Name:");
                name = Console.ReadLine();
            }

            Console.WriteLine("Surname:");
            var surname = Console.ReadLine();
            while (string.IsNullOrEmpty(surname) || !nameRegex.IsMatch(surname))
            {
                Console.WriteLine("Invalid surname! Please try again");
                Console.WriteLine("Surname:");
                surname = Console.ReadLine();
            }

            Console.WriteLine("Age:");
            string age = Console.ReadLine();
            int intAge;
            while (!int.TryParse(age, out intAge))
            {
                Console.WriteLine("Invalid age! Please try again");
                Console.WriteLine("Age:");
                age = Console.ReadLine();
            }

            Console.WriteLine("Weight (kg):");
            string weight = Console.ReadLine();
            double weightDouble;
            while (!double.TryParse(weight,out weightDouble))
            {
                Console.WriteLine("Invalid weight! Please try again");
                Console.WriteLine("Weight (kg):");
                weight = Console.ReadLine();
            }

            Console.WriteLine("Height (cm):");
            string height = Console.ReadLine();
            double heightDouble;
            while (!double.TryParse(height, out heightDouble))
            {
                Console.WriteLine("Invalid height! Please try again");
                Console.WriteLine("Height (cm):");
                height = Console.ReadLine();
            }

            double BMI = weightDouble / ((heightDouble/100) * (heightDouble / 100));

            Console.WriteLine($"{name} {surname} is {age} years old, his weight is {weight.ToString()} and his height is {height.ToString()} cm");
            Console.WriteLine($"{name}'s BMI is: {Math.Round(BMI, 2).ToString()}");
        }
    }
}
