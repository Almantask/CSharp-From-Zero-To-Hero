using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start program
            Console.WriteLine("Hello World! Welcome to the first C# 2020 Bootcamp Homework.");
            Program.HW1();
            Console.WriteLine("Okay, Person #2:");
            Program.HW1();
        }
        static double GetBMI(double weight, int height) //calculates the BMI by receiving weight and height as parameters and dividing weight by height squared (kg/m^2)
        {
            //Function Declarations
            double BMI, hSquared;

            //convert cm to meters and square
            hSquared = (height / 100d);
            hSquared *= hSquared;

            BMI = weight / hSquared;

            return BMI;
        }
        static void HW1()
        {
            //Variable Declarations
            string name, surname;
            int age, height; //height in cm
            double weight; //weight in kg

            Console.WriteLine("What is your first name?");
            name = Console.ReadLine();
            Console.Write("Hello, " + name + '!' + " I just need a little extra information from you.\nSurname: ");
            surname = Console.ReadLine();
            Console.Write("Age: ");
            age = Convert.ToInt32(Console.ReadLine()); //Console.ReadLine returns a string, so you must convert it to the appropriate type.
            Console.Write("Weight(in kg): ");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Height(in cm): ");
            height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n" + name + ' ' + surname + " is " + age + " years old. Their weight is " + weight + "kg, and their height is " + height + "cm tall. This would make their BMI " + GetBMI(weight, height) + '.'); //bug @ Convert.ToString
        }
    }
}
