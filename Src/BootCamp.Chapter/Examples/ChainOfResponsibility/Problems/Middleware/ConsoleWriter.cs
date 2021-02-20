using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Examples.ChainOfResponsibility.Problems.Middleware.Problematic;

namespace BootCamp.Chapter.Examples.ChainOfResponsibility.Problems.Middleware
{
    public class ConsoleWriter : IWriter
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}
