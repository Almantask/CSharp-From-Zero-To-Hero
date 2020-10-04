using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 3; i++)
            {
                int personCounter = i + 1;
                Console.Write("Enter first name for person " + personCounter + ": ");
                var name = Console.ReadLine();
                Console.Write("Enter last name for person " + personCounter + ": ");
                var surname = Console.ReadLine();
                Console.Write("Enter age for person " + personCounter + ": ");
                var age = int.Parse(Console.ReadLine());
                Console.Write("Enter weight for person " + personCounter + ": ");
                var weight = double.Parse(Console.ReadLine());
                Console.Write("Enter height for person " + personCounter + ": ");
                var height = double.Parse(Console.ReadLine());

                Console.WriteLine(name + " " + surname + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " cm");
                var heightConverted = height / 100; // height in meters
                var bmi = weight / (heightConverted * heightConverted);
                Console.WriteLine("BMI: " + bmi + "\n");
            }
        }
    }
}
