using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string surName = Console.ReadLine();
            string age = Console.ReadLine();
            string weight = Console.ReadLine();
            string height = Console.ReadLine();

            float weightFloat = float.Parse(weight);
            float heightFloat = float.Parse(height);
            float ageFloat = float.Parse(age);


            Console.WriteLine($"{name} {surName} is {ageFloat} years old, weighs {weightFloat} kilograms, and is {heightFloat}cm tall.");

            float heightSquared = MathF.Sqrt(heightFloat);
            float bodyMassIndex = weightFloat / heightSquared;

            Console.WriteLine($"{name}'s BMI(Body Mass Index) is {bodyMassIndex}");

        }
    }
}
