using System;
using System.Globalization;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
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
