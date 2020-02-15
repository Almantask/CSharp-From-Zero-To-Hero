using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public static class CaesarCipher
    {
        // total number of ASCII printable characters
        private const int totalCharacters = 224;

        // letters E and A are the most used letters in English texts
        // but I found that space character also works the longer the message is.

        // lower case E character
        public static int LowerLetter { get; set; } = 101;

        // upper case E character
        public static int UpperLetter { get; set; } = 69;

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
            var decryptedMessage = Encrypt(encryptedMessage, totalCharacters - cipherKey);
            return decryptedMessage;
        }

        private static bool IsPrintableChar(char inputCharacter)
        {
            // printable characters are in the 32-255 range and not 127(DEL)
            return inputCharacter >= 32 || inputCharacter <= 255 || inputCharacter != 127;
        }

        // this method exists for the cases when dividend % divisor returns negative number
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
            // printable characters are in the 32-256 range and not 127(DEL)
            if (!IsPrintableChar(inputCharacter))
            {
                return inputCharacter;
            }

            const int offset = 32;

            var output = (char)(Mod(inputCharacter + shift - offset, totalCharacters) + offset);
            return output;
        }

        private static bool IsStringValid(string input)
        {
            return !string.IsNullOrEmpty(input) || !string.IsNullOrEmpty(input);
        }

        /// <summary>
        /// Find character repetition frequency in a string.
        /// </summary>
        /// <param name="encryptedMessage"></param>
        /// <returns>Bi-dimensional array containing found characters and number of repetitions</returns>
        public static int[][] AnalyseFrequency(string encryptedMessage)
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

            return ArrayOps.Construct2dArray(repeatedCharacters, numberOfOccurrences);
        }

        /// <summary>
        /// Finds possible encryption keys for Caesar Cipher based on character repetition array
        /// </summary>
        /// <param name="characterOccurrences">bi-dimensional array containing</param>
        /// <returns>an array with possible decryption keys</returns>
        public static int[] FindPosibleKeys(int[][] characterOccurrences)
        {
            // I could have done a characterOccurrences[0] and [1] but
            // despite the fact It's more complicated I learned more about arrays.
            var repeatedCharacters = ArrayOps.Deconstruct2dArray(characterOccurrences, 0);
            var numberOfOccurrences = ArrayOps.Deconstruct2dArray(characterOccurrences, 1);
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

        public static void TestDecrytionKeys(string encryptedMessage, int[] posibleKeys)
        {
            Console.WriteLine($"{posibleKeys.Length} possible key found.{Environment.NewLine}");
            Console.WriteLine($"Decryption results: {Environment.NewLine}");
            foreach (var key in posibleKeys)
            {
                var crackedMessage = CaesarCipher.Decrypt(encryptedMessage, key);

                Console.WriteLine($"Key = {key} - {crackedMessage}");
                Console.WriteLine();
            }
        }
    }
}