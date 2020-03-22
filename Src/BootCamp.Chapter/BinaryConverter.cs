using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public static class BinaryConverter
    {
        public static long ToInteger(string binary)
        {
            if (String.IsNullOrEmpty(binary))
            {
                return 0;
            }
            try
            {
                int integerNumber = Convert.ToInt32(binary, 2);
                return integerNumber;
            }
            catch
            {
                throw new InvalidBinaryNumberException(binary);
            }
        }

        private static bool IsBinary(string binary)
        {
            foreach (var item in binary)
            {
                if (item != '0' || item != '1')
                {
                    return false;
                }
            }
            return true;
        }

        public static string ToBinary(long number)
        {
            string binaryWord = "";
            while (number / 2 != 0)
            {
                var binaryNumber = number % 2;
                number /= 2;
                binaryWord += binaryNumber;
            }
            binaryWord += number;

            StringBuilder sbBinary = new StringBuilder(binaryWord);
            char[] binaryArrayToReverse  = sbBinary.ToString().ToCharArray();
            Array.Reverse(binaryArrayToReverse);

            string binaryString = new string(binaryArrayToReverse);

            sbBinary.Replace(sbBinary.ToString(), binaryString);
            return sbBinary.ToString();
        }
    }
}
