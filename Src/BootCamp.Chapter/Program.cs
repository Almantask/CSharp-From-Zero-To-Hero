using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {

            Program.HomeworkOne();

        }
        public static void HomeworkOneB(string fname, string sname, float age, float weight, float height)
        {

            Console.WriteLine(fname + " " + sname + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " cm.");
            height = height / 100;
            var bmi = weight / height / height;
            Console.WriteLine("With BMI: " + bmi.ToString("0"));
        }
        public static void HomeworkOne()
        {
            Console.WriteLine("Enter First Name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Enter Surename: ");
            var surename = Console.ReadLine();
            Console.WriteLine("Enter age: ");
            float age = float.Parse(Console.ReadLine());
            Console.WriteLine("Weight: ");
            float weight = float.Parse(Console.ReadLine());
            Console.WriteLine("Height: ");
            float height = float.Parse(Console.ReadLine());

            Console.WriteLine(name + " " + surename + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " cm.");
            height = height / 100;
            var bmi = weight / height / height;
            Console.WriteLine("With BMI: " + bmi.ToString("0"));
        }
    }
}
