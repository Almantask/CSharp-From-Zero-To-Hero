using System;
using System.Text;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            int UpArrow = '\u21A6';
            Console.WriteLine(BinaryConverter.ToInteger("10"));
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("\u21A6");
        }
    }
}
