﻿using System;

namespace BootCamp.Chapter
{
    class Lesson3
    {
        public static void Demo()
        {
            bool moreEntries = true;

            while (moreEntries)
            {
                UserInfo();
                moreEntries = AddAnotherPerson();
            }
        }

        public static bool AddAnotherPerson()
        {
            bool moreEntries = true;

            Console.WriteLine("\nWould you like to enter another person? " +
                                                           "Press Y to enter another or any other button to exit.");

            string checkAnswer = Console.ReadLine().ToLowerInvariant();

            if (checkAnswer != "y")
            {
                Console.WriteLine("You chose not to enter another user. Thank you, goodbye.");
                moreEntries = false;
            }

            return moreEntries;

        }

        public static float CalculateBmi(float weightInKg, float height)
        {
            float bmi = weightInKg / (height * height);

            Console.WriteLine($"\nYour BMI based on your heigh of {height}m and your weight of {weightInKg}Kg " +
                             $"is {bmi} kg/(m*m)");
            return bmi;
        }


        public static void UserInfo()
        {
            
            Console.WriteLine("Please enter your first name.");
            string firstName = CheckStringForLettersOnly();

       
            Console.WriteLine("Please enter your last name.");
            string lastName = CheckStringForLettersOnly();


            Console.WriteLine("Please enter your age.");
            //I went with float for age because maybe someone likes to put percent of new age such as 7.5 years old...
            float age = float.Parse(CheckStringForDigitsOnly());

         
            Console.WriteLine("Please enter your weight in kg.");
            float weightInKg = float.Parse(CheckStringForDigitsOnly());

          
            Console.WriteLine("Please enter your height in meters.");
            float height = float.Parse(CheckStringForDigitsOnly());

         
            Console.WriteLine("Thank you for your information. You entered:");

            Console.WriteLine($"\n``` {firstName} {lastName} is {age} years old, your weight is {weightInKg} kg and" +
                              $" your height is {height} cm. ```");

            
            CalculateBmi(weightInKg, height);
        }


        //Make sure string has only letters
        public static string CheckStringForLettersOnly()
        {
            bool stop = true;
            string testString = "";

            while (stop)
            {
                testString = Console.ReadLine();

                if (!IsAllLetters(testString))
                {
                    Console.WriteLine("You entereted that wrong. Please try again.\n");
                }
                
                else
                {
                    stop = false;
                }
            }
            
            return testString;
        }

        //check each character in string to see if it has any numbers
        public static bool IsAllLetters(string testForLetters)
        {
            foreach (char c in testForLetters)
            {
               
                if (!Char.IsLetter(c))
                {
                    return false;
                }
            }
         
            return true;
        }

        //Make sure string has only numbers
        public static string CheckStringForDigitsOnly()
        {
            bool stop = true;
            string testDigits = "";

            while (stop)
            {
                testDigits = Console.ReadLine();

                if (!IsAllDigits(testDigits))
                {
                    Console.WriteLine("You entereted that wrong. Please try again.\n");
                }
                else
                {
                    stop = false;
                }
            }

            return testDigits;
        }

        //Make sure string is only numbers also allowed to have '.'
        public static bool IsAllDigits(string testForNumbers)
        {
            foreach (char c in testForNumbers)
            {
                if (!Char.IsDigit(c) && c != '.')
                {
                    return false;
                }
            }
            return true;
        }


        //For Checks
        public static int ConvertToInt(string message)
        {
            int toAnInt = int.Parse(message);
            return toAnInt;
        }

        public static string ConvertToString(string message)
        {
            string toAString = message;
            return toAString;
        }

        public static float ConvertToFloat(string message)
        {
            float toAFloat = float.Parse(message);
            return toAFloat;
        }


    }
}
