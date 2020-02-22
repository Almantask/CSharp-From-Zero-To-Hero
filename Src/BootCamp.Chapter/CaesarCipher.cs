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
            return EncryptOrDecrypt(message, shift, true);
        }

        public static string Decrypt(string message, byte shift)
        {
            return EncryptOrDecrypt(message, shift, false);
        }

        /// <summary>
        /// Encrypt or decrypt given message
        /// </summary>
        /// <param name="message"></param>
        /// <param name="shift"></param>
        /// <param name="encrypt"> 
        /// true to encrypt, false to decrypt
        /// </param>
        /// <returns></returns>
        public static string EncryptOrDecrypt (string message, byte shift, bool encrypt)
        {
            if (message == null)
            {
                return null;
            }

            StringBuilder changedMessage = new StringBuilder();
            for (int i = 0; i < message.Length; i++)
            {
                if (encrypt)
                {
                    changedMessage.Append((char)(message[i] + shift));
                }
                else
                {
                    changedMessage.Append((char)(message[i] - shift));
                }                           
            }
            return changedMessage.ToString();
        }
    }
}
