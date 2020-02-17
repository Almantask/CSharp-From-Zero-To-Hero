using System;
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
            if (String.IsNullOrEmpty(message))
            {
                return message;
            }

            var sb = new StringBuilder();
            foreach (char ch in message)
            {
                sb.Append(DecryptOneChar(ch, shift));
            }

            return sb.ToString();
        }

        private static char DecryptOneChar(char ch, byte shift)
        {
            const int numberOfCharsInAlphabet = 26;
            const char upperA = 'A';
            const char lowerA = 'a'; 

            if (!char.IsLetter(ch))
            {
                return ch;
            }

            char offset = char.IsUpper(ch) ? upperA : lowerA;
            return (char)((((ch + shift) - offset) % numberOfCharsInAlphabet) + offset);
        }

        public static string Decrypt(string message, byte shift)
        {
            return Encrypt(message, Convert.ToByte(26 - shift));
        }
    }
}