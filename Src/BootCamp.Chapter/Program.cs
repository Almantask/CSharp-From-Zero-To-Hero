using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CaesarCipher.Decrypt(CaesarCipher.Encrypt("test", 3), 3));
        }
    }
}
