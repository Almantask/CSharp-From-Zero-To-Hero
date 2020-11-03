using System;
using System.IO;
using System.Text;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your weight,unit is kg: ");
            float weight = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Please enter your height,unit is cm: ");
            float height = Convert.ToSingle(Console.ReadLine());

            float bmi = weight / ((height / 100) * (height / 100));

            Console.WriteLine($"{name} is {age} years old, weight is {weight} kg, height is {height} cm, BMI is {bmi}");
           
        }
    }
   
}