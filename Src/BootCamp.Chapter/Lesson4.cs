using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson4
    {
        public static void Demo()
        {
            for (int i = 0; i < 2; i++)
            {
                string name = PrintAndReadString("First Name: ");

                string sureName = PrintAndReadString("Last Name: ");

                int age = PrintAndReadInt("Age: "); ;

                float weight = PrintAndReadFloat("Weight: ");

                float height = PrintAndReadFloat("Height: ");

                var bmi = BMICalc(weight, height);

                Console.WriteLine($"{name} {sureName} is {age} years old, his weight is {weight} kg and his height is {height} cm.");

                Console.WriteLine($"Your BMI - {bmi:N2}");
            }
        }

        public static float BMICalc(float weight, float height)
        {
            string errmsg1 = $"Height cannot be equal or less than zero, but was {height}.";
            string errmsg2 = $"Weight cannot be equal or less than zero, but was {weight}.";
            if (weight <= 0 || height <= 0)
            {
                Console.WriteLine($"Failed calculating BMI. Reason: \"{errmsg1}\" \"{errmsg2}\" ");
                return -1;
            }
            else
            {
                return weight / (height * height);
            }   
        }

        public static string PrintAndReadString(string message)
        {
            Console.WriteLine(message);
            string stringVar = Console.ReadLine();
            if (string.IsNullOrEmpty(stringVar))
            {
                Console.WriteLine("Name cannot be empty.");
                return "-";
            }
            else
            {
                return stringVar;
            }
        }

        public static float PrintAndReadFloat(string message)
        {
            Console.WriteLine(message);
            float floatVar;
            var input = Console.ReadLine();
            bool isNumber = float.TryParse(input, out floatVar);
            if(isNumber) return floatVar;
            else
            {
                Console.WriteLine($" \"{input}\" is not a valid number.");
                return -1;
            }
        }

        public static int PrintAndReadInt(string message)
        {
            Console.WriteLine(message);
            int intVar;
            var input = Console.ReadLine();
            bool isNumber = int.TryParse(input, out intVar);
            if(isNumber) return intVar;
            else
            {
                Console.WriteLine($" \"{input}\" is not a valid number.");
                return -1;
            }

        }

    }
}
