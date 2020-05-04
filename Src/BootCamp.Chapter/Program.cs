using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            BMI();
            BMI();
        }

        private static void BMI()
        {
            // Obtaining information
            Console.Write("First Name: ");
            string Name = Console.ReadLine();

            Console.Write("Last Name: ");
            string Surname = Console.ReadLine();

            Console.Write("Age: ");
            int Age = int.Parse(Console.ReadLine());

            Console.Write("Weight: ");
            float Weight = float.Parse(Console.ReadLine());

            Console.Write("Height: ");
            float Height = float.Parse(Console.ReadLine());

            // Repeat information
            Console.WriteLine("\n" + Name + " " + Surname + " is " + Age + " years old, his weight is " + Weight + " kg and his height is " + Height + " cm.");

            // BMI calculation
            float BMI = Weight / ((Height / 100) * (Height / 100));
            Console.WriteLine("BMI for " + Name + ": " + BMI + "\n");
        }
    }
}
