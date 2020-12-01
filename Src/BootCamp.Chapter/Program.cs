using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            GetDetails();
            GetDetails();
        }

        public static void GetDetails()
        {
            Console.Write("Enter Name: ");
            //Read name, surname, age, weight (in kg) and height (in cm) from console. DO NOT
            string name = Console.ReadLine();

            Console.Write("Enter Surname: ");
            string surname = Console.ReadLine();

            Console.Write("Enter Age: ");
            string age = Console.ReadLine();

            Console.Write("Enter Weight: ");
            string weight = Console.ReadLine();

            Console.Write("Enter Height: ");
            string height = Console.ReadLine();

            // [name] [surname] is [age] years old, his weight is [weight] kg and his height is [height] cm.
            Console.WriteLine($"{name} {surname} is {age} years old, his weight is {weight} kg and his height is {height} cm");

            // calculate BMI
            double bmi = CalculateBmi(weight, height);
            Console.WriteLine($"{name}'s BMI is {Convert.ToString(bmi)}");
        }

        /// <summary>
        /// Calculate BMI = m/h^2
        /// </summary>
        /// <returns></returns>
        public static double CalculateBmi(string weight, string height)
        {
            double bmi = Convert.ToDouble(weight) / (Convert.ToDouble(height) * Convert.ToDouble(height));
            return bmi;
        }
    }
}
