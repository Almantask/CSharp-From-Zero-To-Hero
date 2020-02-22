using System;
using System.Collections.Generic;
using System.IO;
using Console = System.Console;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            const int personCount = 2;

            for (int i = 0; i < personCount; i++)
            {
                Console.Write("Input your first name: ");
                string firstName = Console.ReadLine();
                Console.Write("Input your last name: ");
                string lastName = Console.ReadLine();
                Console.Write("Input your age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input your height in cm: ");
                double height = (float)Convert.ToDouble(Console.ReadLine());
                Console.Write("Input your weight in kg: ");
                int weight = Convert.ToInt32(Console.ReadLine());

                float BMI = (float)(weight / (height / 100 * height / 100));

                Console.WriteLine($"{firstName} {lastName} is {age} years old, his weight is {weight} kg and his height is {height} cm. His BMI is {BMI}");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
