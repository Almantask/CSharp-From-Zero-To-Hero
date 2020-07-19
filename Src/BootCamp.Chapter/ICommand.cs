using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    interface ICommand
    {
        bool VerifyCommand(string inputCommand);
    }
}
