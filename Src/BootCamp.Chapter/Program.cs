using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * Chapter 1. Homework 1 and 2
             * 
             * @author RonaldVeisenberger
             */

            // Variables
            string name = " ";
            string surname = " ";
            int age = 0;
            double weight = 0;
            double height = 0;
            double bmi = 0;
            
            // Messages
            const string nameMessage = "Please enter your name: ";
            const string surnameMessage = "Please enter your surname: ";
            const string ageMessage = "Please enter your age (in year): ";
            const string weightMessage = "Please enter your weight (in kg): ";
            const string heightMessage = "Please enter your height (in cm): ";
            

            // Person1

            // Get user input
            Console.WriteLine(nameMessage);
            name = Console.ReadLine();

            Console.WriteLine(surnameMessage);
            surname = Console.ReadLine();

            Console.WriteLine(ageMessage);
            age =int.Parse(Console.ReadLine());

            Console.WriteLine(weightMessage);
            weight = double.Parse(Console.ReadLine());

            Console.WriteLine(heightMessage);
            height = double.Parse(Console.ReadLine());

            // Create output
            Console.WriteLine();
            Console.WriteLine(name + " " + surname + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " cm");

            // BMI Calculation: [weight (kg) / height (cm) / height (cm)] x 10,000
            bmi = (weight / height / height) * 10000;
            Console.WriteLine(name + " " + surname + " " + "Body Mass Index is: " + bmi);
            Console.WriteLine();


            // Person2

            // Get user input
            Console.WriteLine(nameMessage);
            name = Console.ReadLine();

            Console.WriteLine(surnameMessage);
            surname = Console.ReadLine();

            Console.WriteLine(ageMessage);
            age = int.Parse(Console.ReadLine());

            Console.WriteLine(weightMessage);
            weight = double.Parse(Console.ReadLine());

            Console.WriteLine(heightMessage);
            height = double.Parse(Console.ReadLine());

            // Create output
            Console.WriteLine();
            Console.WriteLine(name + " " + surname + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " cm");

            // BMI Calculation: [weight (kg) / height (cm) / height (cm)] x 10,000
            bmi = (weight / height / height) * 10000;
            Console.WriteLine(name + " " + surname + " " + "Body Mass Index is: " + bmi);
            Console.WriteLine();
        }
    }
}
