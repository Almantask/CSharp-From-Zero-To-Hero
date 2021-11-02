using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public interface ILogBase
    {
        /// <summary>
        /// Base of logger interface
        /// </summary>
        /// <param name="message"></param>

        void Log(string message);

    }
}