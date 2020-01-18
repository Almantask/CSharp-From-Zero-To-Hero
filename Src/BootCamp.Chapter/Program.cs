using System;
using System.Diagnostics;

namespace BootCamp.Chapter
{
    public static class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 2; i++)
            {
                string name;
                Console.Write("Please, tell me your name: ");
                name = Console.ReadLine();

                
                string surname;
                Console.Write("Please, tell me your surname: ");
                surname = Console.ReadLine();

                
                int age = 0;
                Console.Write("Please, tell me your age: ");
                age = Convert.ToInt32(Console.ReadLine());

                
                double weight = 0;
                Console.Write("Please, tell me your weight: ");
                weight = Convert.ToDouble(Console.ReadLine());

                
                double height = 0;
                Console.Write("Please, tell me your height (in cm): ");
                height = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\n{0} {1} is {2} years old, his weight is {3} kg and his height is {4} cm.", name, surname, age, weight, height);

                double BMI = Math.Round(CalculateBMI(weight, height), 2);

                Console.WriteLine("His BMI is: {0} \n", BMI);
            }

        }
        static double CalculateBMI(double weight, double height)
        {
            return weight / (Math.Pow((height / 100), 2));
        }
    
    }
}
