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
            ReadPersonDetails();
             
            ReadPersonDetails();

        }
         static void ReadPersonDetails()
        {
            Console.WriteLine("\nEnter the First name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the Surname:");
            string surName = Console.ReadLine();
            Console.WriteLine("Enter the age:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the weight(kg):");
            decimal weight = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height(cm):");
            decimal height = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"\n{firstName} {surName} is {age} years old, his weight is {weight} kg and his height is {height} cm");
            decimal Bmi = CalculateBMI(weight, height);
            Console.WriteLine($"\nBMI of {firstName} {surName} is {Bmi}");
        }

        static decimal CalculateBMI(decimal weight, decimal height)
        {
            decimal high = (height / 100) * (height / 100);
            decimal bmi = weight / high;
            return bmi;
        }
    }
}
