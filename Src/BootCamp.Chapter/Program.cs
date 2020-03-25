using System;
using System.Text;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //tester();

            Area51 a = new Area51();

            a.Demo();
        }

        private static void tester()
        {
            var str = "abc";
            byte[] by = Encoding.Unicode.GetBytes(str);
            Console.WriteLine(by);
            string textToBeAdded = $"hey,{Encoding.Unicode.GetChars(by)}{Environment.NewLine}";
            Console.WriteLine(textToBeAdded);
        }
    }
}
