using System;

namespace BootCamp.Chapter
{
    public static class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 2; i++)
            {
                Console.Write("Please, tell me your name: ");
                string name = Console.ReadLine();

                Console.Write("Please, tell me your surname: ");
                string surname = Console.ReadLine();

                Console.Write("Please, tell me your age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.Write("Please, tell me your weight: ");
                double weight = Convert.ToDouble(Console.ReadLine());

                Console.Write("Please, tell me your height (in cm): ");
                double height = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\n{0} {1} is {2} years old, his weight is {3} kg and his height is {4} cm.", name, surname, age, weight, height);

                double BMI = Math.Round(CalculateBmi(weight, height), 2);

                Console.WriteLine("His BMI is: {0} \n", BMI);
            }

        }
        static double CalculateBmi(double weight, double height)
        {
            return weight / (Math.Pow((height / 100), 2));
        }
    
    }
}
