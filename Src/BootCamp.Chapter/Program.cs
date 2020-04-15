using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Bmi1(number:1);

            Bmi1(number:2);
        }
        private static void Bmi1(int number)
        {
            Console.WriteLine("Person #" + number+ ":" );

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

            Console.WriteLine(" ");

        }
        
    }
}
