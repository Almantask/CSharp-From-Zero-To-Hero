using System;

namespace BootCamp.Chapter
{
    public static class BinaryConverter
    {
        public static long ToInteger(string binary)
        {
            if (String.IsNullOrEmpty(binary))
            {
                return 0L;
            }
            var isValid = IsBin(binary);
            if (!isValid)
            {
                throw new InvalidBinaryNumberException(binary);
            }
            var number = int.Parse(binary);
            int convertedNumber = 0;
            int base1 = 1;

            while (number > 0)
            {
                int remainder = number % 10;
                number /= 10;
                convertedNumber += remainder * base1;
                base1 *= 2;
            }
            return convertedNumber;
        }

        public static bool IsBin(string s)
        {
            foreach (var c in s)
            {
                if (c != '0' && c != '1')
                {
                    return false;
                }
            }
            return true;
        }

        public static string ToBinary(long number)
        {
            try
            {
                long remainder;
                string result = string.Empty;
                if (number == 0)
                {
                    return "0";
                }

                while (number > 0)
                {
                    remainder = number % 2;
                    number /= 2;
                    result = remainder.ToString() + result;
                }
                return result;
            }
            catch
            {
                throw new InvalidBinaryNumberException(number.ToString());
            }
        }

        public static void ConversionToBinary()
        {
            Console.Write("Which decimal do you want to convert to binary: ");
            var input = Console.ReadLine();
            var outcome = ToBinary(long.Parse(input));
            Console.WriteLine(outcome);
        }

        public static void ConversionToInteger()
        {
            Console.Write("Which decimal do you want to convert to binary: ");
            var input = Console.ReadLine();
            var outcome = ToInteger(input);
            Console.WriteLine(outcome);
        }
    }
}