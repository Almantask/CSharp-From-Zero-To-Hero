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
                return null;

            if (message == string.Empty)
                return string.Empty;

            var bytes = new byte[message.Length];

            for (int i = 0; i < message.Length; i++)
            {
                var currentChar = message[i];
                var convertedByte = Convert.ToByte(currentChar);
                byte shiftedByte = (byte) (convertedByte + shift);

                bytes[i] = shiftedByte;
            }

            var result = Encoding.ASCII.GetChars(bytes);
            message = new string(result);

            return message;
        }

        public static string Decrypt(string message, byte shift)
        {
            return message;
        }
    }
}
