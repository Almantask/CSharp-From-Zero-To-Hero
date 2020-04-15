using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bmi Calculator
            Console.WriteLine("BMI Calculator:");
            
            //Full Name
            Console.Write("Full Name: ");
            string name = Console.ReadLine();

            //Age
            Console.Write("Age: ");
            int age = int.Parse( Console.ReadLine());

            //Weight
            Console.Write("Weight (kg): ");
            float weight =float.Parse( Console.ReadLine());

            //Height
            Console.Write("Height (cm): ");
            float height = float.Parse(Console.ReadLine());

            //Bmi
            float bmi = weight / (height * height) * 10000;

            Console.WriteLine(name +" is " + age+" years old, his weight is " + weight + " kg, his height is "+height+ " and his bmi is " +bmi+".");

        }
    }
}
