using System;

namespace BootCamp.Chapter
{
    public class Program
    {
        private static void Main(string[] args)
        {
            ConvertFromDecimalToBinary();
            ConvertFromBinaryToDecimal();
            PrintEmicon();
        }

        private static void PrintEmicon()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Give a a W, A, S or D");
            var input = Console.ReadLine().ToUpper();
            var output = ""; 
            switch (input)
            {
                case "W":
                    output = "↥";
                    break;

                case "A":
                    output = "↤";
                    break;

                case "S":
                    output = "↧";
                    break;

                case "D":
                    output = "↦";
                    break;

                default:
                    output = "This is not a valid character. YOu must choose between w,a,s or d";
                    break; 
            }

            Console.WriteLine(output);
        }

        private static void ConvertFromBinaryToDecimal()
        {
            Console.Write("Which  do you want to convert to binary: ");
            var input = Console.ReadLine();
            try
            {
                var binaryNumber = int.Parse(input);
                var realNumber = binaryNumber;
                int decimalValue = 0;
                int base1 = 1;

                while (binaryNumber > 0)
                {
                    int reminder = binaryNumber % 10 ;
                    binaryNumber = binaryNumber / 10;
                    decimalValue += reminder * base1;
                    base1 = base1 * 2;
                }
                Console.WriteLine($"{realNumber} is {decimalValue} in decimal.");
            }
            catch
            {
                Console.WriteLine("the input was not a whole number.");
            }
        }

        private static void ConvertFromDecimalToBinary()
        {
            Console.Write("Which integer do you want to convert to binary: ");
            var input = Console.ReadLine();
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