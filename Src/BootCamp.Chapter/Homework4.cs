using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Homework4
    {
        public static void Demo()
        {
            static void GatherInfo(string userNumber)
            {
                Console.WriteLine("Hello! You are the " + userNumber + " user today.");
                string firstName = PromptString("What is your first name?");
                string surName = PromptString("What is your surname?");
                int age = PromptInt("What is your age?");
                float weight = PromptFloat("How much do you weigh(in kg)?");
                float height = PromptFloat("How tall are you(in cm)?");

                float BMI = CalculateBmi(weight, height);

                PrintResult(firstName, surName, age, weight, height, BMI);
            }
            GatherInfo("first");
            GatherInfo("second");
        }
        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            string Name = Console.ReadLine();

            if (string.IsNullOrEmpty(Name))
            {
                Console.WriteLine("Name cannot be empty.");
                return "-";
            }
            else return Name;
        }
        public static int PromptInt(string message)
        {
            Console.WriteLine(message);
            var Age = Console.ReadLine();
            int checkInt;

            if (string.IsNullOrEmpty(Age))
            {
                Console.WriteLine("Don't want your age to be known eh? No matter.");
                return 0;
            }
            else if (!int.TryParse(Age, out checkInt))
            {
                Console.WriteLine($"\"{Age}\" is not a valid number.");
                return -1;
            }
            else return checkInt;
        }
        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            var dimensions = Console.ReadLine();
            float checkFloat;

            if (string.IsNullOrEmpty(dimensions))
            {
                return 0;
            }
            else if (!float.TryParse(dimensions, out checkFloat))
            {
                Console.WriteLine($"\"{dimensions}\" is not a valid number.");
                return -1;
            }
            else return checkFloat;
        }
        private static float ConvertToMeters(float height)
        {
            float mHeight = (height / 100);
            return mHeight;
        }
        public static float CalculateBmi(float weight, float mHeight)
        {
            bool checkResults = true;
            string response = "Failed calculating BMI. Reason:";

            if (weight <= 0)
            {
                response += $"\r\nWeight cannot be equal or less than zero, but was {weight}.";
                checkResults = false;
            }
            if (mHeight <= 0)
            {
                if (checkResults == false)
                {
                    response += $"\r\nHeight cannot be less than zero, but was {mHeight}.";
                }
                else
                {
                    response += $"\r\nHeight cannot be equal or less than zero, but was {mHeight}.";
                    checkResults = false;
                }

                Console.WriteLine(response);
                if (checkResults == false)
                {
                    return -1;
                }
            }

            float BMI = (weight / (mHeight * mHeight));
            return BMI;
        }
        public static void PrintResult(string firstName, string surName, int age, float weight, float height, float BMI)
        {
            Console.WriteLine($"\r\n{firstName} {surName} is {age} years old, their weight is {weight} kg and they are {height} cm tall.\r\nThey have a BMI of {BMI}\r\n");
        }
    }
}