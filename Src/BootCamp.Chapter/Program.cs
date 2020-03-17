using System;
using System.Text;

namespace BootCamp.Chapter
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            UserInteraction.DisplayMenu();
        }
    }
}