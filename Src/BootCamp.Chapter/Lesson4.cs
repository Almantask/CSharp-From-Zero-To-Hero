using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Reflection.PortableExecutable;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson4
    {
        public static float globalHeight = 0f;
        public static float globalWeight = 0f;
        public static string bmiError = "Failed calculating BMI. Reason:";

        public static string Information()
        {
            Console.WriteLine("Testing");
            string firstName = Console.ReadLine();
            string errorMsg = "Name cannot be empty.";

            if (String.IsNullOrEmpty(firstName))
            {
                Console.WriteLine(errorMsg);
                return errorMsg;
            }
            else
            {
                return firstName;
            }
        }

        public static int AskAge()
        {
            Console.WriteLine("Testing");
            string sAge = Console.ReadLine();

            int age;
            bool isNumber = int.TryParse(sAge, out age);

            if (!isNumber) return -1;
            if (age == 0) return 0;
            if (age >= 0) return age;

            return 0;

        }

        public static float Weight()
        {
            Console.WriteLine("What is your weight in kgs?");
            string sWeight = Console.ReadLine();

            bool isNumber = float.TryParse(sWeight, out globalWeight);

            if (!isNumber)
                {
                    Console.WriteLine(globalWeight + " is not a valid number.");    
                    return -1; 
                }
            if (globalWeight == 0) return 0;
            if (globalWeight >= 0) return globalWeight;

            return 0;
        }

        public static float Height()
        {
            Console.WriteLine("Testing");
            string sHeight = Console.ReadLine();

            bool isNumber = float.TryParse(sHeight, out globalHeight);

            if (!isNumber)
            {
                Console.WriteLine("\"" + sHeight + "\"" + " is not a valid number.");
                return -1;
            }
            if (globalHeight == 0) return 0;
            if (globalHeight >= 0) return globalHeight;

            return 0;
        }

        public static float BMIFormula(float weight, float height)
        {
            if (weight <= 0 && height <= 0)
            {
                Console.WriteLine(bmiError + Environment.NewLine + "Weight cannot be equal or less than zero, but was " + weight + ".");
                Console.WriteLine("Height cannot be less than zero, but was " + height + ".");
                return -1;

            }
            if (weight <= 0 )
            {
                Console.WriteLine(bmiError + Environment.NewLine +  "Weight cannot be equal or less than zero, but was " + weight + ".");
                return -1;
            }

            if (height <= 0)
            {
                Console.WriteLine(bmiError + Environment.NewLine + "Height cannot be equal or less than zero, but was " + height + ".");
                return -1;
            }

            else
            {
                float bmiValue = weight / height / height;
                return bmiValue;
            }

        }

        public static void Message()
        {
            Console.WriteLine(Information() + " is " + AskAge() + " years old, their weight in kg is " + Weight()
            + " and their height in cm is " + Height() + ". " + "Their BMI is " + BMIFormula(globalWeight, globalHeight));
        }
    }
}
