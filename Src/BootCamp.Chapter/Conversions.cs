﻿using System;
<<<<<<< HEAD
=======
using System.Collections.Generic;
using System.Text;
>>>>>>> 3ccdb32e75cfac3de3437700b11d80795480c7f2
using System.Text.RegularExpressions;

namespace BootCamp.Chapter
{
    class Conversions
    {
        public static void Demo ()
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
<<<<<<< HEAD
            int[] binaryHolder = new int[40];
=======
            int[] a = new int[40];
>>>>>>> 3ccdb32e75cfac3de3437700b11d80795480c7f2
            Console.Write("Enter the number to convert: ");
            if (!int.TryParse(Console.ReadLine(), out int decimalNumber))
            {
                Console.WriteLine("That wasn't a decimal number. Please try again");
                ConvertDecimalToBinary();
            }
<<<<<<< HEAD
            i = 0;
            while (decimalNumber>0)
            {
                binaryHolder[i] = decimalNumber % 2;
                decimalNumber = decimalNumber / 2;
                i++;
=======
            for (i = 0; decimalNumber > 0; i++)
            {
                a[i] = decimalNumber % 2;
                decimalNumber = decimalNumber / 2;
>>>>>>> 3ccdb32e75cfac3de3437700b11d80795480c7f2
            }
            Console.Write("Binary of the given number= ");
            for (i = i - 1; i >= 0; i--)
            {
<<<<<<< HEAD
                Console.Write(binaryHolder[i]);
=======
                Console.Write(a[i]);
>>>>>>> 3ccdb32e75cfac3de3437700b11d80795480c7f2
            }
        }

        private static void ConvertBinaryToDecimal()
        {
            int decimalValue = 0;
            int[] a = new int[10];
            Console.Write("Enter the binary number to convert: ");
            string binary = Console.ReadLine();
            if (!Regex.IsMatch(binary, @"^[0-1]+$"))
            {
                Console.WriteLine("A binary number may only contain 1's and 0's. Please try your input again.");
                ConvertBinaryToDecimal();
            }
            char [] bits = binary.ToCharArray();
            for (int j=0; j<=bits.Length-1; j++)
            {
                if (bits[j].Equals('0') || bits[j].Equals('1'))
                {
                    int currentBit = bits[j] - '0';
                    decimalValue += (int)(currentBit * Math.Pow(2, (bits.Length-1-j)));
                }
                else
                {
                    Console.WriteLine("The string provided must be onle 1's or 0's.");
                    ConvertBinaryToDecimal();
                }
            }
                Console.WriteLine($"A binary string of {binary} is equivalent to a decimal value of {decimalValue}.");
        }
    }
}
