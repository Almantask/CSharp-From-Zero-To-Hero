using System;

namespace BootCamp.Chapter
{
    public class BinaryConversion
    {
        public static void Conversion()
        {
            Console.Write("Which binary do you want to convert to decimal: ");
            var input = Console.ReadLine();
            ConvertFromBinaryToDecimal(input);
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
                    int remainder = number % 10;
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
    }
}