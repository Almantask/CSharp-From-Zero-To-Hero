using System;

namespace BootCamp.Chapter
{
    class Program
    {
        public static void Main()
            {
                PersonDetails();
            }

        public static void PersonDetails()
            {
            string firstName, lastName;
            float age, weight, height;

            Console.Write("Input First Name: ");
            firstName = Console.ReadLine();
            Console.Write("Input Last Name: ");
            lastName = Console.ReadLine();

            // use s and returnValue to tryparse strings to floats
            string s = "";
            float returnValue;

            Console.Write("Input age: ");
            s = Console.ReadLine();
            float.TryParse(s, out returnValue);
            age = returnValue;

            Console.Write("Input weight (in kg): ");
            s = Console.ReadLine();
            float.TryParse(s, out returnValue);
            weight = returnValue;

            Console.Write("Input height (in cm): ");
            s = Console.ReadLine();
            float.TryParse(s, out returnValue);
            height = returnValue;

            //gender differences
            Console.Write("F/M?: ");
            string gender = "";
            gender = Console.ReadLine();

            if (gender == "M")
            {
               Console.WriteLine(firstName + " " + lastName + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " cm.");
            }

            else
            {
                Console.WriteLine(firstName + " " + lastName + " is " + age + " years old, her weight is " + weight + " kg and her height is " + height + " cm.");
            }

            float bMI = weight / ((height / 100) * (height / 100));

            Console.WriteLine(firstName + " " + lastName + " has a BMI of " + bMI + ".");

            Console.WriteLine("Input details for another person?");
            PersonDetails();
            }

    }
}
