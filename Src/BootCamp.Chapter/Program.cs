using System;
using System.Text;

namespace BootCamp.Chapter
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Symmetric key encription
            var encryptString = CaesarCipher.Encrypt("Because decryption is the inverse operation of encryption.", 3);
            Console.WriteLine(encryptString);

            var decryptString = CaesarCipher.Decrypt(encryptString, 3);
            Console.WriteLine(decryptString);
        }
    }
}