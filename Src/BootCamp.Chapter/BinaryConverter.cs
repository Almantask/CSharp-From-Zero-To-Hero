using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace BootCamp.Chapter
{
    public static class BinaryConverter
    {
        public const int BINARYARRAYLENGTH = 40;
        public static long ToInteger(string binary)
        {
            return ConvertBinaryToDecimal(binary);
        }

        public static string ToBinary(long number)
        {
            return ConvertDecimalToBinary(number);
        }

        public static int ConvertBinaryToDecimal(string binary)
        {
            if (binary == null)
            {
                return 0;
            }
            int decimalValue = 0;
            char[] bits = binary.ToCharArray();
            for (int j = 0; j <= bits.Length - 1; j++)
            {
                if (Regex.IsMatch(bits[j].ToString(), @"^[0-1]+$"))
                {
                    int currentBit = bits[j] - '0';
                    decimalValue += (int)(currentBit * Math.Pow(2, (bits.Length - 1 - j)));
                }
                else 
                {
                    throw new InvalidBinaryNumberException(bits[j].ToString());
                }
            }
            return decimalValue;
        }
        public static string ConvertDecimalToBinary(long number)
        {
            if (number == 0)
            {
                return "0";
            }
            int i = 0;
            long[] binaryHolder = new long[BINARYARRAYLENGTH];
            while (number > 0)
            {
                binaryHolder[i] = number % 2;
                number = number / 2;
                i++;
            }
            StringBuilder sb = new StringBuilder();
            for (i = i - 1; i >= 0; i--)
            {
                sb.Append(binaryHolder[i]);
            }
            return sb.ToString();
        }
    }
}
