using System;

namespace Homework1
{
    class Program
    {
        static void Main()
        {

            {
                //Introducction
                Console.WriteLine("introduce the following information in order to calculate your BMI");

                //Subject data
                Console.Write("Full name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Age: ");
                float age = int.Parse(Console.ReadLine());

                Console.WriteLine("Weight in Kg: ");
                double weight = double.Parse(Console.ReadLine());

                Console.WriteLine("Height in Cm: ");
                double height = double.Parse(Console.ReadLine());
                
                //Calculated BMI
                double heightconvertion = height / 100;
                double totalBMI = weight / (heightconvertion * heightconvertion);

                //Result
                Console.WriteLine(name + " is " + age + " years old with a weight of " + weight + " and a height of " + height + " your total BMI is: " + (Math.Round(totalBMI, 1)));

            }

        }
    }
}

