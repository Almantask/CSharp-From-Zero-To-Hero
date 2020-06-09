using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    interface ILogger
    {
        /// <summary>
        /// Used to log the Action at the current Date and Time
        /// </summary>
        /// <param name="action"></param>
        void ActionLog(string action);

        /// <summary>
        /// Used to log any errors or exceptions raised at the current Date and Time
        /// </summary>
        /// <param name="error"></param>
        void ErrorLog(string error);
    }
}
