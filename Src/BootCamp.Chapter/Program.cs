using System;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            int number;
            number = random.Next(); // any random integer.
            number = random.Next(10); // returns a random number between 0 and 9 (inclusive)
            number = random.Next(0, 10); // returns the same as the above.

            double numberD;
            numberD = random.NextDouble(); // returns a number between 0 and 1.
            numberD = random.NextDouble() * 100; // returns a number between 0 and 100.

            var bytes = new byte[10];
            random.NextBytes(bytes); // fill array with numbers 0 - 255.
            var chars = Encoding.ASCII.GetChars(bytes);
            var word = new string(chars); // generate a random word.

            random = new Random();
            random = new Random(Environment.TickCount); // is the same as the above.

            // Don't do it like this:
            for (int i = 0; i < 100; i++)
            {
                var random1 = new Random();
                var num1 = random1.Next(0, 10);

                Console.WriteLine(num1 + " ");
            }
            
            Console.Read();
        }
    }
}
