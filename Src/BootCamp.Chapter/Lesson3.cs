using System;
using Console = System.Console;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            DisplayPersonalInfo();
            DisplayPersonalInfo();


        }
        public static void DisplayPersonalInfo()
        {
            string name = InputPersonalInfo("Enter name: ");
            string weight = InputPersonalInfo("Enter Weight in kg: ");
            string height = InputPersonalInfo("Enter height in cm: ");
            string age = InputPersonalInfo("Enter age in years: ");

            float floatWeight = StringToFloat(weight);
            float floatHeight = StringToFloat(height);


            float bmi = BmiCalculator(floatWeight, floatHeight);

            Console.WriteLine($"{name} is {age} years old, their weight is " +
                $"{weight} kg and their height is {height} cm. ");
            Console.WriteLine( $"Their BMI is {bmi}.");
        }
        public static string InputPersonalInfo(string displayText)
        {
            Console.Write(displayText);
            string outputText = Console.ReadLine();
            return outputText;
        }
        public static float StringToFloat(string inputString)
        {
            _ = float.TryParse(inputString, System.Globalization.NumberStyles.Any,
                provider: System.Globalization.CultureInfo.InvariantCulture, result: out float outputFloat);

            return outputFloat;
        }
        public static string FloatToString(float inputFloat)
        {
            string outputString = inputFloat.ToString(System.Globalization.CultureInfo.InvariantCulture);
            return outputString;
        }
        public static float BmiCalculator(float weight, float height)
        {
            float bmi = weight / (height * height / 10000);
            return bmi;
        }
    }
}
