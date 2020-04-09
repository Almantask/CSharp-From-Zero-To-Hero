using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your first name?");
            string name = Console.ReadLine();

            Console.WriteLine("What's your surname?");
            string surname = Console.ReadLine();

            Console.WriteLine("How old are you?");
            var age = Console.ReadLine();

            Console.WriteLine("How much do you weight in kg?");
            var weight = float.Parse(Console.ReadLine());

            Console.WriteLine("How tall are you in cm?");
            var height = float.Parse(Console.ReadLine());

            float heightInMetres = height / 100;

            float bodyMassIndex = weight / (heightInMetres * heightInMetres);

            Console.WriteLine(name + " " + surname + " is " + age + " years old, his weight is " + weight + "kg and his height is " + height + " cm");

            Console.WriteLine("Their BMI is: " + bodyMassIndex);
        }
    }
}
