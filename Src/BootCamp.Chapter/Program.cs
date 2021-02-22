using System;
using System.Collections.Concurrent;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your First Name ?");
            string firstName = Console.ReadLine();

            Console.WriteLine("What is your Last Name ?");
            string lastName = Console.ReadLine();

            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How much do you weight?");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your height in cm ?");
            double height = Convert.ToDouble(Console.ReadLine());

            double bmi = (weight / height / height) * 10000;

            Console.WriteLine(firstName + " " + lastName + " is " + age + " years old, his weight is " + weight + "kg and his height is " + height + "cm.");
            Console.WriteLine("His BMI is " + bmi);

            Console.WriteLine("What is your First Name ?");
            string firstName2 = Console.ReadLine();

            Console.WriteLine("What is your Last Name ?");
            string lastName2 = Console.ReadLine();

            Console.WriteLine("How old are you?");
            int age2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How much do you weight?");
            double weight2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your height in cm ?");
            double height2 = Convert.ToDouble(Console.ReadLine());

            double bmi2 = (weight / height / height) * 10000;

            Console.WriteLine(firstName2 + " " + lastName2 + " is " + age2 + " years old, his weight is " + weight2 + "kg and his height is " + height2 + "cm.");
            Console.WriteLine("His BMI is " + bmi2);

        }
    }
}