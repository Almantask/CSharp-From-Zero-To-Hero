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
            try
            {
                byte[] byteMessage = Encoding.GetEncoding("iso-8859-1").GetBytes(message);
                for (var i = 0; i < byteMessage.Length; i++)
                {
                    
                    byteMessage[i] = (byte)(byteMessage[i] + shift);
                    
                }
                message = System.Text.Encoding.GetEncoding("iso-8859-1").GetString(byteMessage);
            }
            catch(ArgumentNullException e)
            {
                return null;
            }
            

           
            
            return message;
        }

        public static string Decrypt(string message, byte shift)
        {
            try
            {
                byte[] byteMessage = Encoding.GetEncoding("iso-8859-1").GetBytes(message);
                for (var i = 0; i < byteMessage.Length; i++)
                {
                    
                    byteMessage[i] = (byte)(byteMessage[i] - shift);
                    
                }
                message = System.Text.Encoding.GetEncoding("iso-8859-1").GetString(byteMessage);
                return message;
            }
            catch (ArgumentNullException)
            {
                return null;
            }

        }

    }
}
