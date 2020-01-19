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
                string firstName = RequestString("Please enter first name:");

                string surname = RequestString("Please enter last name:");

                int age = RequestInt("Please enter age in years:");

                float weightInKilograms = RequestFloat("Please enter weight in kilograms:");

                float heightInMeters = RequestFloat("Please enter height in meters:");

                ReportBasicInfo(firstName, surname, age, weightInKilograms, heightInMeters);

                ReportBodyMassIndex(firstName, weightInKilograms, heightInMeters);

                again = RequestUserChoiceToRepeatOrNot();
            }
        }

        public static string RequestString(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        public static int RequestInt(string prompt)
        {
            Console.Write(prompt);
            return Convert.ToInt32(Console.ReadLine());
        }

        public static float RequestFloat(string prompt)
        {
            Console.Write(prompt);
            return Convert.ToFloat(Console.ReadLine());
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
            return weight / height / height);
        }

        public static char RequestUserChoiceToRepeatOrNot()
        {
            Console.WriteLine();
            Console.Write("Would you like to repeat this program? (y or n)");
            return Convert.ToChar(Console.ReadLine());
        }
    }
}

