using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TextTable.Build($"This{Environment.NewLine}is{Environment.NewLine}CODE like omg look at this table lmao", 7));
        }
    }
}
