using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson4
    {
        //Calls all user prompt methods & prints full message to console
        public static void Demo()
        {
            string name = PromptName();
            int age = PromptAge();
            float weight = PromptWeight();
            float height = PromptHeight();
            float bmi = CalculateBmi(weight, height);
            Console.WriteLine(name + " is " + age + " years old, their weight is " + weight + " kg, and their height is " + height + " cm.");
            Console.WriteLine("Their BMI is: " + bmi);
        }

        //Prompting user for info
        public static string PromptName()
        {
            Console.WriteLine("Testing");
            string name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                Console.Write("Name cannot be empty.");
                return "-";
            }
            else
            {
                return name;
            }
        }
        public static int PromptAge()
        {
            Console.WriteLine("Testing");
            int age;
            string input = Console.ReadLine();
            bool goodAge = int.TryParse(input, out age);
            
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }
            else if (!goodAge)
            {
                Console.Write("\"" + input + "\" is not a valid number.");
                return -1;
            }
            else if ((goodAge) && (age == 0))
            {
                return 0;
            }
            else
            {
                return age;
            }
        }
        public static float PromptWeight()
        {
            Console.WriteLine("Testing");
            float weight;
            string input = Console.ReadLine();
            bool goodWeight = float.TryParse(input, out weight);
            
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }
            else if (!goodWeight)
            {
                Console.Write("\"" + input + "\" is not a valid number.");
                return -1;
            }
            else if (goodWeight && (weight == 0))
            {
                return 0;
            }
            else
            {
                return weight;
            }
        }
        public static float PromptHeight()
        {
            Console.WriteLine("Testing");
            float height;
            string input = Console.ReadLine();
            bool goodHeight = float.TryParse(input, out height);
            if (goodHeight)
            {
                return height;
            }
            else if ((goodHeight) && (height == 0))
            {
                return 0;
            }
            else if (string.IsNullOrEmpty(input))
            {
                return 0f;
            }
            else
            {
                return -1;
            }
        }
        //Calculates BMI
        public static float CalculateBmi(float weight, float height)
        {
            if ((height <= 0) && (weight <= 0))
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                Console.WriteLine("Weight cannot be equal or less than zero, but was " + weight + ".");
                Console.WriteLine("Height cannot be less than zero, but was " + height + ".");
                return -1;
            }
            else if (height <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                Console.WriteLine("Height cannot be equal or less than zero, but was " + height + ".");
                return -1;
            }
            else if (weight <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                Console.WriteLine("Weight cannot be equal or less than zero, but was " + weight + ".");
                return -1;
            }

            return weight / (height * height);
        }
    }
}
