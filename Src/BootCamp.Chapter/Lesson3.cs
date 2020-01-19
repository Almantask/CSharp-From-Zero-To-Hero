using System;
namespace BootCamp.Chapter
{
    public static class Lesson3
    {
        public static void Demo()
        {
            char again = 'y';

            while (again == 'y')
            {
                string firstName = RequestString("first name");

                string surname = RequestString("last name");

                int age = RequestInt("age in years");

                double weightInKilograms = RequestDouble("weight in kilograms");

                double heightInMeters = RequestDouble("height in meters");

                ReportBasicInfo(firstName, surname, age, weightInKilograms, heightInMeters);

                ReportBodyMassIndex(firstName, weightInKilograms, heightInMeters);

                again = RequestUserChoiceToRepeatOrNot();
            }
        }

        public static string RequestString(string prompt)
        {
            Console.Write("Please enter the person's " + prompt + ": ");
            return Console.ReadLine();
        }

        public static int RequestInt(string prompt)
        {
            Console.Write("Please enter the person's " + prompt + ": ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static double RequestDouble(string prompt)
        {
            Console.Write("Please enter the person's " + prompt + ": ");
            return Convert.ToDouble(Console.ReadLine());
        }

        public static void ReportBasicInfo(string firstName, string surname, int age, double weight, double height)
        {
            Console.WriteLine("\n" + firstName + " " + surname +
                " is " + age + " years old, " +
                "their weight is " + weight + " kg " +
                "and their height is " + height + " m.");
        }

        public static void ReportBodyMassIndex(string firstName, double weight, double height)
        {
            Console.WriteLine();
            Console.WriteLine(firstName + "s BMI is " + (CalculateBodyMassIndex(weight, height)) + ".");
        }

        public static double CalculateBodyMassIndex(double weight, double height)
        {
            return weight / (height * height);
        }

        public static char RequestUserChoiceToRepeatOrNot()
        {
            Console.WriteLine();
            Console.Write("Would you like to repeat this program? (y or n)");
            return Convert.ToChar(Console.ReadLine());
        }
    }
}

