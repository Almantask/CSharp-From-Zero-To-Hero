using System;
using System.Text;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine(CaesarCipher.Encrypt("Learning", 5));
            Console.WriteLine(CaesarCipher.Decrypt("Qjfwsnsl", 5));
            RandomWord();


        }

        public static void RandomWord()
        {
            Random rand = new Random();
            int byteLength = rand.Next(5, 15);
            byte[] randomByte = new byte[byteLength];
            rand.NextBytes(randomByte);
            Console.OutputEncoding = Encoding.GetEncoding("iso-8859-1");
            var message = System.Text.Encoding.GetEncoding("iso-8859-1").GetString(randomByte);
            Console.WriteLine(message);
        }
    }
}
