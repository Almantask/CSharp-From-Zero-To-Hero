using System;

namespace BootCamp.Chapter
{
    internal static class Program
    {
        private const int cipherKey = 10;
        private const string message = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua";

        private static void Main(string[] args)
        {
            Console.WriteLine($"Caesar cipher demo");
            Console.WriteLine($"Message: {message} | key: {cipherKey}{Environment.NewLine}");
            var encryptedMessage = CaesarCipher.Encrypt(message, cipherKey);
            Console.WriteLine($"Encryption result: {encryptedMessage}");

            var decryptedMessage = CaesarCipher.Decrypt(encryptedMessage, cipherKey);
            Console.WriteLine($"Decryption result: {decryptedMessage}");
            Console.WriteLine();

            Console.WriteLine($"Testing frequency attack...{Environment.NewLine}");
            var posibleKeys = CaesarCipher.AnalyseFrequency(encryptedMessage);

            Console.WriteLine($"{posibleKeys.Length} possible key found.{Environment.NewLine}");
            Console.WriteLine($"Decryption results: {Environment.NewLine}");

            foreach (var key in posibleKeys)
            {
                var crackedMessage = CaesarCipher.Decrypt(encryptedMessage, key);

                if (key == cipherKey)
                {
                    Console.WriteLine("Decryption key found!");
                    Console.WriteLine($"Key = {key} - {crackedMessage}");

                    break;
                }
                Console.WriteLine($"Key = {key} - {crackedMessage}");
                Console.WriteLine();
            }
        }
    }
}