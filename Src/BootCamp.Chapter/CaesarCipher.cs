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
            return ShiftsCharacters(message, shift);
        }

        public static string Decrypt(string message, byte shift)
        {
            return ShiftsCharacters(message, shift * -1);
        }

        public static string ShiftsCharacters(string message, int shift)
        {
            if (message == null)
            {
                return null;
            }

            StringBuilder changedMessage = new StringBuilder();
            for (int i = 0; i < message.Length; i++)
            {
                    changedMessage.Append((char)(message[i] + shift));                                     
            }
            return changedMessage.ToString();
        }
    }
}
