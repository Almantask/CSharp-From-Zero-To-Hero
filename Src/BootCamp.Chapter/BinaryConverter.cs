using System;
using System.Text;
using System.Text.RegularExpressions;

namespace BootCamp.Chapter
{
    public static class BinaryConverter
    {
        public static long ToInteger(string binary)
        {
            if (string.IsNullOrEmpty(binary)) return 0;
            if (!Regex.IsMatch(binary, @"^[01]+$")) throw new InvalidBinaryNumberException(binary);

            var num = 0;
            foreach (var bin in binary)
            {
                if (!int.TryParse(bin.ToString(), out var value)) throw new ArgumentOutOfRangeException("An unexpected error occurred");
                var temp = num * 2;
                num = temp + value;
            }

            return num;
        }

        public static string ToBinary(long number)
        {
            if (number < 0) return "No implementation for negative numbers";

            var binary = new StringBuilder();

            var i = number;
            do
            {
                if(!char.TryParse($"{i % 2}", out var binChar)) throw new ArgumentOutOfRangeException("An unexpected error occurred");
                binary.Insert(0, binChar);
                i /= 2;
            } while (i>0);

            return binary.ToString();
        }
    }
}
