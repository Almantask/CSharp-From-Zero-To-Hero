using System;
using System.Text;

namespace BootCamp.Chapter
{
    /// <summary>
    /// Caesar cipher which supports all ASCII character (256 in total)
    /// </summary>
    public static class CaesarCipher
    {
        const int CypherLength = 95; // number of characters before it loops to the start
        const int IndexOfLastUnusable = 32; //the first 32 chars of ascii are not printable


        public static string Encrypt(string message, byte shift)
        {
            return ShiftCharacters(message, shift);
        }

        public static string Decrypt(string message, byte shift)
        {
            shift = (byte) Math.Abs(CypherLength - shift);

            return ShiftCharacters(message, shift);
        }

        static string ShiftCharacters(string message, int shift)
        {
            if (message == null)
            {
                return null;
            }
            var messageBytes = Encoding.ASCII.GetBytes(message);

            for (int i = 0; i < message.Length; i++)
            {
                var currentCharByte = messageBytes[i];
                byte newByte = Convert.ToByte(((currentCharByte - IndexOfLastUnusable + shift) % CypherLength) + IndexOfLastUnusable);
                messageBytes[i] = newByte;
            }

            var newMessage = Encoding.ASCII.GetString(messageBytes);

            return newMessage;

        }
    }
}
