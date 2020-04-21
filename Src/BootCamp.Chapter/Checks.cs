using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    /// <summary>
    /// Test class is used to test your implementation.
    /// Each homework will have a set of steps that you will have to do.
    /// You can name your functions however you want, but to validate your solution, place them here.
    /// DO NOT CALL FUNCTIONS FROM TESTS CLASS
    /// DO NOT IMPLEMENT FUNCTIONS IN TESTS CLASS
    /// TESTS CLASS FUNCTIONS SHOULD ALL HAVE 1 LINE OF CODE
    /// </summary>
    public static class Checks
    {
        public static int PromptInt(string message)
        {
            bool isValidAge;
            Console.WriteLine(message);
            string ageString = Console.ReadLine();
            isValidAge = string.IsNullOrEmpty(ageString);
            if (isValidAge) return 0;
            isValidAge = int.TryParse(ageString, out int age);
            if (!isValidAge || age < 0)
            {
                Console.Write((char)34 + ageString + (char)34 + " is not a valid number.");
                return -1;
            }
            return age;
        }

        public static string PromptString(string message)
        {
            bool isInvalidName;
            Console.WriteLine(message);
            string name = Console.ReadLine();
            isInvalidName = string.IsNullOrEmpty(name);
            if (isInvalidName)
            {
                Console.Write("Name cannot be empty.");
                return "-";
            }
            return name;
        }

        public static float PromptFloat(string message)
        {
            bool isValidMeasurement;
            Console.WriteLine(message);
            string measurementString = Console.ReadLine();
            isValidMeasurement = string.IsNullOrEmpty(measurementString);
            if (isValidMeasurement) return 0;
            isValidMeasurement = float.TryParse(measurementString, out var measurement);
            if (!isValidMeasurement)
            {
                Console.Write((char)34 + measurementString + (char)34 + " is not a valid number.");
                return -1;
            }
            return measurement;
        }

        public static float CalculateBmi(float weight, float height)
        {
            if (height <= 0 && weight <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:" + Environment.NewLine + "Weight cannot be equal or less than zero, but was " + weight + ".");
                Console.WriteLine("Height cannot be less than zero, but was " + height + ".");
                return -1;
            }
            else if (height <= 0 && weight > 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:" + Environment.NewLine + "Height cannot be equal or less than zero, but was " + height + ".");
                return -1;
            }
            else if (height > 0 && weight <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:" + Environment.NewLine + "Weight cannot be equal or less than zero, but was " + weight + ".");
                return -1;
            }
            float heightInMetersSquared = height;
            heightInMetersSquared *= heightInMetersSquared;
            var bodyMassIndex = weight / heightInMetersSquared;
            return bodyMassIndex;
        }
    }
}
