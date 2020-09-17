using System;
using System.Collections.Generic;
using System.IO;
using System.Transactions;
using Console = System.Console;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lesson4.Demo();
            Console.WriteLine(Lesson4.PromptFloat("Enter a number"));
            Console.ReadLine();
        }
    }
}
