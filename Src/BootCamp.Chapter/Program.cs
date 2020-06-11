using System;
using System.Net.Security;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var message = CaesarCipher.Message(5);

            Console.WriteLine(message);

            Console.WriteLine(CaesarCipher.Encrypt(message, 35));
        }
    }
}
