using System;
using Console = System.Console;

namespace BootCamp.Chapter
{
    class Lesson3
    {

        public static void Demo()
        {
            bool moreEntries = true;

            while (moreEntries)
            {
               // UserInfo();
                string convertedStringName = ConvertToString("Enter your name.");
                Console.WriteLine($"Your converted string is \"{convertedStringName}\"");

                int convertedIntAge = ConvertToInt("\nEnter your age, no '.'");
                Console.WriteLine($"Your converted int is \"{convertedIntAge}\"");

                float convertedFloatHeight = ConvertToFloat("\nEnter your height in meters. '.' is ok to use.");
                Console.WriteLine($"Your converted float is \"{convertedFloatHeight}\"");

                float convertedFloatWeight = ConvertToFloat("\nEnter your weight in kg. '.' is ok to use.");
                Console.WriteLine($"Your converted float is \"{convertedFloatWeight}\"\n");

                CalculateBmi(convertedFloatWeight, convertedFloatHeight);

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


        //public static void UserInfo()
        //{

        //    Console.WriteLine("Please enter your first name.");
        //    string firstName = CheckStringForLettersOnly();



        //    Console.WriteLine("Please enter your last name.");
        //    string lastName = CheckStringForLettersOnly();



        //    Console.WriteLine("Please enter your age.");
        //    //I went with float for age because maybe someone likes to put percent of new age such as 7.5 years old...
        //    float age = float.Parse(CheckStringForDigitsOnly());



        //    Console.WriteLine("Please enter your weight in kg.");
        //    float weightInKg = float.Parse(CheckStringForDigitsOnly());


        //    Console.WriteLine("Please enter your height in meters.");
        //    float height = float.Parse(CheckStringForDigitsOnly());


        //    Console.WriteLine("Thank you for your information. You entered:");

        //    Console.WriteLine($"\n``` {firstName} {lastName} is {age} years old, your weight is {weightInKg} kg and" +
        //                      $" your height is {height} cm. ```");


        //    CalculateBmi(weightInKg, height);
        //}


        //Make sure string has only letters
        //public static string CheckStringForLettersOnly()
        //{
        //    bool stop = true;
        //    string testString = "";

        //    while (stop)
        //    {
        //        testString = Console.ReadLine();

        //        if (!IsAllLetters(testString))
        //        {
        //            Console.WriteLine("You entereted that wrong. Please try again.\n");
        //        }

        //        else
        //        {
        //            stop = false;
        //        }
        //    }

        //    return testString;
        //}

        ////check each character in string to see if it has any numbers
        //public static bool IsAllLetters(string testForLetters)
        //{
        //    foreach (char c in testForLetters)
        //    {

        //        if (!Char.IsLetter(c))
        //        {
        //            return false;
        //        }
        //    }

        //    return true;
        //}

        ////Make sure string has only numbers
        //public static string CheckStringForDigitsOnly()
        //{
        //    bool stop = true;
        //    string testDigits = "";

        //    while (stop)
        //    {
        //        testDigits = Console.ReadLine();

        //        if (!IsAllDigits(testDigits))
        //        {
        //            Console.WriteLine("You entereted that wrong. Please try again.\n");
        //        }
        //        else
        //        {
        //            stop = false;
        //        }
        //    }

        //    return testDigits;
        //}

        ////Make sure string is only numbers also allowed to have '.'
        //public static bool IsAllDigits(string testForNumbers)
        //{
        //    foreach (char c in testForNumbers)
        //    {
        //        if (!Char.IsDigit(c) && c != '.')
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}


        public static float CalculateBmi(float weightInKg, float height)
        {
            float bmi = weightInKg / (height * height);

            if(weightInKg <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                Console.WriteLine($"Weight cannot be equal or less than zero, but was {weightInKg}.");
            }

            if(height <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                Console.WriteLine($"Height cannot be equal or less than zero, but was {height}.");
            }

            Console.WriteLine($"\nYour BMI based on your heigh of {height}m and your weight of {weightInKg}Kg " +
                             $"is {bmi} kg/(m*m)");
            return bmi;
        }

        //For Checks
        public static int ConvertToInt(string message)
        {
            Console.WriteLine(message);

            string toAnInt = Console.ReadLine();

            if (toAnInt == string.Empty)
            {
                Console.WriteLine("You entered no age.");
                return 0;
            }

            bool isInt = int.TryParse(toAnInt, out int age);
            if(!isInt)
            {
                Console.WriteLine($"{toAnInt} is an invalid number.");
                return -1 ;
            }

            return age;
        }


        public static string ConvertToString(string message)
        {
            Console.WriteLine(message);

            string readInString = Console.ReadLine();

            //check string if null empty or just white space
           if(string.IsNullOrWhiteSpace(readInString))
            {
                Console.WriteLine($"Name can not be empty.");
                return "-";
            }
            
            return readInString;
        }


        public static float ConvertToFloat(string message)
        {
            Console.WriteLine(message);

            string toAFloat = Console.ReadLine();

            if (toAFloat == string.Empty)
            {
                Console.WriteLine("You did not enter anything.");
                return 0;
            }

            bool isFloat = float.TryParse(toAFloat, out float measurement);

            if(!isFloat)
            {
                Console.WriteLine($"{toAFloat} is not a valid number.");
                return -1;
            }

            
            
            return measurement;
        }


    }
}