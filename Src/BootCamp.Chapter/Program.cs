using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            char again = 'y';

            while (again == 'y')
            {
                RequestInput("first name");
                string firstName = Console.ReadLine();

                RequestInput("last name");
                string surname = Console.ReadLine();

                RequestInput("age in years");
                int age = Convert.ToInt32(Console.ReadLine());

                RequestInput("weight in kilograms");
                double weight = Convert.ToDouble(Console.ReadLine());

                RequestInput("height in centimeters");
                double height = Convert.ToDouble(Console.ReadLine());

                ReportBasicInfo(firstName, surname, age, weight, height);

                ReportBmi(firstName, weight, height);

                again = RequestUserChoiceToRepeatOrNot();
            }
        }

        private static void RequestInput(string prompt)
        {
            Console.Write("Please enter the person's " + prompt + ": ");
        }

        private static void ReportBasicInfo(string firstName, string surname, int age, double weight, double height)
        {
            Console.WriteLine("\n" + firstName + " " + surname +
                " is " + age + " years old, " +
                "their weight is " + weight + " kg " +
                "and their height is " + height + " cm.");
        }

        private static void ReportBmi(string firstName, double weight, double height)
        {
            Console.WriteLine("\n" + firstName + "'s BMI is " + (CalculateBmi(weight, height)) + ".");
        }

        private static double CalculateBmi(double weight, double height)
        {
            double heightInMeters = height * .01;
            return weight / (heightInMeters * heightInMeters);
        }

        private static char RequestUserChoiceToRepeatOrNot()
        {
            Console.Write("\nWould you like to repeat this program? (y or n)");
            return Convert.ToChar(Console.ReadLine());
        }

    }
}

