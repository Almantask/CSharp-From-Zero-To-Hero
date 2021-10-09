using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            int i = 0;

            while (i < 2)
            {
                Console.Clear();

                string name = InputString("What's your name?");

                string surname = InputString("What's your surname?");

                int age = InputInt("How old are you?");

                float weightInKg = InputFloat("What's your weight? (in kg)");

                float heightInCm = InputFloat("How height are you? (in meters)");

                Console.WriteLine("\n{0} {1} is {2} years old, his weight is {3} kg and his height is {4} cm", name, surname, age, weightInKg, heightInCm);

                Console.WriteLine("\nBMI: {0:F} ", CalculateBmi(weightInKg, heightInCm));

                Console.ReadKey();

                i++;
            }
        }

        public static float CalculateBmi(float w, float h)
        {
            bool isWlessThanZero = w <= 0;
            bool isHlessThanZero = h <= 0;
            if (isWlessThanZero || isHlessThanZero)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");

                if (isWlessThanZero)
                {
                    Console.WriteLine("Weight cannot be equal or less than zero, but was {0}.", w);
                }

                if (isHlessThanZero)
                {
                    Console.WriteLine("Height cannot be equal or less than zero, but was {0}.", h);
                }

                return -1;
            }
            else
            {
                float bmi = w / (h * h);
                return (float)bmi;
            }
        }

        public static string InputString(string text)
        {
            Console.WriteLine(text);
            string input = Console.ReadLine();
            bool isNotOk = string.IsNullOrEmpty(input);
            if (isNotOk)
            {
                Console.WriteLine("Name cannot be empty.");
                return "-";
            }
            else
            {
                return input;
            }
        }
        public static int InputInt(string text)
        {
            Console.WriteLine(text);
            string inputNumber = Console.ReadLine();
            bool isNumber = int.TryParse(inputNumber, out int number);
            if (!isNumber)
            {
                Console.WriteLine("\"" + inputNumber + "\"" + " is not a valid number.");
                return -1;
            }
            else
            {
                return number;
            }
        }

        public static float InputFloat(string text)
        {
            Console.WriteLine(text);
            string inputNumber = Console.ReadLine();
            
            bool isNumber = float.TryParse(inputNumber, out float number);

            if (!isNumber)
            {
                Console.WriteLine("\"" + inputNumber + "\"" + " is not a valid number.");
                return -1;
            }
            else
            {
                return number;
            }
        }
    }

}
