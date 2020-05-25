using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter
{
    public static class BinaryConverter
    {
        public static long ToInteger(string binary)
        {
            if (string.IsNullOrEmpty(binary))
                return 0;
            
            if (!binary.Contains("0") && !binary.Contains("1"))
                throw new InvalidBinaryNumberException(binary);

            double number = 0;
            char[] binaryNumbers = binary.ToCharArray();

            for (int i = binaryNumbers.Length -1; i >= 0; i--)
            {
                int a = (binaryNumbers.Length - (i + 1));
                double power = Math.Pow(2, a);

                number +=Char.GetNumericValue(binaryNumbers[i]) * power;
            }

            return long.Parse(number.ToString());
        }

        public static string ToBinary(long number)
        {
            string binaryValue = "";

            if (number == 0)
            {
                return "0";
            }

            if (number == 1)
            {
                binaryValue = "1" + binaryValue;
                number -= 1;
            }

            while (number >= 0)
            {
                if (number % 2 == 1)
                {
                    binaryValue = "1" + binaryValue;
                    number -= 1;
                    number /= 2;
                }

                if (number == 0)
                    return binaryValue;

                binaryValue = "0" + binaryValue;
                number /= 2;
            }
            //return Convert.ToString(Convert.ToInt32(number, 16), 2);
            return binaryValue;
        }
    }
}
