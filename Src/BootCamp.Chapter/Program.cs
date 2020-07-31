using System;

namespace BootCamp.Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Tom Jefferson";
            var age = 19;
            var weight = 50;
            var height = 156.5;

            var bmi = 50 / (1.565 * 1.565);

            Console.WriteLine($"{name} is {age} years old, his weight is {weight} kg and his height is {height} cm.");
            Console.WriteLine($"{name}'s BMI is {bmi}");
        }
    }
}
