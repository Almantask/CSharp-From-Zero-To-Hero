using System;
using System.Globalization;

namespace BootCamp.Chapter
{
    public class Lesson3
    {
        public static void Demo ()
        {
            string userFirstName = GetStringInput(message: "Enter your first name: ");
            string userSurname = GetStringInput(message: "Enter your surname: ");
            int userAge = GetIntInput(message: "Enter your age: ");
            float userHeight = GetFloatInput(message: "Enter your height in cm: ");
            float userWeight = GetFloatInput(message: "Enter your weight in kg: ");
            float userBMI = CalculateBmi(userWeight, userHeight);
            Console.WriteLine(userFirstName + " " + userSurname + " is " + userAge + " years old, his weight is " + userWeight + " kg and his height is " + userHeight + " cm.");
            Console.WriteLine("BMI = " + userBMI);
        }

        public static float CalculateBmi(float weight, float height)
        {
            float bmi = weight / (height * height);
            return bmi;
        }

        public static float GetFloatInput(string message)
        {
            Console.Write(message);
            var floatInput = Console.ReadLine();
            return float.Parse(floatInput, CultureInfo.InvariantCulture.NumberFormat);
        }

        public static string GetStringInput(string message)
        {
            Console.Write(message);
            var stringInput = Console.ReadLine();
            return stringInput;
        }

        public static int GetIntInput(string message)
        {
            Console.Write(message);
            var intInput = Console.ReadLine();
            return int.Parse(intInput);
        }
    }
}

//- Calculating BMI (weight comes in kg, height comes in meters),
//- Prompt for input and converting it to int (print message for request, read console input and return converted input to int), 
//- Prompt for input and converting it to string (print message for request, read console input and return input),
//- Prompt for input and converting it to float (print message for request, read console input and return converted input to float).