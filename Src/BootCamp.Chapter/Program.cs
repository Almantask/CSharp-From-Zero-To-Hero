using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Person();
            Person();
        }

        static void Person()
        {
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter age ");
            string age = Console.ReadLine();
            int.Parse(age);
            Console.WriteLine("Enter weight ");
            string weight = Console.ReadLine();
            double weightInDouble = double.Parse(weight);
            Console.WriteLine("Enter height in cm ");
            string height = Console.ReadLine();
            double heightInDouble = double.Parse(height);
            double heightInMeters = heightInDouble / 100.0;

            double BMI = weightInDouble / (heightInMeters * heightInMeters);

            Console.WriteLine("You have entered:");
            Console.WriteLine(name + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " cm.");
            Console.WriteLine("BMI: " + BMI);
        }
    }
}
