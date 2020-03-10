using System;
using System.IO;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(File.Exists(@"C:\Users\Max\Source\Repos\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Logging\Log.txt"));
        }
    }
}
