using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 2; i++)
            {
                string name;
                string surename;
                int age;
                double weight;
                double height;

                Console.Write("Enter the person's first name: ");
                name = Console.ReadLine();
                Console.Write("Enter the person's surename: ");
                surename = Console.ReadLine();
                Console.Write("Enter the person's age: ");
                age = int.Parse(Console.ReadLine());
                Console.Write("Enter the person's weight in kg: ");
                weight = double.Parse(Console.ReadLine());
                Console.Write("Enter the person's height in cm: ");
                height = double.Parse(Console.ReadLine());

                Console.WriteLine(name + " " + surename + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " cm.");

                Console.WriteLine(name + " " + surename + "BMI is: " + (weight) / ((height / 100) * (height / 100)));
                Console.WriteLine();
            }            
        }
    }
}
