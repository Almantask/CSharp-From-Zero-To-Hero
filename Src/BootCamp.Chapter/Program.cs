using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Mahdi";
            int age = 29;
            double weight = 80.9;
            float height = 166.6f;
            Console.WriteLine($"{name} is {age} years old, his weight is {weight} kg and his height is {height} cm. ");
            //BMI calculations
            double bmi = weight * 703 / height / height;
            Console.WriteLine(bmi);
            //Code
        }
    }
}
