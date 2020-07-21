using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("How old are you?");
            string sAge = Console.ReadLine();
            int age = int.Parse(sAge);

            Console.WriteLine("How much do you weigh in kgs?");
            string sWeight = Console.ReadLine();
            float weight = float.Parse(sWeight);

            Console.WriteLine("How tall are you in cm?");
            string sHeight = Console.ReadLine();
            float height = float.Parse(sHeight);

            float bmiFormula = weight / height / height;

            Console.WriteLine(firstName + " is " + age + " years old. They weigh " + weight +
                "kgs and their height is " + height + ". " + firstName + "'s BMI is " + bmiFormula);
        }
    }
}
