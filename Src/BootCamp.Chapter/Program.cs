using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input name.");
            string name = Console.ReadLine();
            Console.WriteLine("Input surname.");
            string surName = Console.ReadLine();
            Console.WriteLine("Input age.");
            string age = Console.ReadLine();
            Console.WriteLine("Input weight.");
            string weight = Console.ReadLine();
            Console.WriteLine("Input height..");
            string height = Console.ReadLine();

            float weightFloat = float.Parse(weight);
            float heightFloat = float.Parse(height);
            float ageFloat = float.Parse(age);


            Console.WriteLine($"{name} {surName} is {ageFloat} years old, weighs {weightFloat} kilograms, and is {heightFloat}cm tall.");

            float heightSquared = MathF.Sqrt(heightFloat);
            float bodyMassIndex = weightFloat / heightSquared;

            Console.WriteLine($"{name}'s BMI(Body Mass Index) is {bodyMassIndex}");

            Console.WriteLine("Input name.");
            string name2 = Console.ReadLine();
            Console.WriteLine("Input surname.");
            string surName2 = Console.ReadLine();
            Console.WriteLine("Input age.");
            string age2 = Console.ReadLine();
            Console.WriteLine("Input weight.");
            string weight2 = Console.ReadLine();
            Console.WriteLine("Input height.");
            string height2 = Console.ReadLine();

            float weightFloat2 = float.Parse(weight);
            float heightFloat2 = float.Parse(height);
            float ageFloat2 = float.Parse(age);


            Console.WriteLine($"{name2} {surName2} is {ageFloat2} years old, weighs {weightFloat2} kilograms, and is {heightFloat2}cm tall.");

            float heightSquared2 = MathF.Sqrt(heightFloat2);
            float bodyMassIndex2 = weightFloat2 / heightSquared2;

            Console.WriteLine($"{name2}'s BMI(Body Mass Index) is {bodyMassIndex2}");

        }
    }
}
