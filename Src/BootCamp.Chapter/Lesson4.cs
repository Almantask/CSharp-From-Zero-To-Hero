using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson4
    {
        public static void Demo()
        {
            //main
            Interview();
        }

        public static void Interview()
        {
            //  gets all the input from the user, if one of them is invalid
            //  it displays the relevant error code and returns
            string name = PromptString("Name: ");
            if (ErrorString(name, "Name cannot be empty.")) return;
            
            string surname = PromptString("Surname: ");
            if (ErrorString(surname, "Surname cannot be empty.")) return;

            int age = PromptInt("Age: ");
            if (age < 0) return;

            float weight = PromptFloat("Weight(Kg): ");
            if (weight < 0) return;

            float cmHeight = PromptFloat("Height (cm): ");
            if (cmHeight < 0) return;
            float mHeight = cmHeight / 100f;

            //  prints the description according to user's input
            Console.WriteLine($"{name} {surname} is {age} years old, their weight is {weight}Kg and their height is {cmHeight}cm");

            //  calculate BMI and print errormessage if it got an error
            float bmi = CalculateBmi(weight, mHeight);
            if (bmi < 0)
            {
                Console.WriteLine("Falied to calculate BMI. Reasons:");
                if ((bmi == -2)||(bmi == -3))
                {
                    Console.WriteLine($"Height cannot be equal or less than zero, but was {cmHeight}.");
                }
                if ((bmi == -1) || (bmi == -3))
                {
                    Console.WriteLine($"Weight cannot be equal or less than zero, but was {weight}.");
                }
                return;
            }
            Console.WriteLine($"Their bmi is {bmi}");
        }

        public static float CalculateBmi(float weight, float height)
        {
            //  BMI is only positive and can only be calculated with positive inputs,
            //  if these are negative zero calculate error code based on which ones don't work
            if ((weight <= 0) || (height <= 0))
            {
                int errorCode = 0;
                if (weight <= 0) errorCode -= 1;
                if (height <= 0) errorCode -= 2;
                return errorCode;
            }
            return weight / (height * height);
        }

        public static bool ErrorString(string input, string errorMessage)
        {
            if ("-".Equals(input))
            {
                Console.WriteLine(errorMessage);
                return true;
            }
            return false;
        }

        public static int PromptInt(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();

            //return 0 with empty string
            if ("".Equals(input)) return 0;

            int result;
            bool isInt = int.TryParse(input, out result);

            if (!isInt)
            {
                Console.WriteLine($"{input} is not a valid number.");
                result = -1;
            }
            return result;
        }

        public static float PromptFloat(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();

            //return 0 with empty string
            if ("".Equals(input)) return 0f;

            float result;
            bool isFloat = float.TryParse(input, out result);

            if (!isFloat)
            {
                Console.WriteLine($"{input} is not a valid number.");
                result = -1;
            }
            return result;
        }

        public static string PromptString(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input)) return input;
            return "-";
        }
    }
}
