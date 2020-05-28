using System;
using System.Text;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GenerateRandomString(100));
        }

        public static string GenerateRandomString(int characters)
        {
            Random random = new Random();
            var bytes = new byte[characters];
            for (int i = 0; i < characters; i++)
            {
                switch (random.Next(0, 2))
                {
                    case 0:
                        bytes[i] = (byte)random.Next(65, 91);
                        break;
                    case 1:
                        bytes[i] = (byte)random.Next(97, 123);
                        break;
                }
            }
            return new string(ASCIIEncoding.ASCII.GetChars(bytes));
        }
    }
}
