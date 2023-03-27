using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace BootCamp.Chapter
{
    public static class BinaryConverter
    {
        public static long ToInteger(string binary)
        {
            if (string.IsNullOrEmpty(binary))
                return 0;

            Regex regex = new Regex("[0-1]+");
            if (regex.IsMatch(binary) == false)
            {
                throw new InvalidBinaryNumberException(binary);
            }

            char[] chars = binary.ToCharArray();

            long result = 0;

            int currentPowerOfTwo = 1;
            // Turn binary into number
            for (int i = binary.Length - 1; i >= 0; i--)
            {
                int digit = int.Parse(chars[i].ToString());
                result += digit * currentPowerOfTwo;
                currentPowerOfTwo *= 2;
            }

            return result;
        }

        public static string ToBinary(long number)
        {
            int[] binaryReversed = new int[8];

            long numberToDivide = number;

            for (int i = binaryReversed.Length - 1; i > 0; i--)
            {
                int value = (int) numberToDivide % 2;
                binaryReversed[i] = value;
                numberToDivide /= 2;
            }

            string binary = "";
            bool enteredFirstValue = false;
            foreach (var bit in binaryReversed)
            {
                if (!enteredFirstValue && bit == 0)
                    continue;

                binary += bit;
                enteredFirstValue = true;
            }

            if (binary.Length == 0)
            {
                binary = "0";
            }

            return binary;
        }
    }
}