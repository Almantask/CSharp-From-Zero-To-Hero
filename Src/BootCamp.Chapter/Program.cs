using System;
using System.Text;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GenerateRandomString(10));
        }
        public static string GenerateRandomString(int length)
        {
            Random random = new Random();
            var bytes = new byte[length];
            random.NextBytes(bytes);
            for (int i = 0; i < length; i++)
            {
                if (bytes[i] > 127)
                {
                    bytes[i] =(byte) (bytes[i] % 127);
                }
            }

            return new string(Encoding.ASCII.GetChars(bytes));
        }
    }

}
