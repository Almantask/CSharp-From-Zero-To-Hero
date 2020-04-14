using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string fName = GetInput("Enter your first name: ");
            string lName = GetInput("Enter your last name: ");
            int age = int.Parse(GetInput("Enter your age: "));
            float height = float.Parse(GetInput("Enter your height (in cm): "));
            float weight = float.Parse(GetInput("Enter your weight (in kg): "));
            float bmi = weight / (height * height /10000);
            Console.WriteLine("{0} {1} is {2} years old, weighs {3} kg and is {4} cm tall.", fName, lName, age, weight, height);
            Console.WriteLine("{0}'s BMI is {1}.", fName, bmi);

            Console.ReadKey();
        }
        public static string GetInput(string a)
        {
            Console.Write(a);
            var b = Console.ReadLine();
            return b;
        }
    }
}
