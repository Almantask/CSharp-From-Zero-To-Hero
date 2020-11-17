using System;
using System.Text;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Random random = new Random();
            byte shift = (byte)random.Next(128);
            var bytes = new byte[2];
            random.NextBytes(bytes);
            var chars = Encoding.ASCII.GetChars(bytes);
            string input =new string(chars);
            string encrypt = CaesarCipher.Encrypt(input, shift);
            string decrypt = CaesarCipher.Decrypt(encrypt, shift);
            Console.WriteLine($"Input Message is {input}, Shift is {shift}, Encrypted value is {encrypt},Decrypted value is {decrypt}");


        }
    }
}
