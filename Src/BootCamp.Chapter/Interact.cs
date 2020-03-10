using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BootCamp.Chapter
{
    public static class Interact
    {
        private const string messageEmpty = "Cannot be empty.";
        private const string messageInvalidNumber = " is not a valid number.";
        private const string invalid = "-";

        public static int PromptInt(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();

            if (!StringOps.IsStringValid(input))
            {
                return 0;
            }

            if (Util.IsNumeric(input))
            {
                return Convert.ToInt32(input);
            }
            else
            {
                Logger.Log($"\"{input}\" {messageInvalidNumber}");
                return -1;
            }
        }

        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();

            if (!StringOps.IsStringValid(input))
            {
                Logger.Log(messageEmpty);
                return invalid;
            }

            return input;
        }

        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();

            if (!StringOps.IsStringValid(input))
            {
                return 0;
            }
            if (Util.IsNumeric(input))
            {
                return float.Parse(input, CultureInfo.InvariantCulture);
            }
            else
            {
                Logger.Log($"\"{input}\" {messageInvalidNumber}");
                return -1;
            }
        }
    }
}