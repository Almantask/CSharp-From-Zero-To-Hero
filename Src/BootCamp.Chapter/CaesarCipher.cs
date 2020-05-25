using System;
using System.Collections.Generic;
using System.Net.Http;
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

            var charArray = message.ToCharArray();
            var byteArray = ASCIIEncoding.ASCII.GetBytes(charArray);

            for (int i = 0; i < byteArray.Length; i++)
            {
                byteArray[i] += shift;
            }

            return new string(Encoding.ASCII.GetChars(byteArray));

        }

        public static string Decrypt(string message, byte shift)
        {
            if (message == null)
                return null;

            var charArray = message.ToCharArray();
            var byteArray = ASCIIEncoding.ASCII.GetBytes(charArray);

            for (int i = 0; i < byteArray.Length; i++)
            {
                byteArray[i] -= shift;
            }

            return new string(Encoding.ASCII.GetChars(byteArray));
        }
    }
}
