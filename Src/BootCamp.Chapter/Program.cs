using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Tom";
            string surename = "Jefferson";
            int age = 19;
            double weight = 50;
            double height = 156.5;
            double BMI = (weight) / ((height / 100) * 2);
            Console.WriteLine($"{name} {surename} is {age} years old, his weight is {weight} kg and his height is {height} cm , his BMI is {Math.Round(BMI, 2)}");

            string name2 = "Mario";
            string surename2 = "Balotelli";
            int age2 = 19;
            double weight2 = 80;
            double height2 = 186.5;
            double BMI2 = (weight2) / ((height2 / 100) * 2);
            Console.WriteLine($"{name2} {surename2} is {age2} years old, his weight is {weight2} kg and his height is {height2} cm , his BMI is {Math.Round(BMI2, 2)}");
        }
    }
}
