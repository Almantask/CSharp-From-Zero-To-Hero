using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // stores the biographical information of the user
            Console.Write("Input your first name and press enter: ");
            string firstName = Console.ReadLine();

            Console.Write("Input your last name and press enter: ");
            string lastName = Console.ReadLine();

            Console.Write("Input your age and press enter: ");
            var age = Console.ReadLine();

            Console.Write("Input your weight (in kg) and press enter: ");
            var weight = Console.ReadLine();

            Console.Write("Input your height (in cm) and press enter: ");
            var heightCm = Console.ReadLine();

            // outputs the information into a sentence about the user
            Console.WriteLine(firstName + " " + lastName + " is " + age + " years old, his weight is " + weight + " kg and his height is " + heightCm + " cm.");

            // converts centimeter to meter
            var heightM = Convert.ToDecimal(heightCm) / 100;

            // calculates user's BMI
            var heightMSqr = heightM * heightM;
            var bmi = Convert.ToDecimal(weight) / heightMSqr;
            Console.WriteLine(firstName + "'s body-mass index (BMI) is: " + bmi + ".");
        }
    }
}
