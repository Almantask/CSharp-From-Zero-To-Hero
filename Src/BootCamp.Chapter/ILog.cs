using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    interface ILog
    {
        public void WriteMessageToFile(string messge);
        public void WriteMessageToConsole(string messge);

    }
}
