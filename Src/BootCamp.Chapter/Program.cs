using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Can this method work for both Tom Jefferson and the second person?

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("How old are you?");
            var age = Console.ReadLine();
            int ageNumber = Convert.ToInt32(age);

            Console.WriteLine("How much do you weigh in kg?");
            var weight = Console.ReadLine();
            double weightKg = Convert.ToDouble(weight);

            Console.WriteLine("How tall are you in cm?");
            var height = Console.ReadLine();
            double heightcm = Convert.ToDouble(height);

            double heightMeters = heightcm / 100.0;
            double heightMetersSquared = heightMeters * heightMeters;
            double bmi = weightKg / heightMetersSquared;

            Console.WriteLine("Thank you for using my BMI calculator," + " " + (name) + " " + "your BMI is" + " " + (bmi));
        }
    }
}
