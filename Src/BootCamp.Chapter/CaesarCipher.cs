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
        public static char cipher(char ch, int key)
        {
            if (!char.IsLetter(ch))
            {
                return ch;
            }

            char d = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - d) % 26) + d);
        }

        public static string Encrypt(string message, byte shift)
        {
            try
            {
                string output = string.Empty;

                foreach (char ch in message)
                    output += cipher(ch, shift);

                return output;
            }
            catch (NullReferenceException ex)
            {
                return null;
            }
      
        }

        public static string Decrypt(string message, byte shift)
        {
            try
            {
                byte value = Convert.ToByte(26 - shift);
                return Encrypt(message, value);
            }
            catch (NullReferenceException ex)
            {
                return null;
            }
         
        }
    }
}
