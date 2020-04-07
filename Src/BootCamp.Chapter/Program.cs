using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! I will calculate your BMI. I just need to ask a few questions. What is your full name?");
            string fullname = Console.ReadLine();
            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How much do you weigh in kg?");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your height in cm?");
            double heightcm = Convert.ToDouble(Console.ReadLine());
            double heightm = heightcm / 100;
            double heightsq = heightm * heightm;
            Console.WriteLine("Great! Now I will calculate your BMI.");
            Console.WriteLine("Your name is " + fullname + ", you are " + age + " years old, you weigh " + weight + " kgs, and you are " + heightcm + " cm tall. your BMI is " + weight / heightsq + ".");


















        }
    }
}
