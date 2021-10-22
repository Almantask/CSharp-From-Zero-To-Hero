using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");

            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);

            Console.WriteLine("Text to encrypt: {0}", finalString);

            var test = CaesarCipher.Encrypt(finalString, 5);
            Console.WriteLine("Encrypted text: {0}", test);

            var fix = CaesarCipher.Decrypt(test, 5);
            Console.WriteLine("Decrypted text: {0}", fix);

            Console.ReadKey();

        }
    }
}
