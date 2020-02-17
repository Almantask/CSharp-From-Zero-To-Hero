using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public static class BinaryConverter
    {
        public static long ToInteger(string binary)
        {

            return 0;
        }

        public static string ToBinary(long number)
        {
            StringBuilder sb = new StringBuilder();
            do
            {
                sb.Append(number % 2);
                number /= 2;
            } while (number != 0);            

            return ReverseString(sb.ToString());
        }
        public static string ReverseString(string text)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = text.Length - 1; i >= 0; i--)
            {
                sb.Append(text[i]);
            }
            return sb.ToString();
        }
    }
}
