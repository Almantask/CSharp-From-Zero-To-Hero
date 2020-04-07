using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! I will calculate your BMI. I just need to ask a few questions. What is your full name?");
            string fullname = Console.ReadLine();

            Console.WriteLine("How old are you?(only numbers please)");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How much do you weigh in kg?");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your height in cm?");
            double heightcm = Convert.ToDouble(Console.ReadLine());
            double heightsq = (heightcm / 100) * (heightcm/100);
            double bmi = weight / heightsq;
            
            Console.WriteLine("Great! Now I will calculate your BMI.");
            Console.WriteLine("Your name is " + fullname + ", you are " + age + " years old, you weigh " + weight + " kgs, and you are " + heightcm + " cm tall. your BMI is " + bmi + ".");

            //second person

            Console.WriteLine("Now for the second person! I will calculate your BMI. I just need to ask a few questions. What is your full name?");
            string fullname2 = Console.ReadLine();

            Console.WriteLine("How old are you?(only numbers please)");
            int age2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How much do you weigh in kg?");
            double weight2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your height in cm?");
            double heightcm2 = Convert.ToDouble(Console.ReadLine());
            double heightsq2 = (heightcm / 100) * (heightcm / 100);
            double bmi2 = weight / heightsq;

            Console.WriteLine("Great! Now I will calculate your BMI.");
            Console.WriteLine("Your name is " + fullname2 + ", you are " + age2 + " years old, you weigh " + weight2 + " kgs, and you are " + heightcm2 + " cm tall. your BMI is " + bmi2 + ".");







        }
    }
}
