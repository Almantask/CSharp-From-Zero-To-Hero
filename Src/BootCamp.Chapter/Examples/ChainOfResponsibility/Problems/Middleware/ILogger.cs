using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Examples.ChainOfResponsibility.Problems.Middleware
{
    public interface ILogger
    {
        void Log(string message);
    }
}
