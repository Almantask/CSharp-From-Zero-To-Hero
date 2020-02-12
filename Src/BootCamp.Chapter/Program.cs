using System;
using System.Text;

namespace BootCamp.Chapter
{
    class Program
    {
        private const string LeftArrow = "\u2190";
        private const string UpwardArrow = "\u2191";
        private const string RightArrow = "\u2192";
        private const string DownArrow = "\u2193";

        private const char LeftKey = 'A';
        private const char UpwardKey = 'W';
        private const char RightKey = 'D';
        private const char DownKey = 'S';

        static void Main(string[] args)
        {
            //Part 1 - Convert with 2 conversion modes: From decimal to binary, From binary to decimal.
            ConvertNumberSystem();

            //Part 2 - Use your WASD (both capital and non capital) keys to print arrows.
            ConvertLettersToArrows();
        }

        private static void ConvertNumberSystem()
        {
            var mode = GetConversionMode();
            var number = GetNumber(mode);
            var convertedNumber = (mode == 1) ? ConvertDecimalToBinary(int.Parse(number)) : ConvertBinaryToDecimal(number).ToString(); ;
            Console.WriteLine($"Your {number} was converted to {convertedNumber}.");
        }

        private static string ConvertDecimalToBinary(int number)
        {
            var binary = new StringBuilder();
            var result = 0;

            do
            {
                result = number / 2;
                binary.Append(number % 2);
                number = result;
            } while (result != 0);

            return TruncateLeadingZeros(ReverseNumber(binary.ToString()));
        }

        private static string ReverseNumber(string number)
        {
            var reverseNumber = new StringBuilder();

            for (var i = number.Length - 1; i >= 0; i--)
            {
                reverseNumber.Append(number[i]);
            }

            return reverseNumber.ToString();
        }

        private static string TruncateLeadingZeros(string number)
        {
            var firstOneDigitIndex = number.IndexOf('1');

            return number.Substring(firstOneDigitIndex, number.Length - firstOneDigitIndex);
        }

        private static int ConvertBinaryToDecimal(string binary)
        {
            var number = 0;

            for (var i = 0; i < binary.Length; i++)
            {
                number += int.Parse(binary[i].ToString()) * (int)Math.Pow(2, binary.Length - i - 1);
            }

            return number;
        }

        private static int GetConversionMode()
        {
            Console.WriteLine("The program has 2 conversion modes:");
            Console.WriteLine("1. From decimal to binary.");
            Console.WriteLine("2. From binary to decimal.");

            var isValidMode = false;
            var mode = 0;
            do
            {
                Console.WriteLine("Choose 1 or 2:");
                isValidMode = int.TryParse(Console.ReadLine(), out mode);

                if (!isValidMode && (mode != 1 && mode != 2))
                {
                    isValidMode = false;
                }
            } while (!isValidMode);

            return mode;
        }

        private static string GetNumber(int mode)
        {
            bool isValidNumber = false;
            string number = "";

            do
            {
                Console.WriteLine("What number do you want to be converted?");

                number = Console.ReadLine();

                if (mode == 1)
                {
                    isValidNumber = int.TryParse(number, out var dmy);
                }
                else
                {
                    isValidNumber = ValidateBinary(number);
                }

            } while (!isValidNumber);

            return number;
        }


        private static bool ValidateBinary(string binary)
        {
            //Check if binary is has either 0 or 1.
            for (var i = 0; i < binary.Length; i++)
            {
                if (binary[i] != '0' && binary[i] != '1')
                {
                    return false;
                }
            }

            return true;
        }

        private static void ConvertLettersToArrows()
        {
            var keys = GetKeys();
            var convertedKeys = ConvertKeysToArrows(keys);
            var keyBytes = Encoding.UTF8.GetBytes(keys);
            var keyChars = Encoding.UTF8.GetChars(keyBytes);

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(convertedKeys);
        }

        private static string ConvertKeysToArrows(string keys)
        {
            var convertedKeys = new StringBuilder();

            for (var i = 0; i < keys.Length; i++)
            {
                switch (char.ToUpper(keys[i]))
                {
                    case LeftKey:
                        convertedKeys.Append(LeftArrow);
                        break;
                    case UpwardKey:
                        convertedKeys.Append(UpwardArrow);
                        break;
                    case RightKey:
                        convertedKeys.Append(RightArrow);
                        break;
                    case DownKey:
                        convertedKeys.Append(DownArrow);
                        break;
                }
            }

            return convertedKeys.ToString();
        }

        private static string GetKeys()
        {
            var keys = "";
            bool isValidKeys = false;

            do
            {
                Console.WriteLine("Enter WASD (both capital or non capital) keys:");
                keys = Console.ReadLine();
                isValidKeys = ValidateKeys(keys);
            } while (!isValidKeys);

            return keys;
        }

        private static bool ValidateKeys(string keys)
        {
            for (var i = 0; i < keys.Length; i++)
            {
                if (char.ToUpper(keys[i]) != LeftKey && char.ToUpper(keys[i]) != UpwardKey
                    && char.ToUpper(keys[i]) != RightKey && char.ToUpper(keys[i]) != DownKey)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
