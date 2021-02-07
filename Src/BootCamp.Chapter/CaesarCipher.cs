using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    // ToDo: Change code so it only allows letters from an alphabet.

    /// <summary>
    /// Caesar cipher which supports all ASCII character (256 in total)
    /// </summary>
    public static class CaesarCipher
    {
       
        private const int MOD26 = 26;

        public static string Encrypt(string message, byte shift)
        {
            return CipherText(message, shift);
        }

        public static string Decrypt(string message, byte shift)
        {
            return CipherText(message, MOD26 - shift);
        }

        private static string CipherText(string inputText, int shift)
        {
            if (string.IsNullOrEmpty(inputText)) return inputText;

            var text = new StringBuilder();

            foreach (var characterNumber in inputText)
            {
                text.Append(PlainChar(characterNumber, shift));
            }
            return text.ToString();
        }

        
        private const char UPPER = 'A';

        private const char LOWER = 'a';

        private static char PlainChar(char character, int digitKey)
        {
            if (!char.IsLetter(character)) return character;

            char counterBalance = char.IsUpper(character) ? UPPER : LOWER;

            return (char)

                ((((character + digitKey) - counterBalance) % MOD26) + counterBalance);
        }
    }
}