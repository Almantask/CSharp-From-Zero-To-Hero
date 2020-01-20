using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class ValidateLettersOnly
    {
        //Method that checks if string has only letters in it
        public static string CheckStringForLettersOnly()
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
    }
}
