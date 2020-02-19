using System;
using System.Text;

namespace BootCamp.Chapter
{
    class Lesson10
    {
        public static string EncryptCypher(string message, int shift)
        {
            if (message == null)
            {
                return null;
            }


            if (shift < 0)
            {
                shift = Math.Abs(shift + 95);
            }

            var messageBytes = Encoding.ASCII.GetBytes(message);

            for (int i = 0; i < message.Length; i++)
            {
                var currentCharByte = messageBytes[i];
                byte newByte = Convert.ToByte((((currentCharByte - 32) + shift) % 95) + 32);
                messageBytes[i] = newByte;
            }

            var newMessage = Encoding.ASCII.GetString(messageBytes);

            return newMessage;

        }

        public static string DecryptCypher(string message, int shift)
        {
            return EncryptCypher(message, -shift);
        }
    }
}
