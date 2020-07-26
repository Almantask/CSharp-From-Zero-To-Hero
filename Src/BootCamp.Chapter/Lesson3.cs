using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace BootCamp.Chapter
{
    public class Lesson3
    {   
        public static void InputUserDataAndPrintWithBMI()
        {
            // Calling the functions and combining output.
            string name = PrintMessageAndReturnString("Please enter your name: ");
            string surname = PrintMessageAndReturnString("Please enter your surname: ");
            int age = PrintMessageAndReturnInt("Please enter your age: ");
            float weight = PrintMessageAndReturnFloat("Please enter your weight (in kg): ");
            float height = PrintMessageAndReturnFloat("Please enter your height (in cm): ");

            Console.WriteLine($"{name} {surname} is {age} years old, his weight is {weight} kg " +
                $"and his height is {height} cm.");
            Console.WriteLine($"{CalculateBMI(weight, height / 100):F2}");
        }
        public static string PrintMessageAndReturnString(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.Write($"Name cannot be empty.");
                return "-";
            }
            else { return input; }
        }
        public static int PrintMessageAndReturnInt(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) { return 0; }
            if (int.TryParse(input, out int output)) { return output; }
            else
            {
                Console.Write($"\"{input}\" is not a valid number.");
                return -1;
            }
        }
        public static float PrintMessageAndReturnFloat(string message)
        {
            CultureInfo invC = CultureInfo.InvariantCulture;
            NumberStyles style = NumberStyles.Float;
            Console.WriteLine(message);
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) { return 0; }
            if (float.TryParse(input, style, invC, out float output)) { return output; }
            else
            {
                Console.Write($"\"{input}\" is not a valid number.");
                return -1;
            }
        }
        public static float CalculateBMI(float weight, float height)
        {
            if(weight <= 0 || height <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                if (weight <= 0 && height <= 0)
                {
                    Console.WriteLine($"Weight cannot be equal or less than zero, but was {weight}.");
                    Console.WriteLine($"Height cannot be less than zero, but was {height}.");
                }
                else
                {
                    if (weight <= 0) { Console.WriteLine($"Weight cannot be equal or less than zero, but was {weight}."); }
                    if (height <= 0) { Console.WriteLine($"Height cannot be equal or less than zero, but was {height}."); }
                }
                return -1;
            }
            else { return weight / (height * height); }
        }
    }
}
