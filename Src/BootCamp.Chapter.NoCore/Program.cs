using System;

namespace BootCamp.Chapter.NoCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            for (int i = 0; i < 100; i++)
            {
                random = new Random();
                var number = random.Next();
                Console.WriteLine(number);
            }

            Console.Read();
        }
    }
}
