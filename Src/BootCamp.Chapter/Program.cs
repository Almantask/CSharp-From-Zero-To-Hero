using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            while (x > 0)
            {
                //Thank you for reviewing my code. You guys are amazing.

                Console.Write("Hello. What is your name? ");
                string name = Console.ReadLine();

                Console.Write("What is your last name? ");
                string surname = Console.ReadLine();

                Console.Write("How old are you? ");
                string age = Console.ReadLine();

                Console.Write("How much do you weigh? ");
                string weight = Console.ReadLine();

                Console.Write("How tall are you? ");
                string height = Console.ReadLine();

                double bmi = Convert.ToInt32(weight) / Convert.ToInt32(height) ^ 2;

                Console.WriteLine($"{name} {surname} is {age} years old, his weight is {weight} kg and his height is {height} cm.");

                x -= 1;
            }
        }
    }
}
