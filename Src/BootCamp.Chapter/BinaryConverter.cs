using System;
using System.Collections.Generic;
using System.Text;


namespace BootCamp.Chapter
{
    public static class BinaryConverter
    {
        public static long ToInteger(string binary)
        {
            if (!(binary==null || binary == ""))
            {
                char[] binaryArray = binary.ToCharArray();
                long value = 0;
                int bit = 0;
                for (var i = 0; i < binary.Length; i++)
                {
                 
                    if (binary[i] == '0' || binary[i] == '1')
                    {
                        int.TryParse(binary[i].ToString(), out bit);

                        value += (bit * (long)Math.Pow(2, binary.Length - i - 1));
                    }
                    else
                        throw new InvalidBinaryNumberException(binary);
                    
                }
                return value;
            }
            return 0;

        }

        public static string ToBinary(long number)
        {
            string binary = "";
            bool complete = true;
            
            while (complete)
            {
                binary += number % 2;
                if ((number > 1))
                {
                    number = ( number / 2); 
                }
                else
                {
                    complete = false;
                }
            }

            if(!complete)
            {
                char[] result = binary.ToCharArray();
                char[] binaryResult = new char[result.Length];
                Console.WriteLine(result);
                for (var i=0;i<result.Length;i++)
                {
                    binaryResult[i] = result[result.Length - i - 1 ];
                }
                binary = new string( binaryResult);
            }

            return binary;
        }
    }
}
