using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public interface ILogger
    {
        void LogToConsole(string text);

        void LogToFile(string text);
    }
}
