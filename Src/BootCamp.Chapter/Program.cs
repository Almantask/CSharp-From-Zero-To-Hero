using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void PersonInfo()
        {
            Console.Write("First name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Weight (kg): ");
            float weight = float.Parse(Console.ReadLine());
            Console.Write("Height (cm): ");
            float height = float.Parse(Console.ReadLine());
            
            Console.WriteLine(firstName + " " + lastName + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " cm.");

            float heightMetres = height / 100;
            float bmi = weight / heightMetres * heightMetres;
            Console.WriteLine("BMI: " + bmi); 
        }
        static void Main(string[] args)
        {
            PersonInfo();
            PersonInfo();
        }
    }
}