using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace BootCamp.Chapter
{
    class Program
    {
        public static bool flag = true;
        static void Main(string[] args)
        {
            
            while (flag)
            {
                Demo.Demo_Started += Demo.Started;
                Demo.Demo_Started?.Invoke(Selection(), EventArgs.Empty);
            }
            
        }
       
        private static ConsoleKey Selection()
        {
            Console.WriteLine("Select:");
            Console.WriteLine("a) over 18, who do not live in UK, whose surname does not contain letter 'a'.");
            Console.WriteLine("b) under 18,  who do not live in UK, whose surname does not contain letter 'a'.");
            Console.WriteLine("c) who do not live in UK, whose surname and name does not contain letter 'a'.");
            Console.WriteLine("ESC) for exit");
            Console.WriteLine(Environment.NewLine);
            return Console.ReadKey(true).Key;
        }
    }
}
