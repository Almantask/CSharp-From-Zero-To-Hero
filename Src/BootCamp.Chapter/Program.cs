using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string surname = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int weight = int.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine(name + " " + surname + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " cm.");

            double bmi = weight/((height/100) * (height / 100));

            Console.WriteLine("His BMI is " + bmi +".");

            // Up - first person, down - second.

            string secondName = Console.ReadLine();
            string secondSurname = Console.ReadLine();
            int secondAge = int.Parse(Console.ReadLine());
            int secondWeight = int.Parse(Console.ReadLine());
            double secondHeight = double.Parse(Console.ReadLine());

            Console.WriteLine(secondName + " " + secondSurname + " is " + secondAge + " years old, his weight is " + secondWeight + " kg and his height is " + secondHeight + " cm.");

            double secondBmi = secondWeight / ((secondHeight / 100) * (secondHeight / 100));

            Console.WriteLine("His BMI is " + secondBmi + ".");

            Console.ReadLine();

        }
    }
}
