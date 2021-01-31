using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public static class BinaryConverter
    {
        public static long ToInteger(string binary)
        {
            if (binary == null || binary == string.Empty)
                return 0;

            else if (IsBinary(binary))
            {
                long num = Convert.ToInt32(binary, 2);
                return num;
            }
            else
            {
                throw new InvalidBinaryNumberException(binary);
            }
        }

        public static string ToBinary(long number)
        {
            string str = Convert.ToString(number, 2);
            return str;
        }

        private static bool IsBinary(string str)
        {
            bool result = false;

            foreach (char number in str)
            {
                if (number == '0' || number == '1')
                    result = true;
            }
            return result;
        }
    }
}