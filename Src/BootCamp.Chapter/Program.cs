using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static double CalculateBmi(double w, double h)
        {
            double bmi = w / Math.Pow(h/100, 2);

            return bmi;
        }
        static void Main(string[] args)
        {
            int i = 0;

            while (i < 2)
            {
                Console.Clear();

                Console.WriteLine("What's your name?");
                string name = Console.ReadLine();

                Console.WriteLine("What's your surname?");
                string surname = Console.ReadLine();

                Console.WriteLine("How old are you?");
                int age = int.Parse(Console.ReadLine());

                Console.WriteLine("What's your weight? (in kg)");
                int weightInKg = int.Parse(Console.ReadLine());

                Console.WriteLine("How height are you? (in cm)");
                int heightInCm = int.Parse(Console.ReadLine());

                Console.WriteLine("\n{0} {1} is {2} years old, his weight is {3} kg and his height is {4} cm", name, surname, age, weightInKg, heightInCm);

                Console.WriteLine("\nBMI: {0:F} ", CalculateBmi(weightInKg, heightInCm));

                i++;
            }
        }
    }
}
