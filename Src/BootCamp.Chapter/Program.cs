using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter in your full name");
            string myName = Console.ReadLine();
            Console.WriteLine("Enter in your age");
            string age = Console.ReadLine();
            Console.WriteLine("Enter in your height");
            string height = Console.ReadLine();
            Console.WriteLine("Enter in your weight.");
            string weight = Console.ReadLine();

            double heighttwo = (double.Parse(height) * .01);
            double bmi = double.Parse(weight) / (heighttwo * heighttwo);

            Console.WriteLine(myName + " is " + int.Parse(age) + " years old, his height is " + double.Parse(height) + "cm, and his weight is " + double.Parse(weight) + "kg.");
            Console.WriteLine("BMi is: " + bmi);
        }
    }
}
