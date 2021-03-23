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
                       
            string firstName = PromptString("Enter First Name");
            string lastName = PromptString("Enter Last Name");
            int age = PromptInt("Enter Your Age");
            float weight = PromptFloat("Enter Your Weight in KG");
            float height = PromptFloat("Enter Your Height in M");
            float bmi = CalculateBmi(weight, height);
            Console.WriteLine("Your BMI is " + bmi);

            Console.WriteLine();
            Console.WriteLine("Enter Details for another person below");
            firstName = PromptString("Enter First Name");
            lastName = PromptString("Enter Last Name");
            age = PromptInt("Enter Your Age");
            weight = PromptFloat("Enter Your Weight in KG");
            height = PromptFloat("Enter Your Height in M");
            bmi = CalculateBmi(weight, height);
            Console.WriteLine("Your BMI is " + bmi);



        }


        public static int PromptInt(string message)
        {
            Console.WriteLine(message);

            string input = Console.ReadLine();
            bool isNumber = int.TryParse(input, out var outNumber);
            if (!isNumber)
            {
                Console.WriteLine("\"" + input + "\" is not a valid number.");
                return -1;
            }
            
            return outNumber;
        }

        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            string inputString = Console.ReadLine();
            bool isValid = String.IsNullOrEmpty(inputString);
            if (isValid)
            {
                Console.WriteLine("Name cannot be empty.");
                return "-";
            }
            return inputString;
        }

        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            bool isNumber = float.TryParse(input, out var outNumber);

            if (!isNumber)
            {
                Console.WriteLine("\"" + input + "\" is not a valid number.");
                return -1;
            }

            return outNumber;

        }

        public static float CalculateBmi(float weight, float height)
        {

            string message="";


            if (height <=0 )
            {
                message = Environment.NewLine + "Height cannot be equal or less than zero, but was " + height;
                
            }

            if (weight <=0)
            {
                message += Environment.NewLine + "Weight cannot be equal or less than zero, but was " + weight;              

            }

            if (!string.IsNullOrEmpty(message))
            {
                Console.WriteLine("Failed calculating BMI. Reason:" + message);
                return -1;
            }

            return (float)Math.Round(weight / height / height, 2);
        }



    }
}
