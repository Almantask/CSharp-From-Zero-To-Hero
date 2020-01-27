using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            string name = Name();
            string surname = Surname();
            int age = Age();
            float height = Height();
            float weight = Weight();
            float bmi = Calculate(height, weight);

            //Printout
            Console.WriteLine($" Dear {name} {surname}, you are {age} years old. Your weight is {weight} kg and your height is {height} cms. This means that your BMI is {Math.Round(bmi, 2)}.");
        }

        public static string Name()
        {
            Console.WriteLine("Please enter your first name:");
            string name = (Console.ReadLine());
            return name;
        }

        public static string Surname()
        {
            Console.WriteLine("Please Enter your surname:");
            string surname = (Console.ReadLine());
            return surname;
        }

        public static int Age()
        {
            Console.WriteLine("Please enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            return age;
        }

        public static float Height()
        {
            Console.WriteLine("Please enter your height in cm:");
            float height = Convert.ToSingle(Console.ReadLine());
            return height;
        }

        public static float Weight()
        {
            Console.WriteLine("Please enter your weight in kg:");
            float weight = Convert.ToSingle(Console.ReadLine());
            return weight;
        }

        public static float Calculate(float height, float weight)
        {
            float bmi = weight / ((height / 100) * (height / 100));
            return bmi;
        }
    }
}
