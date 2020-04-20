using System;
using System.Collections.Generic;

namespace BootCamp.Chapter
{

    public class Demo
    {
        Dictionary<string, ConsoleKey> consoleOptions = new Dictionary<string, ConsoleKey>();
        Menu menu;

        public Demo(Menu menu)
        {
            this.menu = menu;
            // Dont forget to add a case in ReadKey().
            consoleOptions.Add("Start", ConsoleKey.Enter);
            consoleOptions.Add("A", ConsoleKey.A);
            consoleOptions.Add("B", ConsoleKey.B);
            consoleOptions.Add("C", ConsoleKey.C);
            consoleOptions.Add("Close", ConsoleKey.Escape);
        }
        public void StartDemo()
        {
            menu.Start(consoleOptions);
        }
    }
}
