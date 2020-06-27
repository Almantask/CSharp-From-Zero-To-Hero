using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    /// <summary>
    /// Caesar cipher which supports all ASCII character (256 in total)
    /// </summary>
    public class CaesarCipher
    {
        public static string Encrypt(string message, byte shift)
        {
            return EncryptString(message, shift);
        }

        private static string EncryptString(string message, int shift)
        {
            if (message == null)
            {
                return null;
            }

            List<char> encryptString = new List<char>();

            for (int j = 0; j < message.Length; j++)
            {
                var messageToInt = (int)message[j];
                var messageToIntAddShift = (messageToInt + shift);
                var messageEncrypt = (char)messageToIntAddShift;
                encryptString.Add(messageEncrypt);
                Console.WriteLine(messageEncrypt);
            }

            return new string(encryptString.ToArray());

        }
        public static string Decrypt(string message, byte shift)
        {
            return EncryptString(message, 0 - shift);
        }
    }
}
