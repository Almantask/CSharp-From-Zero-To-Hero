using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = GetPersonData("name");
            string surename = GetPersonData("surename");
            int age = int.Parse(GetPersonData("age"));
            double weight = double.Parse(GetPersonData("weight"));
            double height = double.Parse(GetPersonData("height in cm"));
            double BMI = CalculateBMI(weight, height);
            Console.WriteLine($"{name} {surename} is {age}, weight is {weight} kg and height is {height} cm.");
            Console.WriteLine($"BMI is {BMI:f2}");

            name = GetPersonData("name");
            surename = GetPersonData("surename");
            age = int.Parse(GetPersonData("age"));
            weight = double.Parse(GetPersonData("weight"));
            height = double.Parse(GetPersonData("height in cm"));
            BMI = CalculateBMI(weight, height);
            Console.WriteLine($"{name} {surename} is {age}, weight is {weight} kg and height is {height} cm.");
            Console.WriteLine($"BMI is {BMI:f2}");
        }

        public static string GetPersonData(string text)
        {
            Console.WriteLine($"Enter person {text}:");
            return Console.ReadLine();
        }

        public static double CalculateBMI(double weight, double height)
        {
            double heightMt = height / 100.0;
            return weight / (heightMt * heightMt);
        }

    }
}
