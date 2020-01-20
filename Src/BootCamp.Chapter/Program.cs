using System;

namespace BootCamp.Chapter
{
    class Program
    {
        //test to see if I can push
        static void Main(string[] args)
        {
            bool moreEntries = true;
            while (moreEntries)
            {
                //ask for first input of name
                // then send call method to make sure it fits name paramter of only letters and assign to name variable
                Console.WriteLine("Please enter your first name.");
                string firstName = CheckStringForLettersOnly();

                // same as first name but for last name
                Console.WriteLine("Please enter your last name.");
                string lastName = CheckStringForLettersOnly();


                // same as name inputs but for age
                //call age method and check to make sure it fits parameter of numbers only.
                Console.WriteLine("Please enter your age.");
                //I went with float for age because maybe someone likes to put percent of new age such as 7.5 years old...
                float age = float.Parse(CheckStringForDigitsOnly());

                //same as age
                Console.WriteLine("Please enter your weight in kg.");
                float weightInKg = float.Parse(CheckStringForDigitsOnly());

                //same as age
                Console.WriteLine("Please enter your height in cm.");
                float height = float.Parse(CheckStringForDigitsOnly());


                //after all values added run this at end of program
                Console.WriteLine("Thank you for your information. You entered:");

                //now dispaly the data that was given in a sentence. 
                Console.WriteLine($"\n``` {firstName} {lastName} is {age} years old, your weight is {weightInKg} kg and" +
                                  $" your height is {height} cm. ```");

                Console.WriteLine("\nWould you like to enter another person? " +
                                                           "Press Y to enter another or any other button to exit.");

                //changed this to .ToLowerInvariant() as suggested
                string checkAnswer = Console.ReadLine().ToLowerInvariant();
                if(checkAnswer != "y" )
                {
                    Console.WriteLine("You chose not to enter another user. Thank you, goodbye.");
                    moreEntries = false;
                }

            }
        }

        //Method that checks if string has only letters in it
        private static string CheckStringForLettersOnly()
        {
            bool stop = true;
            string testString = "";

            while (stop)
            {
                //read the input from console this is what will be tested for only letters
                testString = Console.ReadLine();

                //check it by calling the method IsAllLetters
                // if it has a number run this 
                if (!IsAllLetters(testString))
                {
                    Console.WriteLine("You entereted that wrong. Please try again.\n");
                }
                //otherwise set stop to false and exit while loop
                else
                {
                    stop = false;
                }
            }
            //return the approved string
            return testString;
        }

        //check each character in string to see if it has any numbers
        public static bool IsAllLetters(string testForLetters)
        {
            foreach (char c in testForLetters)
            {
                //if it has a number return it as false
                if (!Char.IsLetter(c))
                {
                    return false;
                }
            }
            // if passed return true.
            return true;
        }

        //same as checking the letters but for numbers only
        private static string CheckStringForDigitsOnly()
        {
            bool stop = true;
            string testDigits = "";

            while (stop)
            {
                testDigits = Console.ReadLine();

                if (! IsAllDigits(testDigits))
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

        //same as checking for letters but for numbers
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
    }
}
