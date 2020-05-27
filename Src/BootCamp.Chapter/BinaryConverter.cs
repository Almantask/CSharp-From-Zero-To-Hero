using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter
{
    public static class BinaryConverter
    {
        /// <summary>
        /// Convert binary to Integer
        /// </summary>
        /// <param name="binary">binary string</param>
        /// <returns>int number</returns>
        public static long ToInteger(string binary)
        {
            if (!IsValidBinaryNumber(binary))
                return 0;

            int intResult = 0;
            var j = 0; 

            for (int i = binary.Length - 1; i >= 0; i--, j++)
            {
                intResult = intResult + (int)Char.GetNumericValue(binary[i]) * (int)(MathF.Pow(2, j));
            }

            return intResult;
        }

        /// <summary>
        /// Convert long to binary string
        /// </summary>
        /// <param name="number">number</param>
        /// <returns>binary string</returns>
        public static string ToBinary(long number)
        {
            if (number == 0)
                return "0";

            long remainder;
            string result = string.Empty;
            while (number > 0)
            {
                remainder = number % 2;
                number /= 2;
                result = remainder.ToString() + result;
            }
            return result;
        }

        /// <summary>
        /// Check if binary string is valid
        /// </summary>
        /// <param name="binary">binary string</param>
        /// <returns>Is valid</returns>
        private static bool IsValidBinaryNumber(string binary)
        {
            bool isValid = true;
            var validNumbers = new string[] { "0", "1" };
            if (string.IsNullOrEmpty(binary))
                return false;

            for (int i = 0; i < binary.Length; i++)
            {
                if (!(validNumbers.Contains(binary[i].ToString())))
                    throw new InvalidBinaryNumberException(binary[i].ToString());
            }

            return isValid;
        }        
    }
}
