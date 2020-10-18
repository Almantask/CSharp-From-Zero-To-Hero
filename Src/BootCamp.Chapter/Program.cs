using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleUI consoleUI = new ConsoleUI("credfile.txt");
            consoleUI.Run();
        }
    }
}
