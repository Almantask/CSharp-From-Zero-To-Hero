using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public static class BinaryConverter
    {
        public static long ToInteger(string binary)
        {
            return Conversions.ConvertBinaryToDecimal();
        }

        public static string ToBinary(long number)
        {
            return Conversions.ConvertDecimalToBinary(); ;
        }
    }
}
