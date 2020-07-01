using System;
using System.Globalization;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            //Enter information for 2 people
            Console.WriteLine("Please enter the information for person 1");
            NewPerson();
            Console.WriteLine("Please enter the information for person 2");
            NewPerson();
            
            //Close program 
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

        public static void NewPerson()
        {
            //Gather Input
            string firstName = InputString("Enter First Name: ");
            string lastName = InputString("Enter Last Name: ");
            int personsAge = InputInt("Enter Age: ");
            float personsWeight = InputFloat("Enter Weight in kg: ");
            float personsHeight = InputFloat("Enter Height in m: ");

            //Echo data to console
            Console.WriteLine(firstName + " " + lastName + " is " + personsAge + " years old, their weight is "
                                + personsWeight + " and their height is " + personsHeight + " m.");

            //Calculate and Display BMI
            Console.WriteLine("Their BMI is " + string.Format("{0:0.#}", CalculateBMI(personsWeight, personsHeight)));
            Console.WriteLine();

        }
    }
}
