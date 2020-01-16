using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the self-confidence crusher! Also known as the BMI Calculator. Please input your information below.");
            Console.WriteLine();

            // First Person Start.
            Console.Write("Can the first person please press enter to start!");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Enter your First Name: ");
            string firstName = Console.ReadLine();
            
            Console.Write("Enter your Last Name: ");
            string lastName = Console.ReadLine();
            
            Console.Write("Enter your Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter your Height (in CM) : ");
            float height = (float)Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your Weight (in KG): ");
            float weight = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine(firstName + " " + lastName + " is " + age + " years old, " + "his weight is " + weight + "kg and his height is " + height + "cm");
            Console.Write(firstName + " " + lastName + " has a BMI of: " + (weight/height/height)*10000);

            Console.WriteLine();
            Console.WriteLine();
            // Second Person Start.
            Console.Write("Can the second person please press enter to start!");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Enter your First Name: ");
            string firstName2 = Console.ReadLine();

            Console.Write("Enter your Last Name: ");
            string lastName2 = Console.ReadLine();

            Console.Write("Enter your Age: ");
            int age2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your Height (in CM) : ");
            float height2 = (float)Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your Weight (in KG): ");
            float weight2 = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine(firstName2 + " " + lastName2 + " is " + age2 + " years old, " + "his weight is " + weight2 + "kg and his height is " + height2 + "cm");
            Console.Write(firstName2 + " " + lastName2 + " has a BMI of: " + (weight2 / height2 / height2) * 10000);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Judging by our calculations, we have come to the conclusion that both users are not fit enough.");
            Console.WriteLine("Have a nice day!");
            Console.ReadLine();
        }
    }
}
