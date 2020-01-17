using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialize my variables
            string firstName = "";
            string lastName = "";
            int age = 0;
            float weightInKg = 0f;
            float height = 0f;

            //ask for first input of name
            // then send call method to make sure it fits name paramter of only letters and assign to name variable
            Console.WriteLine("Please enter your first name.");
            firstName = CheckStringForLettersOnly(firstName);

            // same as first name but for last name
            Console.WriteLine("Please enter your last name.");
            lastName = CheckStringForLettersOnly(lastName);


            // same as name inputs but for age
            //call age method and check to make sure it fits parameter of numbers only.
            Console.WriteLine("Please enter your age.");
            age = int.Parse(CheckStringForDigitsOnly(age.ToString()));

            //same as age
            Console.WriteLine("Please enter your weight in kg.");
            weightInKg = float.Parse(CheckStringForDigitsOnly(weightInKg.ToString()));

            //same as age
            Console.WriteLine("Please enter your height in cm.");
            height = float.Parse(CheckStringForDigitsOnly(height.ToString()));


            //after all values added run this at end of program
            Console.WriteLine("Thank you for your information. You entered:");

            //now dispaly the data that was given in a sentence. 
            Console.WriteLine($"\n``` {firstName} {lastName} is {age} years old, your weight is {weightInKg} kg and" +
                              $" your height is {height} cm. ```");

            //tell user to press anybutton to close
            Console.WriteLine("Press any button to exit.");

            //wait for the button to be pressed
            Console.ReadKey();
        }

        //Method that checks if string has only letters in it
        private static string CheckStringForLettersOnly(string testString)
        {
            bool stop = true;
            string checkString = "";

            while (stop)
            {
                //read the input from console this is what will be tested for only letters
                testString = Console.ReadLine();
                checkString = testString;

                //check it by calling the method IsAllLetters
                // if it has a number run this 
                if (IsAllLetters(checkString) != true)
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
            return checkString;
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
        private static string CheckStringForDigitsOnly(string testDigits)
        {
            bool stop = true;
            string checkForNumbers = "";

            while (stop)
            {
                testDigits = Console.ReadLine();
                checkForNumbers = testDigits;

                if (IsAllDigits(checkForNumbers) != true)
                {
                    Console.WriteLine("You entereted that wrong. Please try again.\n");
                }
                else
                {
                    stop = false;
                }
            }

            return checkForNumbers;
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
