using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Hello Friend!");

                Console.WriteLine("Please enter your name!");
                string name = Console.ReadLine();

                Console.WriteLine("Please enter your surname!");
                string surname = Console.ReadLine();

                Console.WriteLine("Please tell me your age!");
                string age = Console.ReadLine();

                Console.WriteLine("How much do you weight in kg?");
                string kg = Console.ReadLine();
                int weight = int.Parse(kg);

                Console.WriteLine("What is your height in cm?");
                string cm = Console.ReadLine();
                double height = double.Parse(cm);

                double bmi = (double)(weight / Math.Pow(height / 100.0, 2));
                bmi = Math.Round(bmi, 2);

                Console.WriteLine($"{name} {surname} is {age} years old, his weight is {weight} kg and his height is {height} cm.");
                Console.WriteLine($"{name} {surname} BMI is {bmi}.");
            }
        }
    }
}
