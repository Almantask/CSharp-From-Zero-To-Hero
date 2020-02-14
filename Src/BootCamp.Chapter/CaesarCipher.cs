using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public static class CaesarCipher
    {
        private const int cipherShift = 26;

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

        private static char EncodeCharacter(char inputCharacter, int cipherKey)
        {
            if (!char.IsLetter(inputCharacter))
            {
                return inputCharacter;
            }

            char offset = (char.IsUpper(inputCharacter)) ? 'A' : 'a';

            var output = (char)((((inputCharacter + cipherKey) - offset) % cipherShift) + offset);
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

            int[] letters = new int[char.MaxValue];

            foreach (char item in encryptedMessage)
            {
                letters[item]++;
            }

            int[] numberOfOccurrences = new int[0];
            int[] lettersOccurred = new int[0];

            for (int i = 0; i < char.MaxValue; i++)
            {
                if (letters[i] > 0 && char.IsLetter((char)i))
                {
                    numberOfOccurrences = ArrayOps.InsertLast(numberOfOccurrences, letters[i]);
                    lettersOccurred = ArrayOps.InsertLast(lettersOccurred, i);
                }
            }

            var highestOccurrences = ArrayOps.FindMaxValue(numberOfOccurrences);
            const int lowerE = 101;
            const int upperE = 69;
            var possibleKeys = new int[0];
            int currentKey;

            for (int i = 0; i < lettersOccurred.Length; i++)
            {
                if (numberOfOccurrences[i] > highestOccurrences - keyTollerance)
                {
                    if (char.IsUpper((char)lettersOccurred[i]))
                    {
                        currentKey = (lettersOccurred[i] - upperE);
                        possibleKeys = ArrayOps.InsertLast(possibleKeys, currentKey);
                    }
                    currentKey = lettersOccurred[i] - lowerE;
                    possibleKeys = ArrayOps.InsertLast(possibleKeys, currentKey);

                    //Console.WriteLine($"Possible key found: {currentKey}");
                }
            }
            return possibleKeys;
        }
    }
}