using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BootCamp.Chapter
{
    public static class BinaryConverter
    {
        public static long ToInteger(string binary)
        {
            if (string.IsNullOrEmpty(binary))
            {
                return 0;
            }
            long sum = 0;
            long bitValue = 1;
            for (int i = 0; i < binary.Length; i++)
            {
                string bitString = binary[(binary.Length - 1) - i].ToString();
                if (bitString != "0" && bitString != "1")
                {
                    throw new InvalidBinaryNumberException(bitString);
                }
                short bitTemp = short.Parse(bitString);
                sum = sum + (bitTemp * bitValue);
                bitValue = bitValue * 2;
            }
            return sum;
        }

        public static string ToBinary(long number)
        {
            StringBuilder resultReversed = new StringBuilder();
            long divideThis = number;
            do
            {
                long reminder = divideThis % 2;
                divideThis = divideThis / 2;
                resultReversed.Append(reminder.ToString());
            } while (divideThis != 0);
            return ReverseString(resultReversed);
        }

        public static string ReverseString(StringBuilder input)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                result.Append(input[(input.Length - 1) - i]);
            }
            return result.ToString();
        }
    }
}
