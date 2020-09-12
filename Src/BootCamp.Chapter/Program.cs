using System;
using System.Runtime.Intrinsics.X86;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Name: ");
                var name = Console.ReadLine();
                Console.WriteLine("Surname: ");
                var surName = Console.ReadLine();
                Console.WriteLine("Age: ");
                var age = Console.ReadLine();
                Console.WriteLine("Weight");
                var weight = Console.ReadLine();
                Console.WriteLine("height");
                var height = Console.ReadLine();

                var statement = name + " " + surName + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " cm.";

                Console.WriteLine(statement);

                Console.WriteLine("His BMI is " + Bmi(double.Parse(weight), double.Parse(height)) + ".");
            }
        }

        private static double Bmi(double weight, double height)
        {
            var BMI = weight / ((height / 100) * (height / 100));
            return BMI;
        }
    }
}
