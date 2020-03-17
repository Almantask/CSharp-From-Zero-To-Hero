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
            Stack<int> myBinaryStack = new Stack<int>();
            while (number / 2 != 0)
            {
                var binaryNumber = number % 2;
                number /= 2;
                myBinaryStack.Push((int)binaryNumber);
            }
            myBinaryStack.Push((int)number);

            StringBuilder sbBinary = new StringBuilder();
            foreach (var item in myBinaryStack)
            {
                sbBinary.Append(item);
            }
            return sbBinary.ToString();
        }
    }
}
