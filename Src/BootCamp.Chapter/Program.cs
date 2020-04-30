using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            var test = CaesarCipher.Encrypt("If he had anything confidential to say, he wrote it in cipher, that is, by so changing the order of the letters of the alphabet, that not a word could be made out.", 230);
            Console.WriteLine(test);

            var test2 = CaesarCipher.Decrypt(test, 230);
            Console.WriteLine(test2);
        }
    }
}
