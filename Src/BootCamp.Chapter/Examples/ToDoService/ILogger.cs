using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Examples.ToDoService
{
    public interface ILogger
    {
        void Info(string message);
        void Warn(string message);
        void Error(Exception ex);
    }
}
