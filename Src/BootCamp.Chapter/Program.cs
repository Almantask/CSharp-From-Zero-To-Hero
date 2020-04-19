using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("PERSON 1:");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Surname: ");
            string surname = Console.ReadLine();

            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Weight (kg): ");
            float weightkg = float.Parse(Console.ReadLine());

            Console.Write("Height (cm): ");
            float heightcm = float.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("PERSON 2:");

            Console.Write("Name: ");
            string name2 = Console.ReadLine();

            Console.Write("Surname: ");
            string surname2 = Console.ReadLine();

            Console.Write("Age: ");
            int age2 = int.Parse(Console.ReadLine());

            Console.Write("Weight (kg): ");
            float weightkg2 = float.Parse(Console.ReadLine());

            Console.Write("Height (cm): ");
            float heightcm2 = float.Parse(Console.ReadLine());


            Console.WriteLine();

            float bmi;
            float bmi2;

            float meter = heightcm / 100;
            float meter2 = heightcm2 / 100;

            bmi = weightkg / (meter * meter);
            bmi2 = weightkg2 / (meter * meter);

            Console.WriteLine("Output:");
            Console.WriteLine(name + " " + surname + " is " + age + " years old, " + "his weight is " + weightkg + " kg " + "and his height is " + heightcm + " cm.");
            Console.WriteLine("BMI: " + bmi);
            Console.WriteLine();
            Console.WriteLine(name2 + " " + surname2 + " is " + age2 + " years old, " + "his weight is " + weightkg2 + " kg " + "and his height is " + heightcm2 + " cm.");
            Console.WriteLine("BMI: " + bmi2);
        }
    }
}
