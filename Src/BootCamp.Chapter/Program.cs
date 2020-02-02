using System;

namespace BootCamp.Chapter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write(TextTable.Build($"Hello{Environment.NewLine}World!", 20));
        }
    }
}