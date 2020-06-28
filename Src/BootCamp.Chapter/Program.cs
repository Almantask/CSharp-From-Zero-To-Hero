using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintPersonInformation();
            PrintPersonInformation();
        }
        static string ReadName()
        {
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            return name;
        }
        static int ReadAge()
        {
            Console.WriteLine("Enter age ");
            string age = Console.ReadLine();
            int realAge = int.Parse(age);
            return realAge;
        }
        public static double ReadWeight()
        {
            Console.WriteLine("Enter weight in kg ");
            string weight = Console.ReadLine();
            double weightInKilograms = double.Parse(weight);
            return weightInKilograms;
        }
        static double ReadHeight()
        {
            Console.WriteLine("Enter height in cm ");
            string height = Console.ReadLine();
            double heightInCentemeters = double.Parse(height);
            return heightInCentemeters;
        }
        static double CalculateBMI(double weight, double height)
        {
            double heightInMeters = height / 100.0;
            double BMI = weight / (heightInMeters * heightInMeters);
            return BMI;
        }
        static void PrintPersonInformation()
        {
            string name = ReadName();
            int age = ReadAge();
            double weight = ReadWeight();
            double height = ReadHeight();

            Console.WriteLine("You have entered:");
            Console.WriteLine(name + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " cm.");
            Console.WriteLine("BMI: " + CalculateBMI(weight, height));
        }
    }
}

