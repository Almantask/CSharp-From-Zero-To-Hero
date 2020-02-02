using System;

namespace BootCamp.Chapter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write(TextTable.Build($"Good evening,{Environment.NewLine}how are you today?", 4));
        }
    }
}