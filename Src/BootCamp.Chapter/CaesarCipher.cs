using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    /// <summary>
    /// Caesar cipher which supports all ASCII character (256 in total)
    /// </summary>
    public static class CaesarCipher
    {
        public static string Encrypt(string message, byte shift)
        {
            if (string.IsNullOrEmpty(message))
            {
                return message;
            }

            return TransformMessage(message, shift);
        }

        public static string Decrypt(string message, byte shift)
        {
            if (string.IsNullOrEmpty(message))
            {
                return message;
            }

            return TransformMessage(message, shift * -1);
        }

        private static string TransformMessage(string message, int shift)
        {
            var cipheredMessage = new StringBuilder();

            for (var i = 0; i < message.Length; i++)
            {
                cipheredMessage.Append(GetNewLetter(message[i], shift));
            }

            return cipheredMessage.ToString();
        }

        private static char GetNewLetter(char letter, int shift)
        {
            if (!isLetter(letter))
            {
                return letter;
            }

            var letterPosition = GetLetterPosition(letter);

            var newLetterPosition = (letterPosition + shift) % 26;
            if (newLetterPosition < 0)
            {
                newLetterPosition += 26;
            }

            return IsUpper(letter) ? (char)(newLetterPosition + 'A') : (char)(newLetterPosition + 'a');
        }

        private static bool isLetter(char letter)
        {
            if ((letter >= 'a' && letter <= 'z') ||
                (letter >= 'A' && letter <= 'Z'))
            {
                return true;
            }
            return false;
        }

        private static int GetLetterPosition(char letter)
        {
            if (IsUpper(letter))
            {
                return letter - 'A';
            }
            return letter - 'a';
        }

        private static bool IsUpper(char letter)
        {
            if (letter >= 'A' && letter <= 'Z')
            {
                return true;
            }
            return false;
        }
    }
}
