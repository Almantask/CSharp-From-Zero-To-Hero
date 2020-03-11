using System;
using System.IO;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var textLogger = new Logging.LogToText();
            textLogger.LogOpenProgram();
            try
            {
                int b = 0;
                int i = 10 / b;
                Console.WriteLine("Finshed");
            }
            catch (Exception e)
            {
                textLogger.LogCrash(e);
            }
            
            textLogger.LogCloseProgram();
            
        }
    }
}
