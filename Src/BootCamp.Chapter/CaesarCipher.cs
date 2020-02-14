using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public static class CaesarCipher
    {
        // total number of ASCII printable characters
        private const int cipherShift = 224;

        // letter E is the most used letter in English texts
        public static int LowerLetter { get; set; } = 101; // lower case character

        public static int UpperLetter { get; set; } = 69; // upper case character

        public static int KeyAccuracy { get; set; } = 1;

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

        public static int[] AnalyseFrequency(string encryptedMessage, int keyAccuracy = 1)
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

            int[] repeatedCharacters = new int[0];
            int[] numberOfOccurrences = new int[0];

            for (int i = 0; i < char.MaxValue; i++)
            {
                if (characters[i] > 0 && IsPrintableChar((char)i))
                {
                    repeatedCharacters = ArrayOps.InsertLast(repeatedCharacters, i);
                    numberOfOccurrences = ArrayOps.InsertLast(numberOfOccurrences, characters[i]);
                }
            }

            return FindPosibleKeys(repeatedCharacters, numberOfOccurrences);
        }

        // bad method design but at the moment I don't know how to return two arrays
        private static int[] FindPosibleKeys(int[] repeatedCharacters, int[] numberOfOccurrences)
        {
            var highestOccurrence = ArrayOps.FindMaxValue(numberOfOccurrences);

            var possibleKeys = new int[0];
            int currentKey;

            for (int i = 0; i < repeatedCharacters.Length; i++)
            {
                if (numberOfOccurrences[i] >= highestOccurrence - KeyAccuracy)
                {
                    if (char.IsUpper((char)repeatedCharacters[i]))
                    {
                        currentKey = (repeatedCharacters[i] - UpperLetter);
                        possibleKeys = ArrayOps.InsertLast(possibleKeys, currentKey);
                    }
                    currentKey = repeatedCharacters[i] - LowerLetter;
                    possibleKeys = ArrayOps.InsertLast(possibleKeys, currentKey);
                }
            }
            return possibleKeys;
        }
    }
}