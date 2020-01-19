using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First person enter your data");

            Console.WriteLine("What is your first name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string surname = Console.ReadLine();
            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your weight?");
            float weight = float.Parse(Console.ReadLine());
            Console.WriteLine("What is your height?");
            float heightcm = float.Parse(Console.ReadLine());
            float heightm = heightcm / 100;
            float heightsq = heightm * heightm;
            float BMI = weight / heightsq;

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Surname: " + surname);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Weight: " + weight + "kg");
            Console.WriteLine("Height: " + heightcm + "cm");
            Console.WriteLine("BMI: " + BMI);

            Console.WriteLine();
            Console.WriteLine("Second person enter your data");

            Console.WriteLine("What is your first name?");
            string name2 = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string surname2 = Console.ReadLine();
            Console.WriteLine("What is your age?");
            int age2 = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your weight?");
            float weight2 = float.Parse(Console.ReadLine());
            Console.WriteLine("What is your height?");
            float heightcm2 = float.Parse(Console.ReadLine());
            float heightm2 = heightcm2 / 100;
            float heightsq2 = heightm2 * heightm2;
            float BMI2 = weight2 / heightsq2;

            Console.WriteLine("Name: " + name2);
            Console.WriteLine("Surname: " + surname2);
            Console.WriteLine("Age: " + age2);
            Console.WriteLine("Weight: " + weight2 + "kg");
            Console.WriteLine("Height: " + heightcm2 + "cm");
            Console.WriteLine("BMI: " + BMI2);

        }
    }
}
