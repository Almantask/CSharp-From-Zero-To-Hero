using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            GetPersonData();
            GetPersonData();


            void GetPersonData()
            {
                Console.WriteLine("Enter person name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter person surename:");
                string surename = Console.ReadLine();
                Console.WriteLine("Enter person age:");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter person weight in kg:");
                double weight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter person height in cm:");
                double height = Convert.ToDouble(Console.ReadLine());
                double heightMt = height / 100.0;
                Console.WriteLine($"{name} {surename} is {age}, weight is {weight} kg and his height is {height} cm.");
                var BMI = weight / (heightMt * heightMt);
                Console.WriteLine($"BMI is {BMI:f2}");

            }


        }
    }
}
