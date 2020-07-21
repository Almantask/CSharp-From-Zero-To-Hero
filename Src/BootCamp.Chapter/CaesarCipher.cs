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
            if (String.IsNullOrEmpty(message)) return message;

            var encryptedMessage = new StringBuilder();

            for (int i = 0; i <= message.Length - 1; i++)
            {
                char encryptedCharacter = Convert.ToChar(message[i] + shift);
                encryptedMessage.Append(encryptedCharacter);
            }
            return encryptedMessage.ToString();
        }

        public static string Decrypt(string message, byte shift)
        {

            if (String.IsNullOrEmpty(message)) return message;

            var decryptedMessage = new StringBuilder();

            for (int i = 0; i <= message.Length - 1; i++)
            {
                char decryptedCharacter = Convert.ToChar(message[i] - shift);
                decryptedMessage.Append(decryptedCharacter);
            }
            return decryptedMessage.ToString();
        }
    }
}
