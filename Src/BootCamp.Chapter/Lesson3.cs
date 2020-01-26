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
            if (weight <= 0 && height <=0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                Console.WriteLine("Weight cannot be less than zero, but was " + weight + ".");
                Console.WriteLine("Height cannot be equal or less than zero, but was " + height + ".");
            }
            else if (weight <=0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                Console.WriteLine("Weight cannot be less than zero, but was " + weight + ".");
            }
            else if (height <=0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                Console.WriteLine("Height cannot be equal or less than zero, but was " + height + ".");
            }  
                
            float bmi = weight / (height * height);
            return bmi;
        }

        public static float GetFloatInput(string message)
        {
            Console.Write(message);
            var floatInput = Console.ReadLine();
            if (string.IsNullOrEmpty(floatInput))
            {
                Console.WriteLine(floatInput + " is not a valid number.");
                return 0;
            }
            else if (!float.TryParse(floatInput, out float number))
            {
                Console.WriteLine(floatInput + " is not a valid number.");
                return -1;
            }
            else
            {
                return float.Parse(floatInput, CultureInfo.InvariantCulture.NumberFormat);
            }

        }

        public static string GetStringInput(string message)
        {
            Console.Write(message);
            var stringInput = Console.ReadLine();
            if (string.IsNullOrEmpty(stringInput))
            {
                Console.WriteLine("Name cannot be empty.");
                return "-";
            }
            else
            {
                return stringInput;
            }
        }

        public static int GetIntInput(string message)
        {
            Console.Write(message);
            var intInput = Console.ReadLine();
            if (!float.TryParse(intInput, out float number))
            {
                Console.WriteLine(intInput + " is not a valid number.");
                return -1;
            }
            return int.Parse(intInput);
        }
    }
}
/*Modify your old functions to fit the specification:
1)  Invalid height or weight or age that are not numbers should return -1 and print error message ""X" is not a valid number." where X is input from console.
2) Empty string for height or weight or age returns 0
3) Empty string for name returns "-" and print error message "Name cannot be empty." in a new line.
4) During BMI calculation, height or weight less or equal to 0 should print error message in console:
  - It should start with "Failed calculating BMI. Reason:" followed by a new line:
    - "Height cannot be less than zero, but was X.", where X is the console input. (X <= 0)
    - "Weight cannot be equal or less than zero, but was X.", where X is the console input (X <= 0)
    - If both height and weight are invalid, both validation messages should be printed to console (each in new line)*/