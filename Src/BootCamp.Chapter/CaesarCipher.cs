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
            string encryptedMessage = ShiftMessage(message, shift);

            return encryptedMessage;
        }

        public static string Decrypt(string message, byte shift)
        {
            string decryptedMessage = ShiftMessage(message, (int)shift * -1);

            return decryptedMessage;
        }

        public static string ShiftMessage(string message, int shift)
        {
            if (message == null)
            {
                return null;
            }
            
            // Convert message to an array of char
            char[] messageArray = message.ToCharArray();
            var byteArray = new byte[message.Length];

            for (int i = 0; i < message.Length; i++)
            {
                // Get the current position of the character and shift
                int ascii = Convert.ToInt32(messageArray[i]);
                
                // Make sure if we go over the alphabet range, we wrap around
                const int ALPHABET_START = 65;
                const int ALPHABET_LENGTH = 26;
                int asciiWrapped = (ALPHABET_START - ascii + shift) % ALPHABET_LENGTH + ALPHABET_START;
                byte newValue = Convert.ToByte(ascii + shift);
                byteArray[i] = newValue;
            }
            
            // Return the value
            string shiftedMessage = "";
            foreach (byte byteCode in byteArray)
            {
                shiftedMessage += Convert.ToChar(byteCode);
            }
            
            return shiftedMessage;
        }
    }
}
