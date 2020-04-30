using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = CaesarCipher.Encrypt("Test", 2);
            Console.WriteLine(test);
        }
    }
}
