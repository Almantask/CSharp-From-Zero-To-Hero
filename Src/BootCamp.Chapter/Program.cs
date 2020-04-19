using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = ("Tom Jefferson");
            int age1 = 19;
            double weight1 = 50;
            double height1 = 156.5;
            double height1Meters = height1 / 100;
            double height1MetersSquared = height1Meters * height1Meters;
            double bmiTom = weight1 / height1MetersSquared;

            Console.WriteLine(name1 + " " + "is" + " " + age1 + " " + "years old" + "," + " " + "he weighs" +  " " + weight1 + "kg and is" + " " + height1 + "cm" + " " + "tall");
            Console.WriteLine("Meaning he has a BMI of" + " " + bmiTom);
            Console.WriteLine("Let's see what your BMI is by entering in your details below");

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

            Console.WriteLine("Thank you for using my BMI calculator," + " " + name + " " + "your BMI is" + " " + bmi);
        }
    }
}
