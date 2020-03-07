using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            const string name = "Mahdi";
            const int age = 29;
            const double weight = 80.9;
            const float height = 166.6f;
            Console.WriteLine($"{name} is {age} years old, his weight is {weight} kg and his height is {height} cm. ");
            //BMI calculations
            double bmi = weight * 703 / height / height;
            Console.WriteLine(bmi);
            //Code
        }
    }
}
