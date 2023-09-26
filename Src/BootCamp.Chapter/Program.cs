// See https://aka.ms/new-console-template for more information
/*
 Read name, surename, age, weight (in kg) and height (in cm) from console. 
DO NOT HARDCODE (not int age = 5 etc).

    Print all the info based on the example message below:

Tom Jefferson is 19 years old, his weight is 50 kg and his height is 156.5 cm.

    Calculate and print body-mass index (BMI)
    Do it for 2 people (repeat the same thing twice)

 */
using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your surname: ");
            string surName = Console.ReadLine();
            int age;
            do
            {
                Console.Write("Enter your age: ");
                if (int.TryParse(Console.ReadLine(), out age))
                    break;
                else
                    Console.Write("Please enter number for age: ");
            } while (true);

            float weight;
            do
            {
                Console.Write("Enter your Weight(Kg): ");
                if (float.TryParse(Console.ReadLine(), out weight))
                    break;
                else
                    Console.Write("Please enter number for weight(Kg): ");
            } while (true);
            double height;
            do
            {
                Console.Write("Enter your height(cm): ");
                if (double.TryParse(Console.ReadLine(), out height))
                    break;
                else
                    Console.Write("Please enter number for height(cm): ");
            } while (true);


            Console.WriteLine(name + " " + surName + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " cm.");
            double bodyMassIndex = (weight / (height * height)) * 10000.0;
            Console.WriteLine("Body Mass Index measured for " + name + " " + surName + " is " + bodyMassIndex);
        }
    }
}
