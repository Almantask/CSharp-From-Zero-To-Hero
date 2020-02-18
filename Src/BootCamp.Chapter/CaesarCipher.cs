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
            if (message == null)
            {
                return null;
            }
            byte[] bytes = Encoding.ASCII.GetBytes(message);
            char[] chars = Encoding.ASCII.GetChars(bytes);

            StringBuilder encryptedMessage = new StringBuilder();
            for (int i = 0; i < chars.Length; i++)
            {
                var incrementedChar = chars[i] + shift;
                encryptedMessage.Append((char)incrementedChar);
            }
            return encryptedMessage.ToString();
        }

        public static string Decrypt(string message, byte shift)
        {
            if (message == null)
            {
                return null;
            }
            byte[] bytes = Encoding.ASCII.GetBytes(message);
            char[] chars = Encoding.ASCII.GetChars(bytes);

            StringBuilder decryptedMessage = new StringBuilder();
            for (int i = 0; i < chars.Length; i++)
            {
                var decryptedChar = chars[i] - shift;
                decryptedMessage.Append((char)decryptedChar);
            }
            return decryptedMessage.ToString();
        }
    }
}
