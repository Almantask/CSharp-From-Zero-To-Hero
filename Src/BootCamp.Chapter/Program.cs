using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using Console = System.Console;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static int ParseInt(string message)
        {
            Console.WriteLine(message);
            string maybeNumber = Console.ReadLine();
            bool isNumber = int.TryParse(maybeNumber, out int number);
            if (!isNumber)
            {
                Console.WriteLine($"\"{maybeNumber}\" is not a valid number.");
                return -1;
            }
            return number;
        }

        public static float FloatParse(string message)
        {
            CultureInfo.CurrentCulture = new CultureInfo("en-US");
            Console.WriteLine(message);
            string maybeNumber = Console.ReadLine();
            bool isNumber = float.TryParse(maybeNumber, out float number);
            if (!isNumber)
            {
                Console.WriteLine($"\"{maybeNumber}\" is not a valid number.");
                return -1;
            }
            return number;
        }

        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            bool isName = string.IsNullOrEmpty(input);
            if (isName)
            {
                Console.WriteLine("Name cannot be empty");
                return "-";
            }
            return input;
        }
    }
}
