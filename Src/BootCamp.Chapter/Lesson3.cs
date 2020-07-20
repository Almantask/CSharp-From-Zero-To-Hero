using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            
        }
        public static int PromptInt(string message)
            {
                Console.Write(message);
                int intedMessage = int.Parse(Console.ReadLine());
                return intedMessage;
            }
            
        public static string PromptString(string message)
            {
                Console.Write(message);
                var stringedMessage = Console.ReadLine();
                return stringedMessage;
            }
            
        public static float PromptFloat(string message)
            {
                Console.Write(message);
                float floatedMessage = float.Parse(Console.ReadLine());
                return floatedMessage;
            }

            
        public static float calculateBmi(float W, float H)
            {
                var bmi = W / (H * H);
                Console.WriteLine($"Also the BMI is {bmi}.");
                return bmi;
            }
    }
}
