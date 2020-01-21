using System;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            Console.WriteLine("Welcome to the self-confidence crusher! Also known as the BMI Calculator. Please input your information below.");
            Console.WriteLine();

            // First Person Start.
            Console.WriteLine("Hello person one, please enter your details below.");

            Person();

            Console.WriteLine();

            // Second Person Start
            Console.WriteLine("Hello person two, let's compare you with person one.");

            Person();


            // End.
            Console.WriteLine("\n");

            Console.WriteLine("Judging by our calculations, we have come to the conclusion that both users are not within the healthy range " +
                              "\nof the self-confidence crusher BMI Calculator.");

            Console.WriteLine("\nHave a nice day!");
            Console.ReadLine();
        }


        public static void Person()
        {
            string firstName = EnterName("Please enter your first name: ");
            string lastName = EnterName("Please enter your last name: ");

            int age = Age("Enter your Age: ");

            float weight = Stats("Please enter your weight in KG: ");
            float height = Stats("Please enter your weight in Meters: ");

            float bmi = CalculateBmi(weight, height);


            Console.Write(firstName + " " + lastName + " is " + age + " years old and has a BMI of: " + bmi + "\n");
        }


        public static string EnterName(string message)
        {
            Console.Write(message);

            return Console.ReadLine();
        }

        public static int Age(string message)
        {
            Console.Write(message);

            return Convert.ToInt16(Console.ReadLine());
        }

        public static float Stats(string message)
        {
            Console.Write(message);

            return float.Parse(Console.ReadLine());
        }

        public static float CalculateBmi(float weight, float height)
        {
            return weight / height / height;
        }
    }
}
