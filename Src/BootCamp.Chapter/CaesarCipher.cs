using System;
using System.Buffers.Binary;
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
            return ApplyAlgorithm(message, shift);
        }

        
        public static string Decrypt(string message, byte shift)
        {
            return ApplyAlgorithm(message, -shift);
        }

        private static string ApplyAlgorithm(string message, int shift)
        {
            if (message == "") return "";
            if (message == null) return null;

            // ISO-8859-1 for one byte per letter for most of all. AsciiEx like.
            // UTF-8 fail in portuguese letters(like é, à, ç), unicode things go wrong.
            var encoding = Encoding.GetEncoding("ISO-8859-1");
            var messageToBytes = encoding.GetBytes(message);

            for (var i = 0; i < messageToBytes.Length; i++)
            {
                if (messageToBytes[i] == 32) continue;
                var newByte = messageToBytes[i] + shift;
                if (newByte < 0) newByte = 256 + newByte;
                if (newByte > 256) newByte %= 256;

                try
                {
                    messageToBytes[i] = Convert.ToByte((newByte));
                }
                catch
                {
                    Console.WriteLine($"Unexpected error while converting {newByte} to byte.");
                    throw;
                }
            }

            return encoding.GetString(messageToBytes);
        }
    }
}
