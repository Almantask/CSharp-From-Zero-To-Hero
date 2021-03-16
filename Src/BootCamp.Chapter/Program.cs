 using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string name,surname;
            int years;
            double weight, height;

            // Input user info
            Console.Write("Please enter your name: ");
            name = Console.ReadLine();
            Console.Write("Please enter your surname: ");
            surname = Console.ReadLine();
            Console.Write("Please enter your ages: ");
            years = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter your weigth in kg: ");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter your height in cm: ");
            height = Convert.ToDouble(Console.ReadLine()) / 100;

            Console.WriteLine($"{name} {surname} is {years} years old,his weight is {weight} weight and his height is {height}m");

            double bmi = weight / Math.Pow(height, height);

            Console.WriteLine($"Your BMI is {bmi:N2}");


            // Input user info
            Console.Write("Please enter your name: ");
            name = Console.ReadLine();
            Console.Write("Please enter your surname: ");
            surname = Console.ReadLine();
            Console.Write("Please enter your ages: ");
            years = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter your weigth in kg: ");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter your height in cm: ");
            height = Convert.ToDouble(Console.ReadLine()) / 100;

            Console.WriteLine($"{name} {surname} is {years} years old,his weight is {weight} weight and his height is {height}m");

            bmi = weight / Math.Pow(height, height);

            Console.WriteLine($"Your BMI is {bmi:N2}");

        }
    }
}
