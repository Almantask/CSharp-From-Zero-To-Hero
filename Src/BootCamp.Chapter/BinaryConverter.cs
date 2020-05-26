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

        public static string ToBinary(long number)
        {
            return "";
        }

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
