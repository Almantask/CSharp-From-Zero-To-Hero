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
            if(string.IsNullOrEmpty(message))
               return message;

            int actualShift = shift % 256;
            byte[] bytes = Encoding.ASCII.GetBytes(message);
            for(int i = 0; i < bytes.Length; i++)
            {
                int temp = bytes[i] + actualShift;
                if (temp <= 255)
                    bytes[i] = Convert.ToByte(temp);
                else
                    bytes[i] = Convert.ToByte(temp - 255);
            }
            string result = Encoding.ASCII.GetString(bytes);
            return result;
        }

        public static string Decrypt(string message, byte shift)
        {
            if (string.IsNullOrEmpty(message))
                return message;

            int actualShift = shift % 256;
            byte[] bytes = Encoding.ASCII.GetBytes(message);
            for (int i = 0; i < bytes.Length; i++)
            {
                int temp = bytes[i] - actualShift;
                if (temp >= 0)
                    bytes[i] = Convert.ToByte(temp);
                else
                    bytes[i] = Convert.ToByte(temp + 255);
            }
            string result = Encoding.ASCII.GetString(bytes);
            return result;
        }
    }
}
