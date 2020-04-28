using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Text.RegularExpressions;

namespace BootCamp.Chapter
{
    class Lesson4
    {
        public static void Demo()
        {
            Console.WriteLine("Body-Mass Index (BMI) Calculator");
            Console.WriteLine("");

            ProcessPersonBMI();
            ProcessPersonBMI();
        }

        private static void ProcessPersonBMI()
        {
            string name = PromptString("Name:");
            int age = PromptInt("Age:");
            float height = PromptFloat("Height (in m):");
            float weight = PromptFloat("Weight (in kg):");

            Console.WriteLine($"{name} is {age} years old, has {weight}kg and {height}m. ");
            Console.WriteLine($"His BMI is {CalculateBMI(weight, height)}");
            Console.WriteLine("");
        }

        public static string PromptString(string message)
        {
            Console.Write(message + " ");
            string answer = Console.ReadLine();

            if (answer == "")
            {
                Console.WriteLine($"Name cannot be empty. \n");
                return PromptString(message);
            }

            Console.Write("\n");
            return answer;   
        }

        public static int PromptInt(string message)
        {
            Console.Write(message + " ");
            int answer = 0;
            bool isLetter = !Int32.TryParse(Console.ReadLine(), out answer);

            if (isLetter || answer <= 0)
            {
                Console.WriteLine($"Answer must be a number greater than 0. \n");
                return PromptInt(message);
            } 
           
            Console.Write("\n");
            return answer;
        }

        public static float PromptFloat(string message)
        {
            Console.Write(message + " ");
            string answer = Console.ReadLine().Replace(",", ".");
            Regex floatRule = new Regex(@"^(?:\d{1,2})?(?:\.\d{1,2})?$");
            
            if (!floatRule.IsMatch(answer) || answer == "0")
            {
                Console.WriteLine("Answer must be a number greater than 0. \n");
                return PromptFloat(message);
            }

            Console.Write("\n");
            return float.Parse(answer, CultureInfo.InvariantCulture);
        }

        public static float CalculateBMI(float weight, float height)
        {
            return weight / (height * height);
        }
    }
}
