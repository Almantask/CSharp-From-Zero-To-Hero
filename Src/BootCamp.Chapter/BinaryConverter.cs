using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public static class BinaryConverter
    {
        private const int OnBit = 1;
        private const int OffBit = 0;

        public static long ToInteger(string binary)
        {
            var result = 0; // We assume that the resulting number will be 0

            if (string.IsNullOrEmpty(binary)) return result;
            
            var indexofLastBit = binary.Length - 1;
            var exponent = 0; // The numerical place of a bit going from right to the left which is used in calculating the result

            for (int i = indexofLastBit; i >= 0; i--)
            {
                int currentBit = (int) Char.GetNumericValue(binary[i]);
                if (currentBit != OffBit && currentBit != OnBit) throw new InvalidBinaryNumberException(binary); // Numbers other than 0 and 1 are not allowed

                result += currentBit * (int) (MathF.Pow(2, exponent));
                exponent++; // As we go to the next bit, we increment the exponent
            }
                
            return result;
        }

        public static string ToBinary(long number)
        {
            if (number < 0) throw new ArgumentOutOfRangeException($"Negative numbers cannot be converted to binary and your input number was: {number}");

            var stringBuilder = new StringBuilder();

            while (number / 2 != 0)
            {
                var remainder = number % 2;
                stringBuilder.Insert(0, remainder); // We insert the remainder to the beginning of the StringBuilder
                number /= 2;
            }

            stringBuilder.Insert(0, number == 0 ? OffBit : OnBit); // We insert 1 bit at the beginning of the StringBuilder if the number we're trying to convert is not 0
            return stringBuilder.ToString();
        }
    }
}
