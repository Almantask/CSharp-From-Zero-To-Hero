using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            double weight;
            double height;

            for (int i = 0; i < 2; i++)
            {

                Console.WriteLine("Name: ");
                name = Console.ReadLine();

                Console.WriteLine("Age: ");
                age = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Weight in kg: ");
                weight = Double.Parse(Console.ReadLine());

                Console.WriteLine("Height in cm: ");
                height = Double.Parse(Console.ReadLine());

                Console.WriteLine(name + " is " + age + " years old, their weight is " + weight + " kg and their height is " + height + " cm.");

                double heightInMetres = height / 100.0;

                double bmi = weight / (heightInMetres * heightInMetres);
                Console.WriteLine(name + "'s BMI is " + bmi);
            }
        }
    }
}
