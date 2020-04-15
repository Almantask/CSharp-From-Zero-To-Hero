using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Bmi1();

            Bmi2();
        }
        private static void Bmi1()
        {
            Console.WriteLine("Person #1:");

            Console.Write("Full Name: ");
            string name1 = Console.ReadLine();

            Console.Write("Age: ");
            int age1 = int.Parse(Console.ReadLine());

            Console.Write("Weight (kg): ");
            float weight1 = float.Parse(Console.ReadLine());

            Console.Write("Height (cm): ");
            float height1 = float.Parse(Console.ReadLine());

            float bmi1 = weight1 / (height1 * height1) * 10000;

            Console.WriteLine(name1 + " is " + age1 + " years old, his weight is " + weight1 + " kg, his height is " + height1 + " and his bmi is " + bmi1 + ".");
        }
        private static void Bmi2()
        {
            Console.WriteLine(" ");

            Console.WriteLine("Person #2:");

            Console.Write("Full Name: ");
            string name2 = Console.ReadLine();

            Console.Write("Age: ");
            int age2 = int.Parse(Console.ReadLine());

            Console.Write("Weight (kg): ");
            float weight2 = float.Parse(Console.ReadLine());

            Console.Write("Height (cm): ");
            float height2 = float.Parse(Console.ReadLine());

            float bmi2 = weight2 / (height2 * height2) * 10000;

            Console.WriteLine(name2 + " is " + age2 + " years old, his weight is " + weight2 + " kg, his height is " + height2 + " and his bmi is " + bmi2 + ".");
        }
        
    }
}
