using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public static class CaesarCipher
    {
        private const int cipherShift = 224;

        public static string Encrypt(string plainMessage, int cipherKey)
        {
            if (!IsStringValid(plainMessage))
            {
                Console.WriteLine("Input string is not valid");
                return plainMessage;
            }

            var output = new StringBuilder();
            foreach (var inputChar in plainMessage)
            {
                output.Append(EncodeCharacter(inputChar, cipherKey));
            }
            return output.ToString();
        }

        public static string Decrypt(string encryptedMessage, int cipherKey)
        {
            if (!IsStringValid(encryptedMessage))
            {
                Console.WriteLine("Input string is not valid");
                return encryptedMessage;
            }
            var decryptedMessage = Encrypt(encryptedMessage, cipherShift - cipherKey);
            return decryptedMessage;
        }

        private static bool IsPrintableChar(char inputCharacter)
        {
            // printable characters are int are in the 32-255 range and not 127(DEL)
            if (inputCharacter < 32 && inputCharacter > 255 && inputCharacter != 127)
            {
                return false;
            }
            return true;
        }

        // this method exists because sometimes dividend % divers returns negative number
        private static int Mod(int dividend, int divisor)
        {
            int remainder = dividend % divisor;
            if (remainder < 0)
            {
                return remainder + divisor;
            }
            return remainder;
        }

        private static char EncodeCharacter(char inputCharacter, int shift)
        {
            // printable characters are in the 32-255 range and not 127(DEL)
            if (!IsPrintableChar(inputCharacter))
            {
                return inputCharacter;
            }

            const int offset = 32;

            var output = (char)(Mod(inputCharacter + shift - offset, cipherShift) + offset);
            return output;
        }

        private static bool IsStringValid(string input)
        {
            return !string.IsNullOrEmpty(input) || !string.IsNullOrEmpty(input);
        }

        public static int[] AnalyseFrequency(string encryptedMessage, int keyTollerance = 2)
        {
            if (!IsStringValid(encryptedMessage))
            {
                Console.WriteLine("Input is not a valid string");
            }

            int[] characters = new int[char.MaxValue];

            foreach (char item in encryptedMessage)
            {
                characters[item]++;
            }

            int[] numberOfOccurrences = new int[0];
            int[] lettersOccurred = new int[0];

            for (int i = 0; i < char.MaxValue; i++)
            {
                if (characters[i] > 0 && char.IsLetter((char)i))
                {
                    numberOfOccurrences = ArrayOps.InsertLast(numberOfOccurrences, characters[i]);
                    lettersOccurred = ArrayOps.InsertLast(lettersOccurred, i);
                }
            }

            var highestOccurrence = ArrayOps.FindMaxValue(numberOfOccurrences);
            // letter E is the most common
            const int lowerE = 101;
            const int upperE = 69;
            var possibleKeys = new int[0];
            int currentKey;

            for (int i = 0; i < lettersOccurred.Length; i++)
            {
                if (numberOfOccurrences[i] > highestOccurrence - keyTollerance)
                {
                    if (char.IsUpper((char)lettersOccurred[i]))
                    {
                        currentKey = (lettersOccurred[i] - upperE);
                        possibleKeys = ArrayOps.InsertLast(possibleKeys, currentKey);
                    }
                    currentKey = lettersOccurred[i] - lowerE;
                    possibleKeys = ArrayOps.InsertLast(possibleKeys, currentKey);
                }
            }
            return possibleKeys;
        }
    }
}