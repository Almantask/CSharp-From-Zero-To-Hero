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
        public static string Encrypt(string message, byte shift)
        {
            return ApplyCipher(message, shift);
        }

        public static string Decrypt(string message, byte shift)
        {
            return ApplyCipher(message, -shift);
        }

        public static string ApplyCipher(string inputMessage, int shift)
        {
            if (string.IsNullOrEmpty(inputMessage)) return inputMessage;

            var bytes = new byte[inputMessage.Length];
            var encoding = Encoding.GetEncoding("ISO-8859-1");

            for (int i = 0; i < inputMessage.Length; i++)
            {
                var currentChar = inputMessage[i];
                var convertedByte = Convert.ToByte(currentChar);
                var shiftedByte = (byte)(convertedByte + shift);

                bytes[i] = shiftedByte;
            }

            var result = Encoding.ASCII.GetChars(bytes);
            inputMessage = new string(result);

            return encoding.GetString(bytes);
        }
    }
}
