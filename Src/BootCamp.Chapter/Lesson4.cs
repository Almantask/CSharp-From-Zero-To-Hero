using System;
using System.Globalization;

namespace BootCamp.Chapter
{
    public class Lesson4
    {
        public static void Demo()
        {
            for (int i = 0; i < 2; i++)
            {
                string firstName = PromptString("Input First Name: ");
                string lastName = PromptString("Input Last Name: ");
                int age = PromptInt("Input age: ");
                float weight = PromptFloat("Input weight (in kg): ");
                float height = PromptFloat("Input height (in m): ");

                Console.WriteLine(firstName + " " + lastName + " is " + age + " years old, his weight is " + weight + " kg and his height is " + height + " m.");

                float bmi = CalculateBMI(weight, height);
                Console.WriteLine(firstName + " " + lastName + " has a BMI of " + bmi + ".");
            }
        }

        public static string PromptString(string checkString)
        {
            Console.Write(checkString);
            string returnString = Console.ReadLine();
            if (returnString != "")
            {
                return returnString;
            }
            else
            {
                Console.WriteLine("Name cannot be empty.");
                return "-";
            }
        }

        public static int PromptInt(string checkString)
        {
            Console.Write(checkString);
            string returnString = Console.ReadLine();
            if (returnString == "")
            {
                return 0;
            }
            else
            {
                bool isNumber = int.TryParse(returnString, out int returnInt);
                if (!isNumber)
                {
                    Console.WriteLine(returnString + " is not a valid number.");
                    return -1;
                }
                else
                {
                    return returnInt;
                }
            }
        }
        public static float PromptFloat(string checkString)
        {
            Console.Write(checkString);
            string returnString = Console.ReadLine();
            if (returnString == "")
            {
                return 0;
            }
            else
            {
                bool isNumber = float.TryParse(returnString, NumberStyles.Float, CultureInfo.InvariantCulture, out float returnFloat);
                if (!isNumber)
                {
                    Console.WriteLine(returnString + " is not a valid number.");
                    return -1;
                }
                else
                {
                    return returnFloat;
                }
            }
        }

        public static float CalculateBMI(float weight, float height)
        {
            if (weight <= 0 || height <= 0)
            {
                return InvalidBMI(weight, height);
            }

            else
            {
                return weight / (height * height);
            }
        }

        public static float InvalidBMI(float weight, float height)
        {
            Console.WriteLine("Failed calculating BMI. Reason:");

            if (weight <= 0)
            {
                Console.WriteLine("Weight cannot be equal or less than zero, but was " + weight + ".");
            }

            if (height <= 0)
            {
                Console.WriteLine("Height cannot be equal or less than zero, but was " + height + ".");
            }

            return -1;
        }
    }
}