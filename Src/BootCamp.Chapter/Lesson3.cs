using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            Console.WriteLine("Temp, not sure what to do here yet");
        }
        
        // Takes the weight and height and returns BMI
        public static float BMICalculation(float weight, float height)
        {
            return weight / (height * height);
        }

        // Prompts the user for an input, converts it to an integer and returns it
        public static int IntInput(string message)
        {
            Console.Write(message);
            var input = Console.ReadLine();
            return int.Parse(input);
        }

        // Prompts the user for a string and returns it (default is a string)
        public static string StringInput(string message)
        {
            Console.Write(message);
            var input = Console.ReadLine();
            return input;
        }

        // Prompts the user for an input, converts it and returns a float
        public static float FloatInput(string message)
        {
            Console.Write(message);
            var input = Console.ReadLine();
            return float.Parse(input);
        }
    }
}
