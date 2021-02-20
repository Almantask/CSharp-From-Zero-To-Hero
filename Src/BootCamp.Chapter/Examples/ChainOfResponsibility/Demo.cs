using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Examples.ChainOfResponsibility.Problems.Middleware;
using BootCamp.Chapter.Examples.ChainOfResponsibility.Problems.Middleware.Solution;

namespace BootCamp.Chapter.Examples.ChainOfResponsibility
{
    public static class Demo
    {
        public static void Run()
        {
            var fileLogger = new LoggerWithManySources(null, new FileWriter("log.txt"));
            var consoleAndFileLogger = new LoggerWithManySources(fileLogger, new ConsoleWriter());

            consoleAndFileLogger.Log("Hello world");
        }
    }
}
