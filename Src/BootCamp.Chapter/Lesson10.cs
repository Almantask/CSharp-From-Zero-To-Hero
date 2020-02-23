using System;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson10
    { 

        const int CYPHERLENGTH = 95; // number of characters before it loops to the start
        const int UNUSABLE = 32; //the first 32 chars of ascii are not printable
   
        public static string EncryptCypher(string message, int shift)
        {
            return Cypher(message, shift);
        }

        public static string DecryptCypher(string message, int shift)
        {

            shift = Math.Abs(CYPHERLENGTH - shift);
            
            return EncryptCypher(message, shift);
        }

        public static string Cypher(string message, int shift)
        {
            if (message == null)
            {
                return null;
            }
            var messageBytes = Encoding.ASCII.GetBytes(message);

            for (int i = 0; i < message.Length; i++)
            {
                var currentCharByte = messageBytes[i];
                byte newByte = Convert.ToByte(((currentCharByte - UNUSABLE + shift) % CYPHERLENGTH) + UNUSABLE);
                messageBytes[i] = newByte;
            }

            var newMessage = Encoding.ASCII.GetString(messageBytes);

            return newMessage;

        }
    }
}
