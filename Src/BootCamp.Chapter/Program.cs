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
            string name;
            string surname;
            string decision;
            float age;
            float weight;
            float height;
            float heightInMeters;
            float BMI;
            do
            {
                //Read name
                Console.WriteLine("What is your name?");
                name = Console.ReadLine();
                //Read surname
                Console.WriteLine("What is your surname?");
                surname = Console.ReadLine();
                //Read age
                Console.WriteLine("How old are you?");
                age = float.Parse(Console.ReadLine());
                //Read weight in kg
                Console.WriteLine("What is your weight (in kg)?");
                weight = float.Parse(Console.ReadLine());
                //Read height in cm
                Console.WriteLine("What is your height (in cm)?");
                height = float.Parse(Console.ReadLine());

                Console.WriteLine(); //Add empty line
                //Write message about person
                Console.WriteLine($"{name} {surname} is {age} years old, his weight is {weight} kg and his height is {height} cm.");

                //Convert height from centimeters to meters
                heightInMeters = height / 100;
                //Calculate BMI
                BMI = weight / (float)Pow(heightInMeters, 2);
                //Write a message with this person's BMI 
                Console.WriteLine("His/her BMI = " + string.Format("{0:N}", BMI));

                Console.WriteLine(); //Add empty line
                //Ask about new data (new person)
                Console.WriteLine("Do you want to add another person (Y/y = Yes, everything else = No)?");
                decision = Console.ReadLine();
                //Clear console window if user wants to add new person's data
                if (decision == "Y" || decision == "y")
                    Console.Clear();

            } while (decision == "Y" || decision == "y"); //Repeat if user wants to add new person's data
        }
    }
}
