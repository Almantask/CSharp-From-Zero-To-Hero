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

            if (!IsBinary(binary))
            {
                throw new InvalidBinaryNumberException(binary);
            }

            var number = 0;
            for (int i = 0; i < binary.Length; i++)
            {
                number *= 2;
                number += int.Parse(binary[i].ToString());
            }
            return number;
        }

        public static bool IsBinary(string binary)
        {
            for (int i = 0; i < binary.Length; i++)
            {
                try
                {
                    var number = int.Parse(binary[i].ToString());
                    if (number != 0 && number != 1)
                    {
                        return false;
                    }
                }catch
                {
                    throw new InvalidBinaryNumberException(binary);
                }                
            }
            return true;
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
