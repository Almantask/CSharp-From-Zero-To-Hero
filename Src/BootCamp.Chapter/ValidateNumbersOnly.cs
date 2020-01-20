using System;

namespace BootCamp.Chapter
{
    class ValidateNumbersOnly
    {
        //same as checking the letters but for numbers only
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
