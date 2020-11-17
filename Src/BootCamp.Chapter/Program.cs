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
            int num = random.Next(10);
            string s = CaesarCipher.Encrypt("ab", 2);
            Console.WriteLine(s);

            string s1 = CaesarCipher.Decrypt(s, 2);
            Console.WriteLine(s1);

        }
    }
}
