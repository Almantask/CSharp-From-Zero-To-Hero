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
            var output = ""; 

            if (String.IsNullOrEmpty(message))
            {
                return message; 
            }


            foreach (char ch in message)
            {
                output += DecryptOneChar(ch, shift); 
            }

            return output; 
        }

        private static char DecryptOneChar(char ch, byte shift)
        {
            if (!char.IsLetter(ch))
                return ch;

            char offset = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + shift) - offset) % 26) + offset);
        }

        public static string Decrypt(string message, byte shift)
        {
            return Encrypt(message, Convert.ToByte(26 - shift)); 
        }
    }
}
