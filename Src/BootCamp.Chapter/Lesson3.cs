using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            string firstName = InputString("Enter First Name: ");

            string lastName = InputString("Enter Last Name: ");

            int personsAge = InputInt("Enter Age: ");

            float personsWeight = InputFloat("Enter Weight in kg: ");

            float personsHeight = InputFloat("Enter Height in m:");

            Console.WriteLine(firstName + " " + lastName + " is " + personsAge + " years old, their weight is "
                                + personsWeight + " and their height is " + personsHeight + " m.");

            Console.WriteLine("Their BMI is " + string.Format("{0:0.#}", CalculateBMI(personsWeight, personsHeight)));

            Console.WriteLine();
            Console.WriteLine("Please Enter a second persons information");

            firstName = InputString("Enter First Name: ");

            lastName = InputString("Enter Last Name: ");

            personsAge = InputInt("Enter Age: ");

            personsWeight = InputFloat("Enter Weight in kg: ");

            personsHeight = InputFloat("Enter Height in m:");

            Console.WriteLine(firstName + " " + lastName + " is " + personsAge + " years old, their weight is "
                                + personsWeight + " and their height is " + personsHeight + " m.");


            Console.WriteLine("Their BMI is " + string.Format("{0:0.#}", CalculateBMI(personsWeight, personsHeight)));

            Console.WriteLine();
            Console.WriteLine("Press any key to quit");
            Console.ReadKey();
        }

        public static float CalculateBMI(float weight, float height)
        {
            return weight/MathF.Pow(height, 2);
        }

        public static int InputInt(string prompt)
        {
            Console.Write(prompt);
            return int.Parse(Console.ReadLine());
        }

        public static float InputFloat(string prompt)
        {
            Console.Write(prompt);
            return float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        }

        public static string InputString(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
    }
}
