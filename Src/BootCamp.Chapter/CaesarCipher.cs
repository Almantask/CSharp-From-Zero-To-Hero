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
            if (message == null) return null;
            
            char[] array = message.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                var letter = Convert.ToChar(array[i] + shift);
                if (Char.IsUpper(letter) && letter > 'Z' || Char.IsLower(letter) && letter > 'z') letter = Convert.ToChar(letter - 26);
                array[i] = letter;
            }
            return new string(array);
        }

        public static string Decrypt(string message, byte shift)
        {
            if (message == null) return null;
            
            char[] array = message.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                var letter = Convert.ToChar(array[i] - shift);
                if (Char.IsUpper(letter) && letter < 'A' || Char.IsLower(letter) && letter < 'a') letter = Convert.ToChar(letter + 26);
                array[i] = letter;
            }
            return new string(array);
        }
    }
}
