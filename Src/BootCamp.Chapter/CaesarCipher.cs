using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace BootCamp.Chapter
{
    /// <summary>
    /// Caesar cipher which supports all ASCII character (256 in total)
    /// </summary>
    public static class CaesarCipher
    {
        private static Random random = new Random();

        public static string Message(int sizeOfArray)
        {
            var bytes = new byte[sizeOfArray];
            random.NextBytes(bytes);
            var chars = Encoding.ASCII.GetChars(bytes);
            var word = new string(chars);

            word = " ";

            return word;
        }

        public static string Encrypt(string message, byte shift)
        {
            var MessageArray = message.ToCharArray();
            var encryptedMessage = "";
            for (int i = 0; i < MessageArray.Length; i++)
            {
                byte byteChar = Convert.ToByte(MessageArray[i]);
                int shiftByte = (byteChar + shift) % 257;
                var character = Convert.ToChar(Convert.ToByte(shiftByte));
                encryptedMessage = encryptedMessage + character;
            }

            return encryptedMessage;
        }

        public static string Decrypt(string message, byte shift)
        {
            return message;
        }
    }
}
