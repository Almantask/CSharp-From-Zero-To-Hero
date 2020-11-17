using System;
using System.Text;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.OutputEncoding = Encoding.Default;
            char c = ArrowMovement.GetIndicator('c');
            Console.WriteLine(c);
        }
    }
}
