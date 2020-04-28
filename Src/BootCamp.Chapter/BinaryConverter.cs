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
            var integer = 0;

            if (!string.IsNullOrEmpty(binary))
            {
                try
                {
                    integer = Convert.ToInt32(binary, 2);
                }
                catch (Exception)
                {
                    throw new InvalidBinaryNumberException(binary);
                }
            }
                
            return integer;
        }

        public static string ToBinary(long number)
        {
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
