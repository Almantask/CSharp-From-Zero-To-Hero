using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public static class BinaryConverter
    {
        public static long ToInteger(string binary)
        {
            long Long = 0;   
            var power = 0;

            try
            {
                for (var i = binary.Length - 1; i >= 0; i--, power++)
                {
                    if (binary[i] != '0' && binary[i] != '1') throw new InvalidBinaryNumberException(binary);
                    Long += long.Parse(Convert.ToString(int.Parse(binary[i].ToString()) * Math.Pow(2, power)));
                }
            }
            catch (Exception e)
            { 
                if(e is NullReferenceException) return 0;
                if(e is FormatException) throw new InvalidBinaryNumberException(binary);
                throw;
            }
            
            return Long;
        }

        public static string ToBinary(long number)
        {
            int remainder = 0;
            string result = "";
            if (number == 0) return "0";
            
            while (number > 0)
            {
                remainder = Convert.ToInt32(number % 2);
                number /= 2;
                result = remainder + result;
            }

            return result;
        }
    }
}
