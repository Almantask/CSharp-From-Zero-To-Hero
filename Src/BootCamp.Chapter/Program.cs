using System;

namespace BootCamp.Chapter
{
    internal static class Program
    {
        private const int cipherKey = 20;
        private const string message = "Good evening, Infidels! Hahahaha!";

        private static void Main(string[] args)
        {
            var encryptedMessage = CaesarCipher.Encrypt(message, cipherKey);
            Console.WriteLine(encryptedMessage);

            var decryptedMessage = CaesarCipher.Decrypt(encryptedMessage, cipherKey);
            Console.WriteLine(decryptedMessage);

            CaesarCipher.AnalyseFrequency(encryptedMessage);
        }
    }
}