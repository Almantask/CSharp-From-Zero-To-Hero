using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public static class CaesarCipher
    {
        private const int cipher = 26;

        public static string Encrypt(string plainMessage, int cipherKey)
        {
            var output = new StringBuilder();
            foreach (var inputChar in plainMessage)
            {
                output.Append(CharEncode(inputChar, cipherKey));
            }
            return output.ToString();
        }

        public static string Decrypt(string encryptedMessage, int cipherKey)
        {
            var decryptedMessage = Encrypt(encryptedMessage, cipher - cipherKey);
            return decryptedMessage;
        }

        private static char CharEncode(char inputCharacter, int cipherKey)
        {
            if (!char.IsLetter(inputCharacter))
            {
                return inputCharacter;
            }

            var d = char.IsUpper(inputCharacter) ? 'A' : 'a';
            var output = (char)((((inputCharacter + cipherKey) - d) % cipher) + d);
            return output;
        }
    }
}