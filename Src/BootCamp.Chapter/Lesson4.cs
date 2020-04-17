using System;
using Console = System.Console;

namespace BootCamp.Chapter
{
    class Lesson4
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
            float floatWeight = StringToFloat(weight);
            string height = InputPersonalInfo("Enter height in cm: ");
            float floatHeight = StringToFloat(height);
            string age = InputPersonalInfo("Enter age in years: ");
            _ = StringToFloat(age);


            float bmi = BmiCalculator(floatWeight, floatHeight);

            Console.WriteLine($"{name} is {age} years old, their weight is " +
                $"{weight} kg and their height is {height} cm. ");
            Console.WriteLine( $"Their BMI is {bmi}.");
        }
        private static string InputPersonalInfo(string displayText)
        { 
            Console.Write(displayText);
            string outputText = Console.ReadLine();

            if (string.IsNullOrEmpty(outputText))//if IsNullOrEmpty is True
            {
                Console.WriteLine("Name cannot be empty.");
                return "-";
            }
            else
            {
                return outputText;
            }
        }
        public static float StringToFloat(string inputString)
        {
            bool validCheck;
            validCheck = float.TryParse(inputString, System.Globalization.NumberStyles.Any,
                provider: System.Globalization.CultureInfo.InvariantCulture, result: out float outputFloat);
            if (!validCheck)
            {
                Console.WriteLine("A number was not entered.");

                return -1;
            }
            else if(outputFloat == 0)
            {
                Console.WriteLine("Zero was entered");
                return 0;
            }
            else
            {
                return outputFloat;
            }    

        }
        public static string FloatToString(float inputFloat)
        {
            string outputString = inputFloat.ToString(System.Globalization.CultureInfo.InvariantCulture);
            return outputString;
        }
        public static float BmiCalculator(float weight, float height)
        {
            if (weight <= 0 || height <= 0)//if either height or weight are less than zero
            {
                Console.WriteLine("Failed calculating BMI. Reason: ");//print this

                if (weight <= 0 && height <= 0)//if both height or weight are less than zero
                {
                    Console.WriteLine($"Height cannot be less than zero, but was {height}, where {height} is the console input({height} < 0)");

                }
                if (weight <= 0)
                {
                    Console.WriteLine($"Weight cannot be equal or less than zero, but was {weight}, where {weight} is the console input({weight} <= 0)");
                }
                if (height <= 0 && weight > 0)
                {
                    Console.WriteLine($"height cannot be equal or less than zero, but was {height}, where {height} is the console input({height} <= 0)");
                }
                return -1;


            }
            else
            {
                float bmi = weight / (height * height / 10000);
                return bmi;
            }
        }
    }
}
