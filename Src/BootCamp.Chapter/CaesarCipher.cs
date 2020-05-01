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
        private const char UpperA = 'A';
        private const char LowerA = 'a';
        private const int numberofKeys = 26;

        public static string Encrypt(string message, byte shift)
        {
            return CiperMessage(message, shift);
        }

        public static string Decrypt(string message, byte shift)
        {
            return CiperMessage(message, 26 - shift);
        }

        private static string CiperMessage(string inputMessage, int shift)
        {
            if (string.IsNullOrEmpty(inputMessage)) return inputMessage;

            var output = new StringBuilder();

            foreach (var character in inputMessage)
            {
                output.Append(CiperChar(character, shift));
            }

            return output.ToString();
        }

        private static char CiperChar(char character, int key)
        {
            if (!char.IsLetter(character)) return character;

            char offset = char.IsUpper(character) ? UpperA : LowerA;
            return (char)((((character + key) - offset) % numberofKeys) + offset);
        }
    }
}
