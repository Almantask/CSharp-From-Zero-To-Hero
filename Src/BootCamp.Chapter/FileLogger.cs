﻿using System;
using System.IO;

namespace BootCamp.Chapter
{
    public class FileLogger : ILogger
    {
        private readonly string logFile = $"Log_{DateTime.Now.Day}-{DateTime.Now.Month}-{DateTime.Now.Year}.log";

        public void Log(string message)
        {
            using StreamWriter logWriter = new StreamWriter(logFile, true);
            logWriter.WriteLine(message);
            logWriter.Close();
        }
    }
}