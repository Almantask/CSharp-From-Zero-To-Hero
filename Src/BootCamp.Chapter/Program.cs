using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string surename;
            int age;
            double weight;
            double height;

            GetPersonData();

            double BMI;
            CalculateBMI(weight, height);

            Console.WriteLine($"{name} {surename} is {age}, weight is {weight} kg and his height is {height} cm.");
            Console.WriteLine($"BMI is {BMI:f2}");




            void GetPersonData()
            {
                Console.WriteLine("Enter person name:");
                name = Console.ReadLine();
                Console.WriteLine("Enter person surename:");
                surename = Console.ReadLine();
                Console.WriteLine("Enter person age:");
                age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter person weight in kg:");
                weight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter person height in cm:");
                height = Convert.ToDouble(Console.ReadLine());
            }

            void CalculateBMI(double weight, double height)
            {
            double heightMt = height / 100.0;
            BMI = weight / (heightMt * heightMt);
            }


        }

    }
}
