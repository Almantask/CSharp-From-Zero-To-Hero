using System;
using System.Text.RegularExpressions;

namespace BootCamp.Chapter
{
    class Conversions
    {
        private const int BINARYARRAYLENGTH = 40;
        public static void Demo()
        {
            Console.WriteLine("Convert Decimal To Binary");
            ConvertDecimalToBinary();
            Console.WriteLine();
            Console.WriteLine("Convert Binary To Decimal");
            ConvertBinaryToDecimal();
        }

        private static void ConvertDecimalToBinary()
        {
            int i;
            int[] binaryHolder = new int[BINARYARRAYLENGTH];
            int decimalNumber = GetDecimalInput();
            i = 0;
            while (decimalNumber > 0)
            {
                binaryHolder[i] = decimalNumber % 2;
                decimalNumber = decimalNumber / 2;
                i++;
            }
            Console.Write("Binary of the given number= ");
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(binaryHolder[i]);
            }
        }

        private static int GetDecimalInput()
        {
            Console.Write("Enter the number to convert: ");
            if (!int.TryParse(Console.ReadLine(), out int decimalNumber))
            {
                Console.WriteLine("That wasn't a decimal number. Please try again");
                return GetDecimalInput();
            }

            return decimalNumber;
        }

        private static void ConvertBinaryToDecimal()
        {
            int decimalValue = 0;
            string binary = GetBinaryInput();
            char[] bits = binary.ToCharArray();
            for (int j = 0; j <= bits.Length - 1; j++)
            {
                int currentBit = bits[j] - '0';
                decimalValue += (int)(currentBit * Math.Pow(2, (bits.Length - 1 - j)));
            }
            Console.WriteLine($"A binary string of {binary} is equivalent to a decimal value of {decimalValue}.");
        }

        private static string GetBinaryInput()
        {
            Console.Write("Enter the binary number to convert: ");
            string binary = Console.ReadLine();
            while (!Regex.IsMatch(binary, @"^[0-1]+$"))
            {
                Console.WriteLine("A binary number may only contain 1's and 0's. Please try your input again.");
                binary = Console.ReadLine();
            }

            return binary;
        }
    }
    } 
