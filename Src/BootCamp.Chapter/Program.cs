using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //First name
            string firstName;
            Console.WriteLine("What is your first name?");
            firstName = Console.ReadLine();
            
            //Last name
            string surname;
            Console.WriteLine("What is your surname(last name)?");
            surname = Console.ReadLine();

            //Age
            string ageEntered;
            int age;
            Console.WriteLine("Enter your age as a number please.");
            ageEntered = Console.ReadLine();
            age = int.Parse(ageEntered);

            //Weight in kilograms
            string weightEntered;
            double weight;
            Console.WriteLine("What is your weight in kilograms?");
            weightEntered = Console.ReadLine();
            weight = double.Parse(weightEntered);

            //Height in centimeters
            string heightEntered;
            double height;
            Console.WriteLine("What is your height in centimeters?");
            heightEntered = Console.ReadLine();

           
            //BMI Calculation
            double bmiCalculated;
            double bmiRounded;
            height = double.Parse(heightEntered);
            bmiCalculated = (weight/height/height)*10000;
            bmiRounded = Math.Round(bmiCalculated, 1);

            //First name, last name, age, weight, height, and BMI explained in sentence format.
            Console.WriteLine(firstName + " " + surname + " is " + age + " years old, their weight is " + weight + " kg and their height is " + height + " cm. " + firstName + " " + surname + "'s BMI is " + bmiRounded + "%.");
        }
    }
}
