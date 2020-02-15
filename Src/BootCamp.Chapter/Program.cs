using System;
using System.Globalization;

namespace BootCamp.Chapter
{
    public class Program
    {
        private static void Main(string[] args)
        {

            Console.Write("Which decimal do you want to convert to binary: ");
            var input = Console.ReadLine();
            ConvertFromDecimalToBinary(input);


            Console.Write("Which binary do you want to convert to decimal: ");
            input = Console.ReadLine();
            ConvertFromBinaryToDecimal(input);

            Console.WriteLine("Give a a W, A, S or D");
            input = Console.ReadLine().ToUpper(new CultureInfo("en-US", false));
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

        private static void ConvertFromBinaryToDecimal(string input)
        {
            
            try
            {
                var number = int.Parse(input);
                var copyOfNumber = number;
                int convertedNumber = 0;
                int base1 = 1;

                while (number > 0)
                {
                    int remainder = number % 10 ;
                    number /= 10;
                    convertedNumber += remainder * base1;
                    base1 *= 2;
                }
                Console.WriteLine($"{copyOfNumber} is {convertedNumber} in decimal.");
            }
            catch
            {
                Console.WriteLine("the input was not a whole number.");
            }
        }

        private static void ConvertFromDecimalToBinary(string input)
        {
            
            try
            {
                var decimalNumber = int.Parse(input);
                var realNumber = decimalNumber;
                int remainder;
                string result = string.Empty;
                while (decimalNumber > 0)
                {
                    remainder = decimalNumber % 2;
                    decimalNumber /= 2;
                    result = remainder.ToString() + result;
                }
                Console.WriteLine($"{realNumber} is {result} in decimal.");
            }
            catch
            {
                Console.WriteLine("the input was not a whole number.");
            }
        }
    }
}