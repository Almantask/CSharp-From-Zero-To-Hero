using System;
using System.Globalization;

namespace BootCamp.Chapter
{
    public class PrintEmonicons
    {
        public static void Print()
        {
            Console.WriteLine("Give a a W, A, S or D");
            var input = Console.ReadLine().ToUpper(new CultureInfo("en-US", false));
            PrintEmicon(input);
        }

        private static void PrintEmicon(string input)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            string output = input switch
            {
                "W" => "↥",
                "A" => "↤",
                "S" => "↧",
                "D" => "↦",
                _ => "This is not a valid character. You must choose between w,a,s or d",
            };
            Console.WriteLine(output);
        }
    }
}