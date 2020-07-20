using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public static class BinaryConverter
    {
        public static long ToInteger(string binary)
        {
            try
            {
                if (string.IsNullOrEmpty(binary))
                {
                    return 0;
                }
                var decimalNumber = Convert.ToInt32(binary, 2);
            }
            catch(Exception exc)
            {

            }
            return decimalNumber;
        }

        public static string ToBinary(long number)
        {
            
            string binary = Convert.ToString(number, 2);
            return binary;
        }
    }
}
