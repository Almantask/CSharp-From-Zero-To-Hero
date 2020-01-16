using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start program
            Console.WriteLine("Hello World! Welcome to the first C# 2020 Bootcamp Homework.");
            PromptUser();
            Console.WriteLine("Okay, Person #2:");
            PromptUser();
        }
        static double GetBMI(double weight, int height) //calculates the BMI by receiving weight and height as parameters and dividing weight by height squared (kg/m^2)
        {
            double hSquared = (height / 100d); //convert cm to meters
            hSquared *= hSquared; //square
            return (weight / hSquared);
        }
        static void PromptUser()
        {
            Console.WriteLine("What is your first name?");
            string name = Console.ReadLine();
            Console.Write("Hello, " + name + '!' + " I just need a little extra information from you.\nSurname: ");
            string surname = Console.ReadLine();
            Console.Write("Age: ");
            int age = Convert.ToInt32(Console.ReadLine()); //Console.ReadLine returns a string, so you must convert it to the appropriate type.
            Console.Write("Weight(in kg): ");
            double weight = Convert.ToDouble(Console.ReadLine()); //weight in kg
            Console.Write("Height(in cm): ");
            int height = Convert.ToInt32(Console.ReadLine()); //height in cm
            Console.WriteLine("\n" + name + " " + surname + " is " + age + " years old. Their weight is " + weight + "kg, and their height is " + height + "cm tall. This would make their BMI " + GetBMI(weight, height) + '.'); //bug @ Convert.ToString
        }
    }
}
