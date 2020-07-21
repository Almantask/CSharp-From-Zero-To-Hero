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
            return ShiftMessage(message, shift);
        }

        public static string Decrypt(string message, byte shift)
        {
            return ShiftMessage(message, - shift);
        }

        private static string ShiftMessage(string message, int shift)
        {
            if (String.IsNullOrEmpty(message)) return message;

            var shiftedMessage = new StringBuilder();

            for (int i = 0; i <= message.Length - 1; i++)
            {
                char shiftedCharacter = Convert.ToChar(message[i] + shift);
                shiftedMessage.Append(shiftedCharacter);
            }
            return shiftedMessage.ToString();
        }
    }
}
