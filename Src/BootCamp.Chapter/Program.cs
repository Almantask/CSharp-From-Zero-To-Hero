using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Hancock";
            string surname = "Johnson";
            int age = 20;
            float weight = 81;
            float heightcm = 180;
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

            string name2 = "Debra";
            string surname2 = "Jones";
            int age2 = 22;
            float weight2 = 45;
            float heightcm2 = 165;
            float heightm2 = heightcm2 / 100;
            float heightsq2 = heightm2 * heightm2;
            float BMI2 = weight2 / heightsq2;

            Console.WriteLine("Name: " + name2);
            Console.WriteLine("Surname: " + surname2);
            Console.WriteLine("Age: " + age2);
            Console.WriteLine("Weight: " + weight2 + "kg");
            Console.WriteLine("Height: " + heightcm2 + "cm");
            Console.WriteLine("BMI: " + BMI2);

            Console.ReadLine();
        }
    }
}
