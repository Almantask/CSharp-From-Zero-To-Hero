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
                output.Append(EncodeLetter(inputChar, cipherKey));
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

        private static char EncodeLetter(char inputCharacter, int cipherKey)
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

        public static void AnalyseFrequency(string encryptedMessage)
        {
            if (!IsStringValid(encryptedMessage))
            {
                Console.WriteLine("Input string is not valid");
            }

            int[] letters = new int[char.MaxValue];

            foreach (char item in encryptedMessage)
            {
                letters[item]++;
            }

            for (int i = 0; i < char.MaxValue; i++)
            {
                if (letters[i] > 0 && char.IsLetter((char)i))
                {
                    Console.WriteLine($"Frequency {i} - {letters[i]}");
                }
            }
        }
    }
}