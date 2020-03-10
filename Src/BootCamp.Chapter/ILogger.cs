using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public interface ILogger
    {
        void SetMessage(string message);

        void Log();
    }
}