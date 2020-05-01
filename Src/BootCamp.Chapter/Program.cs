using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            var test = CaesarCipher.Encrypt("This is a test sentencew ZZZZZZ 2312 123! 3###asdasd $$;, asd12!!", 1);
            Console.WriteLine(test);

            var test2 = CaesarCipher.Decrypt(test, 1);
            Console.WriteLine(test2);
        }
    }
}
