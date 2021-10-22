using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
  
    public static class BinaryConverter
    {
        public static long ToInteger(string binary)
        {
            char[] array = binary.ToCharArray();
            Array.Reverse(array);
            if (IsNullOrEmpty(array)) return 0;

            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == '1')
                {
                    if (i == 0)
                    {
                        sum += 1;
                    }
                    else
                    {
                        sum += (int)Math.Pow(2, i);
                    }
                }
            }

            return sum;
        }

        public static string ToBinary(long number)
        {
            string result = string.Empty;
            int rem = 0;
          
            int num = (int)number;
            while (num > 0)
            {
                rem = num % 2;
                num = num / 2;
                result = rem.ToString() + result;
            }

            return result;
        }

        public static bool IsNullOrEmpty(this Array array)
        {
            return (array == null || array.Length == 0);
        }
    }
}
