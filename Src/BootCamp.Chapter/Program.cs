using System;
using static System.Math;

namespace BootCamp.Chapter
{
    class Program
    {
        /*  Homework #1 
            Read name, surename, age, weight (in kg) and height (in cm) from console.
            1) Print all the info based on the example message below:
                Tom Jefferson is 19 years old, his weight is 50 kg and his height is 156.5 cm. 
            2) Calculate and print body-mass index (BMI)
            3) Do 1 and 2 for another person.
        */
        static void Main(string[] args)
        {
            string decision;
            do
            {
                Console.Clear(); //Clear console window
                decision = Add_new_person();

            } while (decision == "Y"); //Repeat if user wants to add new person's data
        }

        private static string Add_new_person()
        {
            //Read name
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            //Read surname
            Console.WriteLine("What is your surname?");
            string surname = Console.ReadLine();
            //Read age
            Console.WriteLine("How old are you?");
            float age = float.Parse(Console.ReadLine());
            //Read weight in kg
            Console.WriteLine("What is your weight (in kg)?");
            float weight = float.Parse(Console.ReadLine());
            //Read height in cm
            Console.WriteLine("What is your height (in cm)?");
            float height = float.Parse(Console.ReadLine());

            Console.WriteLine(); //Add empty line
            //Write message about person
            Console.WriteLine($"{name} {surname} is {age} years old, his weight is {weight} kg and his height is {height} cm.");

            //Convert height from centimeters to meters
            float heightInMeters = height / 100;
            //Calculate BMI
            float BMI = weight / (float)Pow(heightInMeters, 2);
            //Write a message with this person's BMI 
            Console.WriteLine("His/her BMI = " + string.Format("{0:N}", BMI));

            Console.WriteLine(); //Add empty line
            //Ask about new data (new person)
            Console.WriteLine("Do you want to add another person (Y/y = Yes, everything else = No)?");
            string decision = Console.ReadLine();
            decision = decision.ToUpper();
            return decision;
        }
    }
}
