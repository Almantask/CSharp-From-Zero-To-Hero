using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BootCamp.Chapter
{
    public class Lesson3
    {
        public static void Demo ()
        {
            string userFirstName = UserName(message: "Enter your first name: ");
            string userSurname = UserName(message: "Enter your surname: ");
            int userAge = UserAge(message: "Enter your age: ");
            float userHeight = UserHeightWeight(message: "Enter your height in cm: ");
            float userWeight = UserHeightWeight(message: "Enter your weight in kg: ");
            float userBMI = CalculateBMI(userWeight, userHeight);
            Console.WriteLine(userFirstName + " " + userSurname + " is " + userAge + " years old, his weight is " + userWeight + " kg and his height is " + userHeight + " cm.");
            Console.WriteLine("BMI = " + userBMI);
        }

        public static float CalculateBMI(float weight, float height)
        {
            double bmi = weight / Math.Pow(height, 2);
            return Convert.ToSingle(bmi);
        }

        public static float UserHeightWeight(string message)
        {
            Console.Write(message);
            var heightOrWeight = Console.ReadLine();
            return float.Parse(heightOrWeight, CultureInfo.InvariantCulture.NumberFormat);
        }

        public static string UserName(string message)
        {
            Console.Write(message);
            var name = Console.ReadLine();
            return name;
        }

        public static int UserAge(string message)
        {
            Console.Write(message);
            var age = Console.ReadLine();
            return Convert.ToInt32(age);
        }
    }
}

//- Calculating BMI (weight comes in kg, height comes in meters),
//- Prompt for input and converting it to int (print message for request, read console input and return converted input to int), 
//- Prompt for input and converting it to string (print message for request, read console input and return input),
//- Prompt for input and converting it to float (print message for request, read console input and return converted input to float).