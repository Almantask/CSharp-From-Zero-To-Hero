using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public static class BinaryConverter
    {
        public static long ToInteger(string binary)
        {
            if (binary == null) return 0;
            if (!IsValidBinaryNumber(binary)) return 0;
            
            long converted = 0;

            for (int i = 0; i <= binary.Length -1; i++)
            {
                char character = binary[i];
                int digit = (int)Char.GetNumericValue(character);
                int potega = (int)Math.Pow(2, binary.Length -i - 1);
                converted += digit * potega;
            }
            return converted;
        }

        private static bool IsValidBinaryNumber(string binary)
        {
            for (int i = 0; i <= binary.Length - 1; i++)
            {
                if (binary[i] != '0' && binary[i] != '1') 
                    throw new InvalidBinaryNumberException(binary);
            }
            return true;

        }

        public static string ToBinary(long number)
        {
            if (number == 0) return "0";
            var converted = new StringBuilder();

            while(number >= 1)
            {
                converted.Insert(0, $"{number % 2}");
                number /= 2;
            }
            return converted.ToString();
        }
    }
}
