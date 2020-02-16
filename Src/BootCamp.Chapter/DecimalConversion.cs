using System;

namespace BootCamp.Chapter
{
    public class DecimalConversion
    {
        public static void Conversion()
        {
            Console.Write("Which decimal do you want to convert to binary: ");
            var input = Console.ReadLine();
            ConvertFromDecimalToBinary(input);
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