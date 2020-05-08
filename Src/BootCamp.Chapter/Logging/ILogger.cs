﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Logging
{
    public interface ILogger
    {
        void Log(string message);
        void LogError(string message);
    }
}
