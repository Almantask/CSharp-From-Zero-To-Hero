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


        public static float CalculateBmi(float weightInKg, float height)
        {
            float bmi = weightInKg / (height * height);

           
            if((weightInKg <= 0) && (height <= 0))
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                Console.WriteLine($"Weight cannot be equal or less than zero, but was {weightInKg}.");
                Console.WriteLine($"Height cannot be less than zero, but was {height}.");
                return -1;
            }

            if(weightInKg <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                Console.WriteLine($"Weight cannot be equal or less than zero, but was {weightInKg}.");
                return -1;
            }

            if(height <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                Console.WriteLine($"Height cannot be equal or less than zero, but was {height}.");
                return -1;
            }

            if(weightInKg >= height)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                Console.WriteLine("Weight cannot be more or equal to height.");
                Console.WriteLine($" Height= {height}, Weight= {weightInKg}.");
                return -1;
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
            

            if (string.IsNullOrEmpty(toAnInt))
            {
                return 0;
            }
           

            bool isInt = int.TryParse(toAnInt, out int age);

            if(!isInt)
            {
                Console.Write($"\"{toAnInt}\" is not a valid number.");
                return -1 ;
            }

            return age;
        }


        public static string ConvertToString(string message)
        {
            Console.WriteLine(message);

            string readInString = Console.ReadLine();

            
           if(string.IsNullOrEmpty(readInString))
            {
                Console.Write($"Name cannot be empty.");
                return "-";
            }
            
            return readInString;
        }


        public static float ConvertToFloat(string message)
        {
            Console.WriteLine(message);

            string toAFloat = Console.ReadLine();

            if (string.IsNullOrEmpty(toAFloat))
            {
               // Console.WriteLine("You did not enter anything.");
                return 0;
            }

            bool isFloat = float.TryParse(toAFloat, out float measurement);

            if(!isFloat)
            {
                Console.Write($"\"{toAFloat}\" is not a valid number.");
                return -1;
            }
            if(measurement <= 0 )
            {
                return -1;
            }

            return measurement;
        }


    }
}